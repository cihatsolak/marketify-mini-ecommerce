namespace Marketify.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration configuration = serviceProvider.GetRequiredService<IConfiguration>();

            services.AddDbContext<MarketifyDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString(nameof(MarketifyDbContext)));
            });

            services.AddScoped<IProductService, ReadRepository>();
        }
    }
}
