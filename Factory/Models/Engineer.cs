using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }

    [Display(Name = "Hire Date")]
    public DateTime HireDate { get; set; } = DateTime.Now;

    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; } = DateTime.Now;

    [Display(Name = "Scheduled Work Hours")]
    public string WorkHours { get; set; }

    [Display(Name = "Scheduled Work Days")]
    public string WorkDays { get; set; }
    public string Licenses { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; }
  }
}