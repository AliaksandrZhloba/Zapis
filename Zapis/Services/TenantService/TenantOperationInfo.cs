using System;
namespace Zapis.Services.TenantService
{
    public class TenantOperationInfo
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public TimeSpan Duration { get; set; }
    }
}