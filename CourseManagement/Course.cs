using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement
{
    class Course
    {
        private static int codeId;
        public string courseName { get; set; }
        public int code { get; set; }
        public int kredi { get; set; }
        public int akts { get; set; }
        public string lecturerName { get; set; }
        public string lecturerSurename { get; set; }

        public void printCours()
        {
            Console.WriteLine("Ders Kodu:" + code);
            Console.WriteLine("Ders İsmi:" + courseName);
            Console.WriteLine("Hocanın adı, soyadı:" + lecturerName + " " + lecturerSurename);
        }

        public Course(string courseName, int code, int kredi, int akts, string lecturerName, string lecturerSurename)
        {
            this.courseName = courseName;
            this.code = code;
            codeId++;
            this.code = codeId;
            this.kredi = kredi;
            this.akts = akts;
            this.lecturerName = lecturerName;
            this.lecturerSurename = lecturerSurename;
        }
    }
    
}
