using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_3
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
            Console.WriteLine("Our university is ASUE");
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

    class FacultyOfMenejment : University
    {
        public void HeadOfFaculty()
        {
            Console.WriteLine("Head of faculty of menegment is Manuk Movsisyan");
            Console.WriteLine("Deputy of head is Vardan Vlasyan");
        }
    }

    class DepartmentOfMicroeconomics : FacultyOfMenejment
    {
        public void HeadOfDepartment()
        {
            Console.WriteLine("Head of department of microeconomics is Mikayel Melkumyan");
        }
    }

    class EnterpriseEconomicsAndManagement : DepartmentOfMicroeconomics
    {
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
            Console.WriteLine("");
        }

        public void FirstName()
        {
            throw new NotImplementedException();
        }

        public void Gender()
        {
            throw new NotImplementedException();
        }

        public void MiddleName()
        {
            throw new NotImplementedException();
        }

        public void PassportData()
        {
            throw new NotImplementedException();
        }

        public void PlaceOfResidence()
        {
            throw new NotImplementedException();
        }

        public void Position()
        {
            throw new NotImplementedException();
        }

        public void SecondName()
        {
            throw new NotImplementedException();
        }
    }

    internal class Lesson_3_Task_2
    {
        static void Main()
        {
            University university = new University();
            university.HeadOfUniversity();
        }
    }
}
