﻿using Skoruba.AuditLogging.Events;
using IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.Admin.BusinessLogic.Events.IdentityResource
{
    public class IdentityResourceRequestedEvent : AuditEvent
    {
        public IdentityResourceDto IdentityResource { get; set; }

        public IdentityResourceRequestedEvent(IdentityResourceDto identityResource)
        {
            IdentityResource = identityResource;
        }
    }
}