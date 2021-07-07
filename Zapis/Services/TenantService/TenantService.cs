using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zapis.Services.TenantService
{
    public class TenantService
    {
        public async Task<List<TenantShortInfo>> GetAllTennants()
        {
            return new List<TenantShortInfo>()
            {
                new TenantShortInfo() { Id = Guid.NewGuid(), Categories = new() { "Auto", "Sport" }, Title = "Auto-Service 1", Phone = "555-101" },
                new TenantShortInfo() { Id = Guid.NewGuid(), Categories = new() { "Auto", "Fun" }, Title = "Auto-Service 2", Phone = "555-102" },
                new TenantShortInfo() { Id = Guid.NewGuid(), Categories = new() { "Food" }, Title = "Food-Service 1", Phone = "555-103" },
                new TenantShortInfo() { Id = Guid.NewGuid(), Categories = new() { "Other" }, Title = "Other-Service 1", Phone = "555-104" }
            };
        }

        public async Task<Tenant> GetTennant(Guid id)
        {
            return new Tenant()
            {
                Id = Guid.NewGuid(), Categories = new() { "Food" }, Title = "Auto-Service 1", Description = "Description", Phone = "555-101",
                Lines = new List<TennantLineInfo>()
                {
                    new TennantLineInfo()
                    {

                    },
                    new TennantLineInfo()
                    {

                    },
                }
            };
        }
    }
}