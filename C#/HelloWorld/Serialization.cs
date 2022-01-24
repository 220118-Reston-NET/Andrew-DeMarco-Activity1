using System.Text.Json;
using CarFunction;

namespace SerializationFunction
{
    //serialization is the process of converting c# objs into JSON file or other formats
    public class Serialization
    {

        private static string _filepath = "./Database/Car.json";
        public static void SerialMain()
        {
            Console.WriteLine("===Serialization Demo===");

            Console.WriteLine("=Converting object to JSON");
            List<Car> listOfCars = new List<Car>();

            Car car1 = new Car()
            {
                Color = "silver",
                Fuel = 50,
                Owner = "Stephen"
            };
            
            listOfCars.Add(car1);

            string jsonString = JsonSerializer.Serialize(listOfCars, new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);

            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("=Converting JSON to object");
            
            try
            {
                string jsonString2 = File.ReadAllText(_filepath);


                List<Car> car2 = JsonSerializer.Deserialize<List<Car>>(jsonString);

                Console.WriteLine(car2[0].Color);
                Console.WriteLine(car2[0].Fuel);
                Console.WriteLine(car2[0].Owner);
            }
            //do most generic system execption
            catch (FileNotFoundException)
            {
                //creates a file if file not found and then reads the file
                Console.WriteLine("Creating a new file for you.");
                List<Car> genericList = new List<Car>();
                genericList.Add(new Car());

                string jsonString3 = JsonSerializer.Serialize(genericList);

                File.WriteAllText(_filepath, jsonString3);

                string jsonString2 = File.ReadAllText(_filepath);


                List<Car> car2 = JsonSerializer.Deserialize<List<Car>>(jsonString3);

                Console.WriteLine(car2[0].Color);
                Console.WriteLine(car2[0].Fuel);
                Console.WriteLine(car2[0].Owner);
            }
            //to least generic exception
            catch(SystemException)
            {
                
            }
            //executes regardless if an exception is found or not 
            finally
            {

            }
            
        }
    }
}