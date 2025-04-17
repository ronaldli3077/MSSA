namespace Mod4Interfacesdemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建一个整数列表，并初始化一些数值
            List<int> list = new List<int>() { 200, 100, 30, 1000 };
            // 对整数列表进行升序排序
            list.Sort();
            // 遍历排序后的列表并打印每个元素
            foreach (int i in list)
                Console.WriteLine(i);

            // 创建一个字符串列表，并初始化一些名字
            List<string> names = new List<string>() { "Nathan", "Jim", "Don" };
            // 对字符串列表进行字母顺序排序
            names.Sort();
            // 遍历排序后的列表并打印每个名字
            foreach (string name in names)
                Console.WriteLine(name);



            // 创建一个 Student 对象的列表
            List<Student> students = new List<Student>();
            // 添加多个 Student 对象，每个对象都有 Id、Age、GPA 和 Name
            students.Add(new Student() { Id = 1, Age = 12, GPA = 4.5f, Name = "Zach" });
            students.Add(new Student() { Id = 2, Age = 8, GPA = 3.0f, Name = "Frank" });
            students.Add(new Student() { Id = 3, Age = 11, GPA = 4f, Name = "Elizabeth" });
            students.Add(new Student() { Id = 4, Age = 14, GPA = 5.0f, Name = "Alex" });

           // 对 Student 列表进行默认排序（按照 Name 字母顺序，因为 Student 类实现了 IComparable<Student>）
            students.Sort(); // 因为要compare，所以去student class 去加上 IComparable<>

            // 遍历排序后的 Student 列表，然后age display too
            foreach (Student student in students)
                Console.WriteLine(student.Name + " " + student.Age);




           
            Console.WriteLine("GPA sorting");
            // 使用 StudentGPAComparer 进行排序（按照 GPA 降序排序），回到了student.cs 第10行
            students.Sort(new StudentGPAComparer()); // IComparer
            // 遍历排序后的 Student 列表，并按GPA sort，然后display GPA 
            foreach (Student student in students)
                Console.WriteLine(student.Name + " " + student.GPA);

            Console.ReadKey();
        }
    }
}
