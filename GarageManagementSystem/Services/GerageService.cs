using GarageManagementSystem.Interfaces;

namespace GarageManagementSystem.Services
{
    public class GerageService : IGarageService
    {
        public string GetGarageName()
        {
            return "Main Garage";
        }
    }
}
