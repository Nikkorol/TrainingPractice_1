using System;
using System.Linq;

namespace RNC_Task_6
{
    class Program
    {
        public static void ResizeMassString(ref string[] array, int newSize)
        {
            string[] newArray = new string[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public static void ResizeMassInt(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public static void RemoveAtString(ref string[] array, int index)
        {
            string[] newArray = new string[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        public static void RemoveAtInt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        public static void Main(string[] args)
        {
            string[] dosieArr = new string[2];
            string[] posArr = new string[2];
            int[] countArr = new int[2];
            string commandInput, name, lastname, otch;
            countArr[0] = 1;

            int j = 0;
            int i = 1;
            int newLength = 2;
            while (true)
            {
                Console.WriteLine("Human Resources Department\n1 - add dossier\n2 - withdraw all dossiers\n3 - delete dossier \n4 - search by last name \n5 - exit from the program " + "\n");
                Console.Write("Select a menu item: ");
                commandInput = Console.ReadLine();

                if (commandInput == "1")
                {
                    ResizeMassString(ref dosieArr, newLength + 1);
                    ResizeMassString(ref posArr, newLength + 1);
                    ResizeMassInt(ref countArr, newLength + 1);

                    Console.Write("Adding a dossier \n" + "\n" + "Enter your name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    lastname = Console.ReadLine();
                    Console.Write("Enter middle name : ");
                    otch = Console.ReadLine();
                    Console.Write("Enter position : ");
                    posArr[j] = Console.ReadLine();

                    dosieArr[j] = $"{name} {lastname} {otch}";
                    countArr[j] = i++;
                    j++;

                    Console.WriteLine("\n" + "Data entered successfully! \n" + "\n" + "Press any key... ");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "2")
                {
                    if (j != 0 || dosieArr[0] != null)
                        for (int b = 0; b < j; b++)
                        {
                            Console.WriteLine("{0}) {1} - {2}", countArr[b], dosieArr[b], posArr[b]);
                        }
                    else
                        Console.WriteLine("Dossier not found \n" + "\n" + "Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "3")
                {
                    Console.Write("Enter dossier number to delete : ");
                    int deleteNum = int.Parse(Console.ReadLine());

                    RemoveAtString(ref dosieArr, deleteNum);
                    RemoveAtString(ref posArr, deleteNum);
                    RemoveAtInt(ref countArr, deleteNum);

                    Console.WriteLine("Dossier not found\n" + "\n" + "Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "4")
                {
                    Console.WriteLine("Enter last name : ");
                    string search = Console.ReadLine();
                    for (int fam = 0; fam <= j; fam++)
                    {
                        Console.WriteLine("A person with this last name  " + search + (dosieArr[fam].Split(' ').Select(x => x == search).Count() > 0 ? " exists " : " does not exist" + " in the dossier"));
                    }
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "5")
                {
                    Environment.Exit(0);
                    break;
                }
            }
            Console.ReadKey();
        }

    }

}
