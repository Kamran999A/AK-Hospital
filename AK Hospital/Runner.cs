using System;
using Exceptions;
using System.Collections.Generic;
using System.IO;
using Helper;
using System.Text;
using System.Threading;

namespace AK_Hospital
{
    class Runner
    {

        static void Write(string name, string surname, List<Time> times, Department Doctors, int id, int id_time)
        {
            using (FileStream fileStream = new FileStream("User's information", FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine($"Name - {name}");
                    streamWriter.WriteLine($"Surname - {surname}");
                    for (int i = 0; i < Doctors.doctors.Count; i++)
                    {
                        if (Doctors.doctors[i].Id == id)
                        {
                            streamWriter.WriteLine(Doctors.doctors[i]);
                        }
                    }
                    for (int i = 0; i < times.Count; i++)
                    {
                        if (times[i]._Id == id_time)
                        {
                            streamWriter.WriteLine(times[i]);
                        }
                    }
                    streamWriter.WriteLine();
                }
            }

        }
        static void Print()
        {
            Console.WriteLine("\n1)Pediatrics\n2)Travmatalogy\n3)Pediatrics\n");


        }
      
        static void MakeMeeting(Department dep, int choice, int id, List<Time> times)
        {
            Doctor.PrintTimes(dep, times, id);
            Thread.Sleep(100);
            if (choice == 1)
            {
                dep.doctors[id].Meeting(choice);
            }
            else if (choice == 2)
            {
                dep.doctors[id].Meeting(choice);
            }
            else if (choice == 3)
            {
                dep.doctors[id].Meeting(choice);
            }
        }
        static void PrintDoctors(Department dep)
        {
            foreach (var item in dep.doctors)
            {
                Console.WriteLine(item);
            }
        }

       
        public static void Runnerr()
        {

            Pediatric department = new Pediatric
            {
                Departmentt = "Pediatric",
                doctors = new List<Doctor> {

                    new Doctor {
                        Name = "Tofiq",
                        Age = 42,
                        Surname = "Bagirov",
                        Workyear = 20
                    },
                    new Doctor {
                        Name = "Tofiq",
                        Age = 35,
                        Surname = "Baloglu",
                        Workyear = 12
                    }
                }
            };
            Traumatology department1 = new Traumatology
            {
                Departmentt = "Traumatology",
                doctors = new List<Doctor> {
                    new Doctor {
                         Name = "Tofiq",
                        Age = 56,
                        Surname = "Dadashli",
                        Workyear = 30

                    },
                    new Doctor {
                        Name = "Tofiq",
                        Age = 72,
                        Surname = "Heyvagul",
                        Workyear = 36

                    },
                    new Doctor {
                        Name = "Tofiq",
                        Age = 19,
                        Surname = "Dozanqurdu",
                        Workyear = 1
                    }
                }
            };
            Stomatology department2 = new Stomatology
            {
                Departmentt = "Stomatology",
                doctors = new List<Doctor> {
                    new Doctor {
                        Name = "Tofiq",
                        Age = 28,
                        Surname = "Alabula",
                        Workyear = 3
                    },
                    new Doctor {
                        Name = "Tofiq",
                        Age = 43,
                        Surname = "Azadi",
                        Workyear = 20
                    },
                    new Doctor {
                        Name = "Tofiq",
                        Age = 29,
                        Surname = "Faiq",
                        Workyear = 5
                    },
                     new Doctor {
                        Name = "Tofiq",
                        Age = 36,
                        Surname = "Tofiqli",
                        Workyear = 13
                    }
                }
            };
            List<Time> times = new List<Time>
           {
         new Time{
                Starts=new DateTime(2021,02,24,09,00,00),
                Ends=new DateTime(2021,02,24,11,00,00)
         },
          new Time{
                Starts=new DateTime(2021,02,24,12,00,00),
                Ends=new DateTime(2021,02,24,14,00,00)
         },
          new Time{
                Starts=new DateTime(2021,02,15,15,00,00),
                Ends=new DateTime(2021,02,24,17,00,00)
         }

            };
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.Clear();
                Console.SetCursorPosition(33, 8);
                Console.WriteLine("Hello let me know some imformation about you.");
                Thread.Sleep(1044);
                Console.Clear(); 

                var name = string.Empty;
                while (true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.SetCursorPosition(33, 10);
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    try
                    {
                        UserHelper.CheckForbiddenCharacter(name);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.SetCursorPosition(33, 12);
                        Console.Beep();
                        var line = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(e.Message);
                        Thread.Sleep(234);
                        Console.Clear();
                        Console.ResetColor();
                    }
                }
                var surname = string.Empty;
                while (true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.SetCursorPosition(33, 10);
                    Console.Write("Surname: ");
                    surname = Console.ReadLine();
                    try
                    {
                        UserHelper.CheckForbiddenCharacterS(surname);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.SetCursorPosition(33, 12);
                        Console.Beep();
                        var line = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(e.Message);
                        Thread.Sleep(234);
                        Console.Clear();
                        Console.ResetColor();
                    }
                }
                int age;
                while (true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.SetCursorPosition(33, 10);
                    Console.WriteLine("Enter your age: ");
                    try
                    {
                    Console.SetCursorPosition(33, 11);
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Beep();
                        var line = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(33, 12);
                        Console.WriteLine(e.Message);
                        Thread.Sleep(234);
                        Console.Clear();
                        Console.ResetColor();
                    }
                }
                var email = String.Empty;
                while (true)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.SetCursorPosition(37, 10);
                    Console.WriteLine("Enter your email: ");
                    Console.SetCursorPosition(33, 11);
                    email = Console.ReadLine();
                    try
                    {
                        MailHelper.ValidateMail(email);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Beep();
                        var line = Console.CursorTop;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(33, 12);
                        Console.WriteLine(e.Message);
                        Thread.Sleep(234);
                        Console.Clear();
                        Console.ResetColor();
                    }
                }
                label:
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine($"Welcome {name} {surname}!");
                Console.WriteLine($"Okay mr/mrs {name} {surname}");
                string choice;
                int choiceDoc;
                int choiceTime;

