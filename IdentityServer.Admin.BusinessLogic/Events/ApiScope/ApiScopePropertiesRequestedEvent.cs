﻿using Skoruba.AuditLogging.Events;
using IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.Admin.BusinessLogic.Events.ApiScope
{
    public class ApiScopePropertiesRequestedEvent : AuditEvent
    {
        public ApiScopePropertiesRequestedEvent(int apiScopeId, ApiScopePropertiesDto apiScopeProperties)
        {
            ApiScopeId = apiScopeId;
            ApiResourceProperties = apiScopeProperties;
        }

        public int ApiScopeId { get; set; }
        public ApiScopePropertiesDto ApiResourceProperties { get; }
    }
}