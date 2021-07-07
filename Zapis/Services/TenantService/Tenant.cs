using System;
using System.Collections.Generic;

namespace Zapis.Services.TenantService
{
    public class Tenant : TenantShortInfo
    {
        public List<TennantLineInfo> Lines { get; set; }
    }
}