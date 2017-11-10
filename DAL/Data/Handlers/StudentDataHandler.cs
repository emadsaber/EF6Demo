using DAL.Data.Context;
using DAL.Data.Contracts;
using DAL.Domain.Models;
using ELogger;
using ELogger.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Handlers
{
    public class StudentDataHandler : IDataHandler<Student>
    {
        private SchoolDataContext _ctx;
        public StudentDataHandler()
        {
            this._ctx = new SchoolDataContext();
        }
        public bool Add(Student entity)
        {
            try
            {
                this._ctx.Students.Add(entity);
                return this._ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Logs.Log(ex, LogLevel.Error);
                return false;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                //var student = this._ctx.Students.First(s => s.Id == entity.Id);
                //this._ctx.Entry<Student>(student).State= 
                return false;
            }
            catch (Exception ex)
            {
                Logs.LogError(ex);
                return false;
            }
        }

        public Student Get(Student entity)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            return this._ctx.Students.ToList();
        }

        public bool Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
