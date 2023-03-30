namespace Marketify.Infrastructure.Services.Configurations
{
    public class ApplicationService : IApplicationService
    {
        public List<Menu> GetAuthorizeDefinitionEndpoints(Type type)
        {
            Assembly assembly = Assembly.GetAssembly(type);

            var controllers = assembly.GetTypes().Where(t => t.IsAssignableTo(typeof(ControllerBase)));
            if (controllers is null)
                return Array.Empty<Menu>().ToList();

            List<Menu> menus = new();

            foreach (var controller in controllers)
            {
                var actions = controller.GetMethods().Where(m => m.IsDefined(typeof(AuthorizeDefinitionAttribute)));
                if (actions is null)
                {
                    continue;
                }

                foreach (var action in actions)
                {
                    var attributes = action.GetCustomAttributes(true);
                    if (attributes is null)
                    {
                        continue;
                    }

                    Menu menu = null;

                    var authorizeDefinitionAttribute = attributes.FirstOrDefault(a => a.GetType() == typeof(AuthorizeDefinitionAttribute)) as AuthorizeDefinitionAttribute;
                    if (!menus.Any(m => m.Name == authorizeDefinitionAttribute.Menu))
                    {
                        menu = new() { Name = authorizeDefinitionAttribute.Menu };
                        menus.Add(menu);
                    }
                    else
                        menu = menus.FirstOrDefault(m => m.Name == authorizeDefinitionAttribute.Menu);

                    Application.DTOs.Configuration.Action _action = new()
                    {
                        ActionType = Enum.GetName(typeof(ActionType), authorizeDefinitionAttribute.ActionType),
                        Definition = authorizeDefinitionAttribute.Definition
                    };

                    HttpMethodAttribute httpAttribute = attributes.FirstOrDefault(a => a.GetType().IsAssignableTo(typeof(HttpMethodAttribute))) as HttpMethodAttribute;
                    if (httpAttribute != null)
                        _action.HttpType = httpAttribute.HttpMethods.First();
                    else
                        _action.HttpType = HttpMethods.Get;

                    _action.Code = $"{_action.HttpType}.{_action.ActionType}.{_action.Definition.Replace(" ", "")}";

                    menu.Actions.Add(_action);
                }
            }

            return menus;
        }
    }
}
