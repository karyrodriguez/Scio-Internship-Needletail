using Needletail.DataAccess.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Entities
{
    public class Department
    {
        [TableKeyAttribute(CanInsertKey = true)]
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public Guid ParentDepartmentId { get; set; }
    }
}
