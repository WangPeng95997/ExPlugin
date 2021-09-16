using Exiled.API.Interfaces;

namespace ExPlugin
{
    public class Config : IConfig
    {
        // 插件是否开启
        public bool IsEnabled { get; set; } = true;
    }
}