using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo2
{
    // 定义一个用于 GPA 排序的比较器类，实现 IComparer<Student> 接口
    class StudentGPAComparer : IComparer<Student>
    {
        // 实现 Compare 方法，用于比较两个 Student 对象的 GPA
        public int Compare(Student? x, Student? y)
        {
            // 按 GPA 降序排序，GPA 高的排在前面
            return y.GPA.CompareTo(x.GPA);
        }
    }

    // 定义 Student 类，并实现 IComparable<Student> 接口
    internal class Student : IComparable<Student> 
    {
        // 学生 ID 属性
        public int Id { get; set; }

        // 学生姓名属性
        public string Name { get; set; }

        // 学生 GPA 属性
        public float GPA { get; set; }

        // 学生年龄属性
        public int Age { get; set; }

  
        public int CompareTo(Student? other)  //这个是通过IComparable 自动implement打出来的，然后 39行再改
        {
            // 使用 String.Compare 按照字母顺序比较 Name，不区分大小写
            int val = String.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
            return val; // 返回比较结果，决定排序顺序
        }
    }
}
