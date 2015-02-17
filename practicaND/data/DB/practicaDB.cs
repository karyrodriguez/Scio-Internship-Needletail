using data.Entities;
using Needletail.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.DB
{
   public class practicaDB
    {

        public const string ConnectionString = "DefaultConnection";
        static DBTableDataSourceBase<Project, Guid> _proj = new DBTableDataSourceBase<Project, Guid>(ConnectionString, "Project");
        public static DBTableDataSourceBase<Project, Guid> Proj
        {
            get
            {
                return _proj;
            }
        }

        
        static DBTableDataSourceBase<Department, Guid> _depart = new DBTableDataSourceBase<Department, Guid>(ConnectionString, "Department");
        public static DBTableDataSourceBase<Department, Guid> Depart
        {
            get
            {
                return _depart;
            }
        }
    }
}
