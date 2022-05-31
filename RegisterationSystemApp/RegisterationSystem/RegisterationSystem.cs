using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RegisterationSystem
{
    internal class RegistrationSystem
    {
        //DB Students
        public static ArrayList Students = new ArrayList();

        //Methods

        //Add Student In DB Students
        public static void AddStudent(Student studnt)
        {
            Students.Add(Student.ID++);
            Students.Add(studnt.Name);
            Students.Add(studnt.Age);
            Students.Add(studnt.Dept);
            Students.Add(studnt.Level);

        }

        //Delete Student By ID
        public static void DeleteStudent(long id)
        {

            //Store Index From SearchForIndexOfId
            var result = SearchForIndexOfId(id);

            //Check From ID is Found Or Not
            if (result != -1)
            {
                //Delete Five Index Started From Result index
                Students.RemoveRange(result, 5);
                Console.WriteLine($"{id} Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }


        }

        //Search For Student By ID
        public static void SearchForStudent(long id)
        {
            //Store Index From SearchForIndexOfId
            var result = SearchForIndexOfId(id);

            //Check From ID is Found Or Not
            if (result != -1)
            {
                //Just For Print Formatting
                Console.WriteLine("ID          | Name |Age|  Dept | Level |");
                Console.WriteLine("-----------------------------------------");

                //for loop Start From  Index Of ID 
                for (var i = result; i < result + 5; i++)
                {
                    Console.Write(Students[i] + " | ");
                }

                //New Line After End Specific Print Info
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }


        }

        //Return Index Of ID
        public static int SearchForIndexOfId(long id)
        {
            /*
             * For Search in DB Students
             * 
             * incress i + 5 To Sreach Abute ID Only in DB Students
            */

            for (int i = 0; i < Students.Count; i += 5)
            {
                if (Students.IndexOf(id) == i)
                {
                    return i;
                }
            }

            //Function Will Return -1 if ID Not Fond
            return -1;
        }
    }
}
