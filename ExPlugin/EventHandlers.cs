using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.API.Extensions;
using Exiled.Events.EventArgs;
using Exiled.Permissions.Extensions;
using MEC;
using Mirror;
using UnityEngine;

namespace ExPlugin
{
    public class EventHandlers
    {
        public System.Random Random { get; private set; }

        public EventHandlers()
        {
            this.Random = new System.Random();
        }

        internal void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(5, "欢迎来到我的服务器(°∀°)ﾉ");
        }
    }
}