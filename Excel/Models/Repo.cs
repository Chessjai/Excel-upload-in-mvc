using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Excel.Models
{
    public class Repo
    {
        public Student GetModels()
        {
            DBCLASS db = new DBCLASS();
            Student model = new Student();
            try
            {
                model.GetStudents = db.Database.SqlQuery<Student>("Select * From excel").ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }
    }
}