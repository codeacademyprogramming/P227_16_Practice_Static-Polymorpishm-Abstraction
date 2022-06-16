using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Human[] humans = new Human[0];
            do
            {
                Console.WriteLine("1. Humanlari add ele");
                Console.WriteLine("2. Humanlari goster");
                Console.WriteLine("3. Menudan cix");

                Console.WriteLine("Seciminizi edin");
                answer = Console.ReadLine();
                

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Teacher yoxsa doctor elave etmek istediyinizi yazin");
                        Console.WriteLine("1. Teacher");
                        Console.WriteLine("2. Doctor");
                        string humanType;
                        do
                        {
                            humanType = Console.ReadLine();

                        } while (humanType != "1" && humanType != "2");

                        switch (humanType)
                        {
                            case "1":
                                Teacher teacher = GenerateTeacher();
                                AddHuman(ref humans, teacher);

                                break;
                            case "2":
                                Doctor doctor = GenerateDoctor();
                                AddHuman(ref humans, doctor);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Teacherlari yoxsa doctorlari gostermek isteyirsiniz?");
                        Console.WriteLine("1. Teacher");
                        Console.WriteLine("2. Doctor");
                        string option;
                        do
                        {
                            option = Console.ReadLine();

                        } while (option != "1" && option != "2");
                        switch (option)
                        {
                            case "1":
                                foreach (var item in humans)
                                {
                                    if (item is Teacher)
                                    {
                                        Console.WriteLine($"{item.Name} {item.Surname}");
                                    }
                                }
                                break;
                            case "2":
                                foreach (var item in humans)
                                {
                                    if (item is Doctor)
                                    {
                                        Console.WriteLine($"{item.Name} {item.Surname}");
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (answer !="3");
            
        }
        public static void AddHuman( ref Human[] humans, Human human)
        {
            Array.Resize(ref humans, humans.Length + 1);
            humans[humans.Length - 1] = human;
            Console.WriteLine("Human add olundu");
        }
        public static Teacher GenerateTeacher()
        {
            Console.WriteLine("Teacherin adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Teacherin soyadini daxil edin");
            string surname = Console.ReadLine();

            Teacher humanTeacher = new Teacher()
            {
                Name = name,
                Surname = surname
            };
            return humanTeacher;
        }

        public static Doctor GenerateDoctor()
        {
            Console.WriteLine("Doctorun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Doctorun soyadini daxil edin");
            string surname = Console.ReadLine();

            Doctor humanDoctor = new Doctor()
            {
                Name = name,
                Surname = surname
            };
            return humanDoctor;
        }
    }
}
