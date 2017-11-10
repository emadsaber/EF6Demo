using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Business.Entities;
using BL.Business.Models.Entities;
using DAL.Domain.Models;
using ELogger;

namespace BL.Mappers
{
    public class VMapper
    {
        #region Student <-> StudentDTO
        public static StudentDTO Map(Student from)
        {
            try
            {
                var to = new StudentDTO();
                to.Id = from.Id;
                to.Name = from.Name;
                to.Age = from.Age;
                to.DateOfBirth = from.DateOfBirth;
                to.Height = from.Height;
                to.Weight = from.Weight;
                to.Photo = from.Photo;
                to.Standard = Map(from.Standard);
                return to;
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return null;
            }
        }
        public static Student Map(StudentDTO from)
        {
            try
            {
                var to = new Student();
                to.Id = from.Id;
                to.Name = from.Name;
                to.Age = from.Age;
                to.DateOfBirth = from.DateOfBirth;
                to.Height = from.Height;
                to.Weight = from.Weight;
                to.Photo = from.Photo;
                to.Standard = Map(from.Standard);
                return to;
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return null;
            }
        }

        #endregion

        #region Standard <-> StandardDTO
        private static Standard Map(StandardDTO from)
        {
            try
            {
                var to = new Standard();
                to.StandardId = from.StandardId;
                to.StandardName = from.StandardName;
                return to;
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return null;
            }
        }
        private static StandardDTO Map(Standard from)
        {
            try
            {
                var to = new StandardDTO();
                to.StandardId = from.StandardId;
                to.StandardName = from.StandardName;
                return to;
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return null;
            }
        } 
        #endregion
    }
}
