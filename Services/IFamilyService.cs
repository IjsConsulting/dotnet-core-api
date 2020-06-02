using System.Collections.Generic;
using dotnet_core_api.Models;

namespace dotnet_core_api.Services
{
    public interface IFamilyService
    {
        List<Family> GetFamilies();
    }
}