                Print();
                choice = Console.ReadLine();

                Console.Clear();
                switch (choice)
                {
                    case "1":
                        label2:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(department);
                        int abc = 0;
                        try
                        {
                            Console.SetCursorPosition(33, 11);
                            choiceDoc = Convert.ToInt32(Console.ReadLine());
                         abc = choiceDoc;
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.Beep();
                            var line = Console.CursorTop;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.SetCursorPosition(33, 12);
                            Console.WriteLine(e.Message);
                            Thread.Sleep(234);
                            Console.Clear();
                            Console.ResetColor();
                        }

                        switch (abc)
                        {
                            case 1:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department, choiceTime, 0,times);
                                Write(name, surname, times, department, 0, choiceTime);

                                break;
                            case 2:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department, choiceTime, 0,times);
                                Write(name, surname, times, department, 1, choiceTime);
                                break;

                            default:
                                goto label2;
                                break;
                        }
                        break;
                    case "2":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        label3:
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(department1);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 3:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department1, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 0,times);
                                Write(name, surname, times, department1, 0, choiceTime);
                                break;
                            case 4:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department1, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 1, times);
                                Write(name, surname, times, department1, 1, choiceTime);
                                break;
                            case 5:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department1, times, 2);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 2, times);
                                Write(name, surname, times, department1, 2, choiceTime);
                                break;
                            case 6:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department1, times, 3);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 3, times);
                                break;
                            default:
                                goto label3;
                                break;
                        }
                        break;
                    case "3":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        label4:
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(department2);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 7:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department2, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department2, choiceTime, 0, times);
                                break;
                            case 8:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department2, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department2, choiceTime, 1, times);
                                break;
                            case 9:
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Clear();
                                Doctor.PrintTimes(department2, times, 2);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department2, choiceTime, 2, times);
                                break;
                            default:
                                goto label4;
                                break;
                        }
                        break;
                    default:
                        goto label;
                        break;
                }


            }



        }
    }
}