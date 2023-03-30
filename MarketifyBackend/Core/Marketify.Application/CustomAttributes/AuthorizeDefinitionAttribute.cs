namespace Marketify.Application.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuthorizeDefinitionAttribute : Attribute
    {
        public string Menu { get; set; }
        public string Definition { get; set; }
        public ActionType ActionType { get; set; }
    }
}
