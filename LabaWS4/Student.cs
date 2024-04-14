using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSpace
{
    internal class Student
    {
        string surname;
        string initials;
        string numofgroup;
        private uint age;

        public Student()
        {
            this.surname = "undefined";
            this.initials = "undefined";
            this.numofgroup = "undefined";
            this.age = 0;
        }
        public Student(string surname, string initials, string numofgroup, uint age)
        {
            this.surname = surname;
            this.initials = initials;
            this.numofgroup = numofgroup;
            this.age = age;
        }
        
        public void getInfo(Student student)
        {
            Console.WriteLine($"{student.surname}, {this.initials}, {this.numofgroup}, {this.age}");
        }
    }
}
namespace ReaderSpace
{
    internal class Reader
    {
        private string fullname;
        uint librarycardnum;
        string faculty;
        private string borndate;
        string phonenumber;

        public Reader()
        {
            this.fullname = "undefined";
            this.librarycardnum = 0;
            this.faculty = "undefined";
            this.borndate = "undefined";
            this.phonenumber = "undefined";
        }
        public Reader(string fullname, uint librarycardnum, string faculty, string borndate, string phonenumber)
        {
            this.fullname = fullname;
            this.librarycardnum = librarycardnum;
            this.faculty = faculty;
            this.borndate = borndate;
            this.phonenumber = phonenumber;
        }

        public void takeBook(uint booksquantity)
        {
            Console.WriteLine($"{this.fullname} взял {booksquantity} книги");
        }
        public void takeBook(params string[] books)
        {
            string result = " ";
            foreach (string i in books)
            {
                if (i == books[0])
                    result = $"{this.fullname} взял книги {i}";
                else
                    result += $", {i}";
            }
            Console.WriteLine(result);
        }
        public void returnBook(uint booksquantity)
        {
            Console.WriteLine($"{this.fullname} вернул {booksquantity} книги");
        }
        public void returnBook(params string[] books)
        {
            string result = " ";
            foreach (string i in books)
            {
                if (i == books[0])
                    result = $"{this.fullname} взял книги {i}";
                else
                    result += $", {i}";
            }
            Console.WriteLine(result);
        }
    }
}
