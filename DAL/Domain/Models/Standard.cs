using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain.Models
{
    public class Standard:Entity
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
