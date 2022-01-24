using System.Text.Json;
using DataFunction;

namespace SerializeFunction
{
    //serialization is the process of converting c# objs into JSON file or other formats
    public class Serialize
    {

        private static string _filepath = "./Database/Car.json";

        
        public static void SerialWriteList(string ride)
        {
            List<string> listOfData = SerialRead();
            listOfData.Add(ride);

            string jsonString = JsonSerializer.Serialize(listOfData, new JsonSerializerOptions {WriteIndented = true});
            
            File.WriteAllText(_filepath, jsonString);
        }

        public static List<string> SerialRead()
        {
            string jsonString = File.ReadAllText(_filepath);

            List<string> userData = JsonSerializer.Deserialize<List<string>>(jsonString);
            return userData;
        }
    }
}