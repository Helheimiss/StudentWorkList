using System;
using System.Collections;

namespace StudentWorkList
{
    public class Student
    {
        private static int id_counter = 1;
        public int id { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string patr { get; private set; }
        public DateTime dof { get; private set; }
        public string group { get; private set; }

        public static Hashtable students = new Hashtable();


        public string getFormatedStud()
        {
            return $"{id}\n{name}\n{surname}\n{patr}\n{dof}\n{group}";
        }


        public Student(string name, string surname, string patr, DateTime dof, string group)
        {
            this.id = id_counter++;
            this.name = name;
            this.surname = surname;
            this.patr = patr;
            this.dof = dof;
            this.group = group;
        }
    }
}
