﻿using Skoruba.AuditLogging.Events;

namespace IdentityServer.Admin.BusinessLogic.Identity.Events.Identity
{
    public class UserPasswordChangedEvent : AuditEvent
    {
        public string UserName { get; set; }

        public UserPasswordChangedEvent(string userName)
        {
            UserName = userName;
        }
    }
}