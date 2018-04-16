using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_ID
{
    class Program
    {
        public enum Gender
        {
            Male,Female,None
        }
        static void Main(string[] args)
        {

            string EGN;
            string birthDate;
            Gender gender;
            do
            {
                Console.Write("Enter EGN :");
                 EGN = Console.ReadLine();

            } while (!IsValid(EGN,out birthDate,out gender));

            Console.WriteLine($"EGN : {EGN}");
            Console.WriteLine("BirthDate : "+birthDate);
            Console.WriteLine("Gender : "+gender);
        }
        public static bool IsValid(string EGN,out string birthDate,out Gender gender) {
            //initial set of values
            gender = Gender.None;
            birthDate = "";
            
            //check for valid length
            if (EGN.Length!=10)
            {
                Console.WriteLine("Invalid EGN");
                return false;
            }


            //check before 1900 and after 1999  
            int month = EGN[2]-'0';
            if (month>5)
            {
                Console.WriteLine("Invalid EGN");
                return false;
            }
            
            //set Date
            string birthYear;
            string birthMonth;                
            if (month==2||month==3)
            {
                birthMonth = $"{month - 2}{EGN[3]}";
                birthYear = "18" + EGN.Substring(0, 2);
            }
            else if (month==4||month==5)
            {
                birthMonth = $"{month - 4}{EGN[3]}";
                birthYear = "20" + EGN.Substring(0,2);
            }
            else
            {
                birthMonth = EGN.Substring(2, 2);
                birthYear = "19" + EGN.Substring(0,2);
            }
            
            string birthDay = EGN.Substring(4,2);


            birthDate = $"{birthDay}/{birthMonth}/{birthYear}";

            // set Gender
            int genderNum = EGN[EGN.Length - 2]-'0';

            if (genderNum%2==0)
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }


            return true;
        }

    }
}
