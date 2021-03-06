﻿using BL.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Business.Contracts
{
    public interface IStudentHandler
    {
        bool NewStudent(StudentDTO student);
        StudentDTO GetStudentById(int id);
        int? StudentsCount();
        bool UpdateStudent(StudentDTO student);
        bool DeleteStudent(int id);
    }
}
