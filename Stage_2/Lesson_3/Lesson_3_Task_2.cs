using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_3
{
    enum Prorectors
    {
        ArmenGrigoryan,
        TatulMkrtchyan,
        MamikonHovhannisyan,
        LusineDanielyan,
    }
    enum Faculties
    {
        FacultyOfMenejment,
        FacultyOfEconomicRegulationAndInternationalEconomicRelations,
        FacultyOfFinance,
        FacultyOfMarketingAndBusinessOrganization,
        FacultyOfAccountingAndAuditing,
        FacultyOfInformaticsAndStatistics,
    }

    interface IPeopleCharacters
    {
        void FirstName();
        void SecondName();
        void MiddleName();
        void Gender();
        void PassportData();
        void PlaceOfResidence();
    }
    interface ITeacherCharacters
    {
        void Department();
        void Position();
    }
    interface IStudents
    {
        void AboutParents();
        void Group();
    }

    class University
    {
        public void UniversityName()
        {
            Console.WriteLine("University: ASUE");
        }
        public void HeadOfUniversity()
        {
            Console.WriteLine("Rector of university is Diana Galoyan");
            Console.WriteLine("Head of rector's stuff is Narek Antonyan");
                                  
            Console.WriteLine("Prorectors are:");
            foreach (string item in Enum.GetNames(typeof(Prorectors)))
            {
                Console.WriteLine(item);
            }
        }
    }

    class FacultyOfManagement : University
    {
        public void FacultyName()
        {
            Console.WriteLine("Faculty: Management");
        }
        public void HeadOfFaculty()
        {
            Console.WriteLine("Head of faculty of menegment is Manuk Movsisyan");
            Console.WriteLine("Deputy of head is Vardan Vlasyan");
        }
    }

    class DepartmentOfMicroeconomics : FacultyOfManagement
    {
        public void DepartmentName()
        {
            Console.WriteLine("Department: Microeconomics");
        }
        public void HeadOfDepartment()
        {
            Console.WriteLine("Head of department of microeconomics is Mikayel Melkumyan");
        }
    }

    class EnterpriseEconomicsAndManagement : DepartmentOfMicroeconomics
    {
        public void StudentGroupName()
        {
            Console.WriteLine("Student group name: Enterprise of economics and management");
        }
        public void HeadOfStudensGroup()
        {
            Console.WriteLine("Head of students group is Emma Movsisyan");
        }
    }

    class Student1 : EnterpriseEconomicsAndManagement, IPeopleCharacters, IStudents
    {
        public void AboutParents()
        {
            Console.WriteLine("Father is Zaven Yegoryan");
            Console.WriteLine("Mother is Julieta Barsegyan");
        }

        public void FirstName()
        {
            Console.WriteLine("Arthur");
        }

        public void Gender()
        {
            Console.WriteLine("Male");
        }

        public void Group()
        {
            Console.WriteLine("Economics and manegement of enterprise");
        }

        public void MiddleName()
        {
            Console.WriteLine("Zaveni");
        }

        public void PassportData()
        {
            Console.WriteLine("AN00000000");
        }

        public void PlaceOfResidence()
        {
            Console.WriteLine("city Abovyan");
        }

        public void SecondName()
        {
            Console.WriteLine("Yegoryan");
        }
    }

    class Teacher1 : EnterpriseEconomicsAndManagement, IPeopleCharacters, ITeacherCharacters
    {
        public void Department()
        {
            Console.WriteLine("Enterprise of economics and management");
        }

        public void FirstName()
        {
            Console.WriteLine("Emma");
        }

        public void Gender()
        {
            Console.WriteLine("Female");
        }

        public void MiddleName()
        {
            Console.WriteLine("-------");
        }

        public void PassportData()
        {
            Console.WriteLine("AN00000000");
        }

        public void PlaceOfResidence()
        {
            Console.WriteLine("City Yerevan");
        }

        public void Position()
        {
            Console.WriteLine("Head of students group 1");
        }

        public void SecondName()
        {
            Console.WriteLine("Movsisyan");
        }
    }

    internal class Lesson_3_Task_2
    {
        static void Main()
        {            
            Student1 student1 = new Student1();

            Console.WriteLine("Information about student 1:");

            student1.UniversityName();
            student1.FacultyName();
            student1.DepartmentName();
            student1.StudentGroupName();
            Console.WriteLine();
            
            Console.Write("First name: ");
            student1.FirstName();

            Console.Write("Second name: ");
            student1.SecondName();

            Console.Write("Middle name: ");
            student1.MiddleName();

            Console.Write("Gender: ");
            student1.Gender();

            Console.Write("Passport seria: ");
            student1.PassportData();

            Console.Write("Place of residence: ");
            student1.PlaceOfResidence();

            Console.Write("Group: ");
            student1.Group();

            Console.WriteLine("About parents:");
            student1.AboutParents();                        
            Console.WriteLine();


            Teacher1 teacher1 = new Teacher1();

            Console.WriteLine("Information about teacher 1:");

            Console.Write("First name: ");
            teacher1.FirstName();

            Console.Write("Second name: ");
            teacher1.SecondName();

            Console.Write("Middle name: ");
            teacher1.MiddleName();

            Console.Write("Gender: ");
            teacher1.Gender();

            Console.Write("Passport seria: ");
            teacher1.PassportData();

            Console.Write("Place of residence: ");
            teacher1.PlaceOfResidence();

            Console.Write("Department: ");
            teacher1.Department();

            Console.Write("Position: ");
            teacher1.Position();
            Console.WriteLine();
        }
    }
}*/
