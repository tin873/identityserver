﻿using Skoruba.AuditLogging.Events;
using IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace IdentityServer.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiResourceUpdatedEvent : AuditEvent
    {
        public ApiResourceDto OriginalApiResource { get; set; }
        public ApiResourceDto ApiResource { get; set; }

        public ApiResourceUpdatedEvent(ApiResourceDto originalApiResource, ApiResourceDto apiResource)
        {
            OriginalApiResource = originalApiResource;
            ApiResource = apiResource;
        }
    }
}