using System.Collections.Generic;
using dotnet_core_api.models;

namespace dotnet_core_api.Services
{
    public interface IFamilyService
    {
        List<Family> GetFamilies();
    }

    public class FamilyService : IFamilyService
    {
        public List<Family> GetFamilies()
        {
            throw new System.NotImplementedException();
        }
    }
}