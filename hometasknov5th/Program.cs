using System;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>(); 

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add an integer");
            Console.WriteLine("2. Get value at index");
            Console.WriteLine("3. Set value at index");
            Console.WriteLine("4. Remove a value"); //islemir yaza bilmedim
            Console.WriteLine("5. Clear the list");
            Console.WriteLine("6. Get the count of items");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice (1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter an integer to add:");
                    int addValue = Convert.ToInt32(Console.ReadLine());
                    myList.Add(addValue);
                    break;

                case "2":
                    Console.WriteLine("Enter an index to get:");
                    int getIndex = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        int value = myList[getIndex];
                        Console.WriteLine($"Value at index {value}");


                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid index. Try again.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter an index to set:");
                    int setIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a value to set:");
                    int setValue = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        myList[setIndex] = setValue;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid index. Try again.");
                    }
                    break;

                //case "4":
                   
                //    break;

                case "5":
                    myList.Clear();
                    Console.WriteLine("List cleared.");
                    break;

                case "6":
                    Console.WriteLine($"Count: {myList.Count}");
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
