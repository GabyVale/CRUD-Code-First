using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    public class EmployeeProject
    {
        [Key]
        public int ID { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
       // public virtual Cat_Role Cat_Role { get; set; }

    }
}
