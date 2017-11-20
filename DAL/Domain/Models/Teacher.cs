using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain.Models
{
    public class Teacher:Entity
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
