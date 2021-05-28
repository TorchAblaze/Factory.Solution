using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }

    [Display(Name = "Installation Date")]
    public string InstallDate { get; set; }

    [Display(Name = "Repairs Needed")]
    public string Repairs { get; set; }
    public string Urgency { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}