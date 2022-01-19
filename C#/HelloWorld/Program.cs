// See https://aka.ms/new-console-template for more information
// using CarFunction;

// Console.WriteLine("Hello, World!");

// //NameofClass NameofVariable = new NameofClass();
// Car car1 = new Car();
// Console.WriteLine(car1.Color);
// car1.Color = "Red";
// Console.WriteLine(car1.Color);
// car1.Fuel = 10;
// Console.WriteLine(car1.Fuel);
// car1.Start();
// car1.Start(100);

// Car car2 = new Car()
// {
//     Color = "Yellow",
//     Fuel = 100,
//     Owner = "Stephen"
// };

// Console.WriteLine(car2.Color);
//Console.WriteLine(car2.TotalDistance());

// Console.WriteLine("Welcome to programming!");
// Console.WriteLine("Please tell me your name:");
// string userName = Console.ReadLine();
// Console.WriteLine($"Hello {userName}, what do you want to do today?");
// Console.WriteLine("1: Add 2 Numbers");
// Console.WriteLine("2: Exit Program");

// string userInput = Console.ReadLine();

// if (userInput == "1")
// {
//     Console.WriteLine("Please give me two numbers:");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"The sum is: {num1+num2}");    
// }


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// bool repeat = true;
// int skydives = 0;
// int scubaDiveTime = 0;


// while (repeat)
// {
//     Console.WriteLine("-----------------------------------------------");
//     Console.WriteLine("Andrew's Adventure Menu");
//     Console.WriteLine("Enter a number for what you would like to do:");
    
//     Console.WriteLine("1: Go Skydiving!");
//     Console.WriteLine("2: Go Scuba Diving!");
//     Console.WriteLine("3: Go to an Amusement Park");
//     Console.WriteLine("4: Go to Bed (this will exit program)");

//     string menuInput = Console.ReadLine();

//     switch(menuInput)
//     {
//         case "1":
//             skydives = skydives + 1;
//             Console.WriteLine($"Congradulations! You have gone skydiving {skydives} time(s)!");
//             break;
//         case "2":
//             Console.WriteLine("How many minutes did you scuba dive for?");
//             int scubaTime = Convert.ToInt32(Console.ReadLine());
//             scubaDiveTime = scubaDiveTime + scubaTime;
//             Console.WriteLine($"Nice! That makes {scubaDiveTime} minute(s) in total!");
//             break;
//         case "3":
//             Console.WriteLine("What did you ride?");
//             string amusementRide = Console.ReadLine();
//             Console.WriteLine($"{amusementRide} is a great ride!");
//             break;
//         case "4":
//             Console.WriteLine("Goodnight.");
//             repeat = false;
//             break;
//     }

// }

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using CollectionFunction;

Collection collect = new Collection();

collect.CollectionMain();