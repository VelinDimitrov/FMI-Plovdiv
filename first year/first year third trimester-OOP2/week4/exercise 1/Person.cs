using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Person
    {
        string name;
        int age;
        string egn;
        DateTime birthDate;
        


        public string Name
        {
            get { return name; }
            set {name = value; }
        }


        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Egn
        {
            get { return egn; }
            set { egn = value; }
        }

        public string Gender { get; set; }

        public Person()
        {

        }

        public Person(string name,int age,string egn,string sex)
        {
            this.age = age;
            this.name = name;
            this.egn = egn;
            this.Gender = sex;
        }


        public override string ToString()
        {
            return string.Format("Person name : {0} , Sex : {1}",name ,Gender);
        }


    }
}
