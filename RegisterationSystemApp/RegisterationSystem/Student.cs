using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace RegisterationSystem
{
    internal class Student
    {
        //Feilds
        public static long ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Dept { get; set; }
        public int Level { get; set; }

        //Static Constructor
        static Student()
        {
            ID = 19170101000;
        }

        //Method
        public void PrintInfo(ArrayList List)
        {
            if (List.Count == 0)
            {
                Console.WriteLine("DB Student is Empty!");
            }
            else
            {
                Console.WriteLine("ID          | Name  | Age |  Dept | Level |");
                Console.WriteLine("-----------------------------------------");

                for (int i = 0; i < List.Count; i++)
                {
                    if (IsAfterFiveLines(i))
                    {
                        Console.Write("\n");
                    }

                    Console.Write(List[i] + " | ");
                }
                Console.Write('\n');
                Console.WriteLine("-----------------------------------------");
            }

        }


        public bool IsAfterFiveLines(int Line)
        {
            for (int i = 5; i < RegistrationSystem.Students.Count; i += 5)
            {
                if (Line == i)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
