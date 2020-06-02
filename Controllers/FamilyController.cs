using System.Collections.Generic;
using dotnet_core_api.Models;
using dotnet_core_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyController
    {
        readonly IFamilyService familyService;

        public FamilyController(IFamilyService familyService)
        {
            this.familyService = familyService;
        }

        [HttpGet]
        public IEnumerable<Family> Get()
        {
            return this.familyService.GetFamilies();
        }
    }
}