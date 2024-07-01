using System.Collections;

namespace _12_StandartInterfaces
{
    class StudentCard: ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
           return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Number : {Number}. Series : {Series}";
        }
    }
    class Student: IComparable<Student>, ICloneable//IComparable
    {
        public string FirstName { get; set; }//0x14789 = 0x8564654
        public string LastName { get; set; }//0x36985 = 0x14789
        public DateTime Birthday { get; set; }//2000.5.6 = 2000.5.6
        public StudentCard StudentCard { get; set; }//0x369852 = 0x14789

        public object Clone()
        {
            Student copy = (this.MemberwiseClone() as Student)!;
            //copy.StudentCard = new StudentCard() { Number = this.StudentCard.Number,
            //    Series = this.StudentCard.Series};
            copy.StudentCard =(StudentCard) this.StudentCard.Clone();
            return copy;
        }

        public int CompareTo(Student? other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }
      
        //public int CompareTo(object? obj)
        //{
        //    if (obj is Student) {
        //        return this.FirstName.CompareTo((obj as Student).FirstName);
        //    }
        //    throw new NotImplementedException();    
        //}

        public override string ToString()
        {
            return $"Name : {FirstName} {LastName}. Birthday : {Birthday.ToShortDateString()}\n" +
                $"Student Card : {StudentCard}\n";
        }

    }
    class LastNameComparer : IComparer<Student>//IComparer
    {
        //public int Compare(object? x, object? y)
        //{
        //    if (x is Student && y is Student) 
        //    {
        //        return (x as Student).LastName.CompareTo( (y as Student).LastName);
        //    }
        //    throw new NotImplementedException();    
        //}
        public int Compare(Student? x, Student? y)
        {
            return x!.LastName.CompareTo(y!.LastName);
        }
    }
    class BirthdayComparer : IComparer<Student>//IComparer
    {
        public int Compare(Student? x, Student? y)
        {
            return x!.Birthday.CompareTo(y!.Birthday);
        }
    }
    class Auditory: IEnumerable
    {
        Student[] students;
        public Auditory()
        {
            students = new Student[]//Array
           {

                new Student
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthday = new DateTime(2005, 4, 7),
                    StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
                },
                new Student
                {
                    FirstName = new string("Olga"),
                    LastName = "Ivanchuk",
                    Birthday = new DateTime(2003, 10, 17),
                    StudentCard = new StudentCard() { Number = 321456, Series = "BA" }
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthday = new DateTime(2006, 3, 12),
                    StudentCard = new StudentCard() { Number = 7412585, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthday = new DateTime(2004, 7, 14),
                    StudentCard = new StudentCard() { Number = 963258, Series = "BK" }
                }
           };
           
       }

        public IEnumerator GetEnumerator()
        {
           return  students.GetEnumerator();   
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students,comparer);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "Bill",
                LastName = "Tomson",
                Birthday = new DateTime(2005, 4, 7),
                StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
            };
            Console.WriteLine(student);
            Student clone = (Student) student.Clone();
            Console.WriteLine(clone);
            clone.FirstName = "Tomas";
            clone.Birthday = new DateTime(  1990,8,7);
            clone.StudentCard.Number = 99999;
            Console.WriteLine(student);
            Console.WriteLine(clone);
            /*
            Auditory auditory = new Auditory();
            foreach (var student in auditory)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("------------- Sort by name ------------");
            auditory.Sort();
            foreach (var student in auditory)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("------------- Sort by lastname ------------");
            auditory.Sort(new LastNameComparer());
            foreach (var student in auditory)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("------------- Sort by birthday ------------");
            auditory.Sort(new BirthdayComparer());
            foreach (var student in auditory)
            {
                Console.WriteLine(student);
            }
            */
        }
    }
}
