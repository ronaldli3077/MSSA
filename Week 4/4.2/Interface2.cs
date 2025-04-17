using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal interface ICRUD<T>
    {
        void Create(T obj);
        IList<T> GetAll();
        void Update(T obj);
        void Delete(T obj);
    }
    class DataDBOperations : ICRUD<Student>
    {
        // 
        public void Create(Student obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student obj)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }


    class DataOperations : ICRUD<Student>
    {
        static List<Student> students=new List<Student>();
        public void Create(Student obj)
        {
            students.Add(obj);
        }

        public void Delete(Student obj)
        {
            students.Remove(obj);
        }

        public IList<Student> GetAll()
        {
           return students;
        }

        public void Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
