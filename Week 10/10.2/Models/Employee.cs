using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7CodeFirstdemo.Models
{
    //child table 
    public class Employee
    {
        [Key] //它告诉 EF，这个字段（在这里是 EmpId）是数据库表中的主键（Primary Key）
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //DatabaseGeneratedOption 是一个枚举，有三个选项：
        //Identity：表示值由数据库自动递增生成（比如自增 ID，常见于 SQL Server）。
        //Computed：表示值由数据库计算生成（比如某个计算列）。
        //None：表示值不由数据库生成，而是由应用程序手动提供。
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; } 
        public int DepartmentID { get; set; } //外键
        public virtual Department Department { get; set; } //导航属性 relationship 


    }
}
