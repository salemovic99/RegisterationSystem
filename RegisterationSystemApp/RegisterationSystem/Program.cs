using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace RegisterationSystem
{
    internal class Program
    {
        //Print Menu 
        public static void Menu()
        {
            Console.WriteLine("\tHELLO STUDENTS !");
            Console.WriteLine("--- Regiseration System---");
            Console.WriteLine("->[ 1 ] Add New Student");
            Console.WriteLine("->[ 2 ] Delete Student");
            Console.WriteLine("->[ 3 ] Search For Student");
            Console.WriteLine("->[ 4 ] Print All Students");
            Console.WriteLine("->[ 5 ] Exit");

        }

        //All Menu Cases
        public static void ChoiceMenu(int choice)
        {

            switch (choice)
            {
                case 1: AddStudent(); break;

                case 2:
                    //To Check is DB Students IS empty or Not
                    if (isEmpty(RegistrationSystem.Students))
                    {
                        Console.WriteLine("DB Student is Empty!");
                    }
                    else
                    {
                        Console.Write("Enter ID : ");
                        long id_Delete = Convert.ToInt64(Console.ReadLine());
                        RegistrationSystem.DeleteStudent(id_Delete);
                    }
                    break;

                case 3:
                    //To Check is DB Students IS empty or Not
                    if (isEmpty(RegistrationSystem.Students))
                    {
                        Console.WriteLine("DB Student is Empty!");
                    }
                    else
                    {
                        Console.Write("Enter ID : ");
                        long id_search = Convert.ToInt64(Console.ReadLine());
                        RegistrationSystem.SearchForStudent(id_search);
                    }
                    break;

                case 4:
                    Student student = new Student();
                    student.PrintInfo(RegistrationSystem.Students); break;
                //case 5:; break;
                default:
                    //Empty
                    break;
            }
        }


        //To Add New Student
        public static void AddStudent()
        {
            Student student = new Student();

            Console.Write("Enter Name : ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age : ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Dept : ");
            student.Dept = Console.ReadLine();

            Console.Write("Enter Level : ");
            student.Level = Convert.ToInt32(Console.ReadLine());

            //Add New Student in DB Students
            RegistrationSystem.AddStudent(student);
        }

        //To Check After User Input Choice From Menu
        public static bool isEmpty(ArrayList List)
        {
            if (List.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            //To Select Choice Form Menu
            int Choice;
            //Receive Response From User
            String Response;
            //Back To SystemRegisteration Menu
            bool BackToMneu = true;

            do
            {
                //Print Menu To User
                Menu();

                //Input Choice From User
                Console.Write("Choice : ");
                Choice = Convert.ToInt32(Console.ReadLine());

                //Check User Choice
                ChoiceMenu(Choice);

                //Exit From Program
                if (Choice == 5)
                {
                    break;
                }

            //return To Ask Again
            BackToMneu:

                //Input Response From User
                Console.Write("Back To Main Mune? (Y/N): ");
                Response = Console.ReadLine();

                //Check From Response Cases Yes or No
                if (Response == "y" || Response == "Y" || Response == "yes" || Response == "YES")
                {
                    BackToMneu = true;
                }
                else if (Response == "n" || Response == "N" || Response == "no" || Response == "NO")
                {
                    BackToMneu = false;
                }
                else
                {
                    Console.WriteLine("Pleas input yes Or no".ToUpper());
                    goto BackToMneu;
                }

            } while (BackToMneu);


            Console.ReadKey();
        }
    }
}
