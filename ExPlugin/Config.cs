using Exiled.API.Interfaces;

namespace ExPlugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}