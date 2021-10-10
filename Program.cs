using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    abstract class Student
    {
        public Student(string name)
        {
            m_name = name;
            m_state = "";
        }
        public void Relax()
        {
            m_state += "Relax ";
        }

        public void Read()
        {
            m_state += "Read ";
        }

        public void Write()
        {
            m_state += "Write ";
        }

        public abstract void Study();
        

        public string m_name { get; set; }
        public string m_state;
    }

    class GoodStudent : Student
    {
        public GoodStudent(string m_name) : base(m_name)

        {
            m_state = "Good ";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
          
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string m_name) : base(m_name)

        {
            m_state = "Bad ";
        }
        public override void Study()
        {
            
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
           
        }
    }


    class Group{
        public Group(string m_group)
        {
            this.m_group = m_group ;
            
        }
        public void AddStudent(Student st)
        {
            s.Add(st);
            

        }
        public void GetInfo()
        {
            
            Console.WriteLine(m_group);
            foreach (Student St in s)
            {
                Console.WriteLine(St.m_name);
            }
            
        }
        public void GetFullInfo()
        {
            Console.WriteLine(m_group);
            foreach (Student st in s)
            {
                Console.WriteLine(st.m_name + " " + st.m_state);
               
            }
      
        }
        
        public string m_group;
        public List<Student> s = new List<Student>(); 


    }

    class Program
    {
        static void Main(string[] args)
        {
            GoodStudent student1 = new GoodStudent("Breaker");
            BadStudent student2 = new BadStudent("Tom");

            Console.WriteLine(student1.m_name);
            Console.WriteLine(student2.m_name);
            student1.Study();
            student2.Study();

            Group group1 = new Group("Group1");
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.GetInfo();
            Console.WriteLine();
            group1.GetFullInfo();



            

        }

    }

}