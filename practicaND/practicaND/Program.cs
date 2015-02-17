using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data.DB;
using data.Entities;

namespace practicaND
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona:  1.- Insertar, 2.- Consultar, 3. Modificar, 4. Eliminar");
            var result1 = Console.ReadLine();
            switch (result1)
            {
                case "1":
                    insertar();

                    break;

                case "2":

                    select();

                    break;

                case "3":
                    Console.WriteLine("Selecciona la tabla, 1.- Department, 2.- Project");
                    var result2 = Console.ReadLine();
                    if (result2.Equals("1"))
                    {
                        var departm = dataDB.getDepartment();
                        foreach (Department dep in departm)
                        {
                            Console.WriteLine(dep.Id);


                        }
                        var idPro = Console.ReadLine();
                        updateDepartment(idPro);

                    }
                    Console.WriteLine("Inserción correcta");


                    break;

                case "4":

                    Delete();
                    break;
            }

            dataDB.InsProj();
            dataDB.InsDepart();


        }

        static void select()
        {

            Console.WriteLine("Selecciona la tabla, 1.- Department, 2.- Project");
            var result = Console.ReadLine();

            switch (result)
            {

                case "1":

                    var departm = dataDB.getDepartment();
                    foreach (Department dep in departm)
                    {
                        Console.WriteLine(dep.Id + " " + dep.DepartmentName);


                    }
                    Console.ReadKey();
                    break;
                case "2":
                    var projects = dataDB.getProjects();
                    foreach (Project pro in projects)
                    {
                        Console.WriteLine(pro.Id + " " + pro.Name + " " + pro.Budget);
                    }
                    Console.ReadKey();
                    break;
            }
        }

        static void updateProject(string IdProject)
        {
            dataDB.UpdateProject(new { Name = "Luis", Budget = 3456, StartDate = DateTime.Today }, new { Id = IdProject });

        }

        static void insertar()
        {
            Console.WriteLine("Selecciona la tabla, 1.- Department, 2.- Project");
            var result = Console.ReadLine();

            switch (result)
            {

                case "1":

                    dataDB.InsDepart();
                    break;
                case "2":
                    dataDB.InsProj();
                    break;

                    break;
            }

        }
        static void updateDepartment(string IdProject)
        {
            dataDB.UpdateDepartment(new { Name = "Luis", Budget = 3456, StartDate = DateTime.Today }, new { Id = IdProject });

        }

        static void Delete()
        {
            Console.WriteLine("Selecciona la tabla del elemento a eliminar, 1.- Department, 2.- Project");
            var result = Console.ReadLine();

            switch (result)
            {

                case "1":
                    var result3 = Console.ReadLine();
                    dataDB.DeleteDepartment(result3);
                    break;
                    
                case "2":
                      var result4 = Console.ReadLine();
                    dataDB.DeleteProject(result4);
                    break;

            }


        }

    }

}

