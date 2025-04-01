using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Mod7CodeFirstdemo.Models;

namespace Mod7CodeFirstdemo.Models
{
    // master table (1 to many)

    public class Department

    {

        [Key]

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } //? means nullable

        public virtual ObservableCollectionListSource<Employee> Employees { get; set; }

    }

}
