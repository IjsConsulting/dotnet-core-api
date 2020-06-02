using System.Collections.Generic;
using dotnet_core_api.Models;

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
            var families = new List<Family>
            {
                new Family
                {
                    Id = "Andersen.1",
                    LastName = "Andersen",
                    Parents = new Parent[]
                    {
                        new Parent { FirstName = "Thomas" },
                        new Parent { FirstName = "Mary Kay" }
                    },
                    Children = new Child[]
                    {
                        new Child
                        {
                            FirstName = "Henriette Thaulow",
                            Gender = "female",
                            Grade = 5,
                            Pets = new Pet[]
                            {
                                new Pet { GivenName = "Fluffy" }
                            }
                        }
                    },
                    Address = new Address
                    {
                        State = "WA",
                        County = "King",
                        City = "Seattle"
                    },
                    IsRegistered = false
                }
            };
            return families;
        }
    }
}