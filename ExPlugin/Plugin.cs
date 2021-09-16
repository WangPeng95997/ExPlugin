using Exiled.API.Features;
using Cassie = Exiled.Events.Handlers.Cassie;
using Item = Exiled.Events.Handlers.Item;
using Map = Exiled.Events.Handlers.Map;
using Player = Exiled.Events.Handlers.Player;
using Scp049 = Exiled.Events.Handlers.Scp049;
using Scp079 = Exiled.Events.Handlers.Scp079;
using Scp096 = Exiled.Events.Handlers.Scp096;
using Scp106 = Exiled.Events.Handlers.Scp106;
using Scp173 = Exiled.Events.Handlers.Scp173;
using Scp914 = Exiled.Events.Handlers.Scp914;
using Server = Exiled.Events.Handlers.Server;
using Warhead = Exiled.Events.Handlers.Warhead;
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

            // 玩家通过验证事件, 一般用于发送进服公告等等
            Player.Verified += EventHandlers.OnVerified;

            base.OnEnabled();
            Log.Info($"{this.Author}: {this.Name}插件已启用!");
        }

        public override void OnDisabled()
        {
            Player.Verified -= EventHandlers.OnVerified;

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