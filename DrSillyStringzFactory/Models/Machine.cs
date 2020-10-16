using System.Collections.Generic;
namespace DrSillyStringzFactory.Models
{
    public class Machine 
    {
     public Machine()
        {
            this.EngineerMachine = new HashSet<EngineerMachine>();            
        }
        public int MachineId {get; set;} 
        public string Name {get;set;}
        public virtual ICollection<EngineerMachine> EngineerMachine {get; set;}
        
        
}
}
