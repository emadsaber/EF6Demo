using BL.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Business.Entities;
using DAL.Data.Handlers;
using DAL.Domain.Models;
using BL.Mappers;
using ELogger;

namespace BL.Business.Handlers
{
    public class StudentsHandler : IStudentHandler
    {
        #region Variables
        StudentDataHandler dataHandler;
        #endregion

        #region Constructors
        public StudentsHandler()
        {
            dataHandler = new StudentDataHandler();
        }
        #endregion

        #region Methods
        public bool DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public StudentDTO GetStudentById(int id)
        {
            var studentDomain = dataHandler.Get(new Student() { Id = id });
            return VMapper.Map(studentDomain);
        }

        public bool NewStudent(StudentDTO student)
        {
            try
            {
                if (student == null) return false;

                var studentDomain = VMapper.Map(student);
                return dataHandler.Add(studentDomain);
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return false;
            }
        }

        public int? StudentsCount()
        {
            try
            {
                return dataHandler.GetAll().Count;
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return null;
            }
        }

        public bool UpdateStudent(StudentDTO student)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
