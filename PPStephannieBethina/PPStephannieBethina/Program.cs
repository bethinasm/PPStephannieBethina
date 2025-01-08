using PPStephannieBethina;
using System.ComponentModel.Design;
Console.WriteLine("Par Programmering Oppgave\n");

List<Store> allStores = new List<Store>();

Menu();

void Menu()
{
    bool isRunning = true;
    AllStores();

    while (isRunning)
    {
        Console.WriteLine("Welcome to StoreOverview!\nHow can we help you today?\n"); 
        Thread.Sleep(1500);
        Console.WriteLine("[1] View all stores \n[2] View all stores by price level \n[3] View all stores based on desciption \n[4] Add a new store \n[5] Exit program");
        var userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                Thread.Sleep(1000);          
                ViewAllStores();
                break;
            case "2":
                Console.Clear();
                Thread.Sleep(1000);
                ViewByPriceLevel();
                break;
            case "3":
                Console.Clear();
                Thread.Sleep(1000);
                ViewByDescription();
                break;
            case "4":
                Console.Clear();
                Thread.Sleep(1000);
                AddNewStore();
                break;
            case "5":
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("Thank you for using StoreOverview! See you soon!");
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("Not a vaild choice, try again");
                break;
        }
    }

    void AllStores()
    {                                                                                                   
        allStores.Add (new Store("Gamestop", "Gaming", 3));
        allStores.Add (new Store ("H&M", "Clothes", 1));
        allStores.Add (new Store("Meny", "Groceries", 1));
        allStores.Add (new Store ("Cubus", "Clothes", 2));
    }

    void ViewAllStores()
    {
        Console.WriteLine("All stores:\n");
        foreach (var store in allStores)
        {
            store.PrintInfo();
            Console.WriteLine("----------------------------");
        }
        Console.WriteLine();
    }

    void ViewByPriceLevel()
    {
        Console.WriteLine("Enter the price level you want to filter by (1 = cheap, 2 = decent, 3 = expensive)");
        var input = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();

        var filteredStores = allStores.Where (x => x.PriceLevel == input);
        Console.WriteLine($"Stores with price level {input}:\n");
        foreach (var store in filteredStores)
        {
            store.PrintInfo();
            Console.WriteLine("----------------------------");
        }
        Console.WriteLine();
    }

    void ViewByDescription()
    {

    }

   void AddNewStore()
   {
        Console.WriteLine("Enter store name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter store description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter price level for you store \n1 = cheap \n2 = decent \n3 = expensive");    
        int pricelevel = Convert.ToInt32(Console.ReadLine());

        if (pricelevel == 1)
        {
            allStores.Add(new Store(name, description, pricelevel));
            Console.WriteLine("Store successfully added!");
        }
        else if (pricelevel == 2)
        {
            allStores.Add(new Store(name, description, pricelevel));
            Console.WriteLine("Store successfully added!");
        }
        else if (pricelevel == 3)
        {
            allStores.Add(new Store(name, description, pricelevel));
            Console.WriteLine("Store successfully added!");
        }
        else
        {
            Console.WriteLine("Invalid price level. Store not added, try again.");
        }
   }
}