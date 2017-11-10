using BL.Business.Models.Entities;
using System;

namespace BL.Business.Entities
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public StandardDTO Standard { get; set; }
    }
}
