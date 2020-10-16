using System;
using System.Collections.Generic;
namespace DrSillyStringzFactory.Models
{
    public class License
    {
         public License()
        {
            this.EngineerLicense = new HashSet<EngineerLicense>();
        }
         public int LicenseId { get; set; } 
        public string LicenseType { get; set; } 
        public string Description {get; set;}
        public virtual ICollection<EngineerLicense> EngineerLicense {get;set;}
    }
}