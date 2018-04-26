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

            //check for only nums
            long egnInLong = 0;
            if (!long.TryParse(EGN,out egnInLong ))
            {
                invalidMsg();
                return false;
            }
            
            //check for valid length
            if (EGN.Length!=10)
            {
                invalidMsg();
                return false;
            }
            //check weight
            int[] arr = {2,4,8,5,10,9,7,3,6 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]*int.Parse(EGN[i].ToString());
            }

            int remainder = sum % 11;
            
            int controlNumber;

            if (remainder<10)
            {
                controlNumber = remainder;
            }
            else
            {
                controlNumber = 0;
            }
            // check the control number if equal to 10-th number
            if (controlNumber!=int.Parse(EGN[9].ToString()))
            {
                invalidMsg();
                return false;
            }
            //check before 1900 and after 1999  
            int month = EGN[2]-'0';
            if (month>5)
            {
                invalidMsg();
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

            //check for days >31
            if (int.Parse(birthDay)>31)
            {
                invalidMsg();
                return false;
            }

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

        public static void invalidMsg()
        {
            Console.WriteLine("Invalid EGN");
        }
    }
}
