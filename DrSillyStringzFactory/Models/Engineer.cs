using System;
using System.Collections.Generic;

namespace DrSillyStringzFactory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.EngineerMachine = new HashSet<EngineerMachine>();
        }
        public int EngineerId { get; set; } 
        public string Name { get; set; }
        public string License { get; set; }

        public virtual ICollection<EngineerMachine> EngineerMachine {get;set;}

    }
}