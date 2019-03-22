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
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Company" )]
        public int CompaniID { get; set; }
        public virtual Company Company { get; set; }//Company_Id
}
}
