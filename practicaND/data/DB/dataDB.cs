using data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DB
{
    public class dataDB
    {
        public static void InsProj()

            {

            Project insproj = new Project
            {
                Id = Guid.NewGuid(),
                Name = "Perez",
                Budget = 7894,
                StartDate = new DateTime (2011, 1, 12)
            };
            practicaDB.Proj.Insert(insproj);
        }

        public static void InsDepart()
        {

            Department insdepart = new Department
            {
                Id = Guid.NewGuid(),
                DepartmentName = "Ultimo",
                ParentDepartmentId = Guid.NewGuid(),
                
            };
            practicaDB.Depart.Insert(insdepart);
        }

        public static void DeleteProject(string name)
        {
            practicaDB.Proj.Delete(new { Name = name });
        }

        public static void DeleteDepartment(string dname)
        {
            practicaDB.Depart.Delete(new { DepartmentName = dname });
        }

        public static void UpdateProject(object values, object where)
        {
            practicaDB.Proj.UpdateWithWhere(values: values, where: where);
        }

        public static void UpdateDepartment(object values, object where)
        {
            practicaDB.Depart.UpdateWithWhere(values: values, where: where);
        }

        public static IEnumerable<Project> getProjects()
        {

         return practicaDB.Proj.GetAll();
        }

        public static IEnumerable<Department> getDepartment()
        {

            return practicaDB.Depart.GetAll();
        }
    }
}
