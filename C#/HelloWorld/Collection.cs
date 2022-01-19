namespace CollectionFunction
{
    public class Collection
    {
        //Array
        //Used to store a datatype and have a fixed size
        //Syntax: (datatype)[] (name of variable) = new datatype[sizeofarray];

        private int[] _nums = new int[5];

        //Generic collection
        //they store a specific datatype and have variable size
        //syntax: <(datatype)>
        
        //list collection
        //zero based index used to store a datatype and had variable size
        private List<string> _strings = new List<string>();

        //Hashset collection
        //no particular order to the elements
        //CANNOT have duplicate elements
        private HashSet<int> _numsCollection = new HashSet<int>();

        //Dictionary Collection
        //key-value pair information storage
        private Dictionary<string, int> _directory = new Dictionary<string, int>();


        //non-generic collection
        //they store any datatype and have variable size

        public void CollectionMain()
        {
            Console.WriteLine("===Collection Demo===");

            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            foreach (int num in _nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-----------------------------------");

            for (int i = 0; i < _nums.Length; i++)
            {
                Console.WriteLine("currentvalue of i: " + i);
                Console.WriteLine(_nums[i]);
            }
            
            Console.WriteLine("===Generic Collection===");
            Console.WriteLine("=List Demo=");
            _strings.Add("First element");
            _strings.Add("Second element");
            _strings.Add("Third element");

            foreach (string item in _strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Hashset Demo=");
            _numsCollection.Add(1);
            _numsCollection.Add(12);
            _numsCollection.Add(2);
            _numsCollection.Add(3);
        
            foreach (int item in _numsCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=Dictionary Demo=");
            _directory.Add("Stephen", -10000);
            _directory.Add("Vijhan", 1000);
            _directory.Add("Jonathan", 12313);

            Console.WriteLine(_directory["Stephen"]);
            Console.WriteLine(_directory["Jonathan"]);
        }
    }
}