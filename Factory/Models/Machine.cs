using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
    public DateTime InstallDate { get; set; } = DateTime.Now;

    [Display(Name = "Repairs Needed")]
    public string Repairs { get; set; }
    public string Urgency { get; set; }

    [Display(Name = "Sceduled Repair Date")]
    public DateTime RepairDate { get; set; } = DateTime.Now;
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}