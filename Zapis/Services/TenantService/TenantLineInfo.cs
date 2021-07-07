using System.Collections.Generic;

namespace Zapis.Services.TenantService
{
    public class TennantLineInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
        public List<TenantOperationInfo> Operations { get; set; }
    }
}