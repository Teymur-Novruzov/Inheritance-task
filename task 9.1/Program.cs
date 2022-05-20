using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_9._1
{
    abstract class Storage
    {
        public string Media_name { get; set; }
        public string Model { get; set; }
        public double Memory { get; set; }
        public double Free_memory { get; set; }
        public Storage(string Media_name, string Model, double memory, double free_memory)
        {
            this.Media_name = Media_name;
            this.Model = Model;
            this.Memory = memory;
            this.Free_memory = free_memory;
        }
        public void Media_size()
        {
            Console.WriteLine(" All memory : "+this.Memory);
        }
        public void Copy()
        {
            Console.Clear();
            double sending_files_size = this.Memory - this.Free_memory;
            int sending_files_size_int = (int)sending_files_size;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"   If you want {sending_files_size_int} seconds your files sending ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" YES [1]          NO [2]");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Enter : ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                for (int i = 0; i < sending_files_size_int; i++)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($" {sending_files_size_int-i} second");
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Copy succestful");
                Console.WriteLine();
                Console.WriteLine();
            }


        }
        public void Free_memory_funk()
        {
            Console.WriteLine(" Free memory : " + this.Free_memory);
        }
        public void PrintDeviceİnfo()
        {
            Console.WriteLine($" Media name : {this.Media_name}");
            Console.WriteLine();
            Console.WriteLine($" Model : {this.Model}");
            Console.WriteLine();
            Console.WriteLine($" All memory : {this.Memory}");
            Console.WriteLine();
            Console.WriteLine($" Free memory : {this.Free_memory}");
        }
    }
    class Flash_class : Storage
    {
        public double USB_speed { get; set; }
        public Flash_class(string Media_name,string Model,double memory,double free_memory,double usb_speed):base(Media_name,Model,memory,free_memory)
        {
            this.USB_speed = usb_speed;
        }
    }
    class DVD_class : Storage
    {
        public double Read_Write_speed { get; set; }
        public DVD_class(string Media_name, string Model, double memory, double free_memory, double read_Write_speed) : base(Media_name, Model, memory, free_memory)
        {
            this.Read_Write_speed = read_Write_speed;
        }
    }
    class Hdd_class : Storage
    {
        public double USB_speed { get; set; }

        public string Hdd_size { get; set; }
        public Hdd_class(string Media_name, string Model, double memory, double free_memory, double usb_speed, string hdd_size) : base(Media_name, Model, memory, free_memory)
        {
            this.USB_speed = usb_speed;
            this.Hdd_size = hdd_size;
        }
    }
    class Program
    {
        static void Informations()
        {
            Console.Title = "Question Task";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 22;
            Console.WindowWidth = 90;
        }
        static void Start()
        {
            Informations();
            Flash_class flash_Class = new Flash_class("Samsung","Crazy_flash",501,500,3);
            DVD_class dVD_class = new DVD_class("Msi","Crazy_DVD",1000,500,1);
            Hdd_class hdd_class = new Hdd_class("HB","Crazy_Hdd",1000,500,2," 2sm - 5sm");

            First_page(flash_Class, dVD_class, hdd_class);
        }
        static void First_page(Flash_class flash_Class,DVD_class dVD_Class,Hdd_class hdd_Class)
        { 
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($@"     Choice your storage ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   Flash [1]     DVD [2]     Hdd [3] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Enter : ");
            string first_pages_choice = Console.ReadLine();
            if (first_pages_choice == "1")
            {
                Second_page(flash_Class, dVD_Class, hdd_Class, 1);
            }
            else if (first_pages_choice == "2")
            {
                Second_page(flash_Class, dVD_Class, hdd_Class, 2);
            }
            else if (first_pages_choice == "3")
            {
                Second_page(flash_Class, dVD_Class, hdd_Class, 3);
            }
            else
            {
                Wront_choice();
            }

        }
        static void Second_page(Flash_class flash_Class, DVD_class dVD_Class, Hdd_class hdd_Class,int number)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Media size [1] ");
            Console.WriteLine();
            Console.WriteLine(" Copy [2] ");
            Console.WriteLine();
            Console.WriteLine(" Free memory [3] ");
            Console.WriteLine();
            Console.WriteLine(" All informations [4] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Enter : ");
            string second_pages_choice = Console.ReadLine();
            if (second_pages_choice == "1")
            {
                if (number == 1)
                {
                    Console.Clear();
                    flash_Class.Media_size();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice=Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
                else if (number == 2)
                {
                    Console.Clear();
                    dVD_Class.Media_size();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }

                }
                else if (number == 3)
                {
                    Console.Clear();
                    hdd_Class.Media_size();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
            }
            else if (second_pages_choice == "2")
            {
                if (number == 1)
                {
                    Console.Clear();
                    flash_Class.Copy();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
                else if (number == 2)
                {
                    Console.Clear();
                    dVD_Class.Copy();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }

                }
                else if (number == 3)
                {
                    Console.Clear();
                    hdd_Class.Copy();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
            }
            else if (second_pages_choice == "3")
            {
                if (number == 1)
                {
                    Console.Clear();
                    flash_Class.Free_memory_funk();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
                else if (number == 2)
                {
                    Console.Clear();
                    dVD_Class.Free_memory_funk();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }

                }
                else if (number == 3)
                {
                    Console.Clear();
                    hdd_Class.Free_memory_funk();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
            }
            else if (second_pages_choice == "4")
            {
                if (number == 1)
                {
                    Console.Clear();
                    flash_Class.PrintDeviceİnfo();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
                else if (number == 2)
                {
                    Console.Clear();
                    dVD_Class.PrintDeviceİnfo();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }

                }
                else if (number == 3)
                {
                    Console.Clear();
                    hdd_Class.PrintDeviceİnfo();
                    Console.WriteLine();
                    Console.WriteLine(" Back [0] ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Enter : ");
                    string third_choice = Console.ReadLine();
                    if (third_choice == "0")
                    {
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                    else
                    {
                        Wront_choice();
                        Second_page(flash_Class, dVD_Class, hdd_Class, number);
                    }
                }
            }
            else
            {
                Wront_choice();
                Second_page(flash_Class, dVD_Class, hdd_Class, number);
            }
        }
        
        static void Wront_choice()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"                     

                                                   WRONG   ");
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Main(string[] args)
        {
            Start();
        }
    }
}
