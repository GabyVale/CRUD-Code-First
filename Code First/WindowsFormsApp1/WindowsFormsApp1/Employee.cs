using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1
{
    public class Employee
    {
        [Key]
        public int ID{ get; set; }
        public string Firt_Name { get; set; }
        public string Last_Name { get; set; }
        public string Mail { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime StartDate { get; set; }
        [ForeignKey ("Company")]
        public virtual Company IDCompany { get; set; } //ID_Company
        
    }
}
