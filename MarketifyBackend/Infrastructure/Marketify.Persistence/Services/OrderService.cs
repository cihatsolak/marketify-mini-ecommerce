namespace Marketify.Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICompletedOrderWriteRepository _completedOrderWriteRepository;
        private readonly ICompletedOrderReadRepository _completedOrderReadRepository;

        public OrderService(
            IOrderWriteRepository orderWriteRepository, 
            IOrderReadRepository orderReadRepository, 
            ICompletedOrderWriteRepository completedOrderWriteRepository, 
            ICompletedOrderReadRepository completedOrderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
            _completedOrderWriteRepository = completedOrderWriteRepository;
            _completedOrderReadRepository = completedOrderReadRepository;
        }

        public async Task CreateOrderAsync(CreateOrder createOrder)
        {
            var orderCode = (new Random().NextDouble() * 10000).ToString();
            orderCode = orderCode.Substring(orderCode.IndexOf(".") + 1, orderCode.Length - orderCode.IndexOf(".") - 1);

            await _orderWriteRepository.AddAsync(new()
            {
                Address = createOrder.Address,
                Id = Guid.Parse(createOrder.BasketId),
                Description = createOrder.Description,
                OrderCode = orderCode
            });

            await _orderWriteRepository.SaveAsync();
        }

        public async Task<ListOrder> GetAllOrdersAsync(int page, int size)
        {
            var query = _orderReadRepository.Table.Include(o => o.Basket)
                      .ThenInclude(b => b.User)
                      .Include(o => o.Basket)
                         .ThenInclude(b => b.BasketItems)
                         .ThenInclude(bi => bi.Product);

            var data = query.Skip(page * size).Take(size);

            return new()
            {
                TotalOrderCount = await query.CountAsync(),
                Orders = await data.Select(order => new
                {
                    order.Id,
                    order.CreatedDate,
                    order.OrderCode,
                    TotalPrice = order.Basket.BasketItems.Sum(bi => bi.Product.Price * bi.Quantity),
                    order.Basket.User.UserName
                }).ToListAsync()
            };
        }

        public async Task<SingleOrder> GetOrderByIdAsync(string id)
        {
            var data = await _orderReadRepository.Table
                                 .Include(o => o.Basket)
                                 .ThenInclude(b => b.BasketItems)
                                 .ThenInclude(bi => bi.Product)
                                 .FirstOrDefaultAsync(o => o.Id == Guid.Parse(id));

            return new()
            {
                Id = data.Id.ToString(),
                BasketItems = data.Basket.BasketItems.Select(bi => new
                {
                    bi.Product.Name,
                    bi.Product.Price,
                    bi.Quantity
                }),
                Address = data.Address,
                CreatedDate = data.CreatedDate,
                Description = data.Description,
                OrderCode = data.OrderCode
            };
        }

        public async Task<(bool, CompletedOrderDTO)> CompleteOrderAsync(string id)
        {
            Order order = await _orderReadRepository.Table
                .Include(o => o.Basket)
                .ThenInclude(b => b.User)
                .FirstOrDefaultAsync(o => o.Id == Guid.Parse(id));

            if (order != null)
            {
                await _completedOrderWriteRepository.AddAsync(new() { OrderId = Guid.Parse(id) });
                return (await _completedOrderWriteRepository.SaveAsync() > 0, new()
                {
                    OrderCode = order.OrderCode,
                    OrderDate = order.CreatedDate,
                    Username = order.Basket.User.UserName,
                    EMail = order.Basket.User.Email
                });
            }
            return (false, null);
        }
    }
}
