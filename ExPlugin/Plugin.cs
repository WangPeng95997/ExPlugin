using Exiled.API.Features;
//using HarmonyLib;

namespace ExPlugin
{
    public class Plugin : Plugin<Config>
    {
        // 插件作者
        public override string Author => "Lunarid";

        // 插件名称
        public override string Name => "Exiled Plugin";

        public EventHandlers EventHandlers { get; private set; }

        //public Harmony Harmony { get; private set; }

        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers();

            Exiled.Events.Handlers.Player.Joined += EventHandlers.OnJoined;

            base.OnEnabled();
            Log.Info($"{this.Author}: {this.Name}插件已启用!");
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Joined -= EventHandlers.OnJoined;

            EventHandlers = null;
            base.OnDisabled();
            Log.Info($"{this.Author}: {this.Name}插件已禁用!");
        }

        public override void OnReloaded()
        {
            base.OnReloaded();
        }
    }
}