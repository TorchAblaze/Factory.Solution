using System.Collections.Generic;

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
    public string HireDate { get; set; }

    [Display(Name = "Start Date")]
    public string StartDate { get; set; }

    [Display(Name = "Scheduled Work Hours")]
    public string WorkHours { get; set; }

    [Display(Name = "Scheduled Work Days")]
    public string WorkDays { get; set; }
    public string Licenses { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; }
  }
}