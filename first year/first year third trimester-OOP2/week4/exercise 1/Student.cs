using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Student:Person
    {
        public enum University
        {
            PU,SU,TU
        }

       public enum Speciality
        {
            SE,STD,BM,IT
        }
        private University university;

        public University Uni
        {
            get { return university; }
            set { university = value; }
        }

        private Speciality spec;

        public Speciality Spec
        {
            get { return spec; }
            set { spec = value; }
        }


        private string facNum;

        public string FacNum
        {
            get { return facNum; }
            set { facNum = value; }
        }

        public Student()
        {

        }

        public Student(string name, int age, string egn, string sex,
            string facNum,University university ,Speciality speciality):
            base(name,age,egn,sex)
        {
            FacNum = facNum;
            Uni = university;
            Spec = speciality;
        }
        //Worker ima chasove ,zaplashtane i nakraq cqlata zaplata
    }
}
