﻿using Skoruba.AuditLogging.Events;
using IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.Admin.BusinessLogic.Events.ApiScope
{
    public class ApiScopePropertyRequestedEvent : AuditEvent
    {
        public ApiScopePropertyRequestedEvent(int apiScopePropertyId, ApiScopePropertiesDto apiScopeProperty)
        {
            ApiScopePropertyId = apiScopePropertyId;
            ApiScopeProperty = apiScopeProperty;
        }

        public int ApiScopePropertyId { get; set; }

        public ApiScopePropertiesDto ApiScopeProperty { get; set; }
    }
}