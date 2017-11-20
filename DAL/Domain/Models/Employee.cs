using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public DateTime?  HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
