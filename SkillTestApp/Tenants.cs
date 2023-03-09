using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTestApp
{
    internal class Tenants
    {
        public List<Tenant> TenantsList { get; set; }= new List<Tenant>();
      
        public Tenants()
        {
            using (StreamReader r = new StreamReader("tenants.json"))
            {
                string json = r.ReadToEnd();
                this.TenantsList = JsonConvert.DeserializeObject<List<Tenant>>(json);
            }
        }

        public List<string> GetTenantNames()
        {
           return this.TenantsList.Select(x => x.Name).ToList();
        }

        public List<string> GetWriterJobTenantNames()
        {
            return this.TenantsList.Where(x=>x.Job.ToLower() == "writer").Select(x => x.Name).ToList();
        }

        public List<string> GetPets()
        {
            return this.TenantsList.SelectMany(x => x.Pets).Select(x => x).ToList();
        }
    }


    internal class Tenant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public List<string> Pets { get; set; } 
    }

}
