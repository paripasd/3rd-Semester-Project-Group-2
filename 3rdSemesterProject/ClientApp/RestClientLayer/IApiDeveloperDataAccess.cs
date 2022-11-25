using ClientApp.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestClientLayer
{
    internal interface IApiDeveloperDataAccess
    {
        public bool CreateDeveloper(Developer developer);
        public Developer FindDeveloperFromId(int developerId);
        public IEnumerable<Developer> GetAllDevelopers();
        public bool UpdateDeveloper(Developer developer);
        public bool DeleteDeveloper(Developer developer);
    }
}
