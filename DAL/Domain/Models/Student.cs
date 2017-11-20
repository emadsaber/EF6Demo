using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain.Models
{
    public class Student:Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        #region FKs
        public int? StandardId { get; set; }
        public int? TeacherId { get; set; }
        #endregion

        public Standard Standard { get; set; }
        public Teacher Teacher { get; set; }
    }
}
