using System;
using System.Collections.Generic;

namespace Zapis.Services.TenantService
{
    public class TenantShortInfo
    {
        public Guid Id { get; set; }

        public List<string> Categories { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public byte[] Icon { get; set; }
    }
}