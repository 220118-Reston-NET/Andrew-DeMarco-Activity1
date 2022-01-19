namespace CarFunction
{
    //Car class
    public class Car
    {
        //Field: stores information or defines current state of object
        //private means only the class itself can use the field
        private string _color;
        private string _owner;
        private int _gallonPerMile;

        //Property
        //They are in PascalCase
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        
        public int Fuel { get; set; }

        //basic method
        public void Start()
        {
            Console.WriteLine("The car is starting now!");
            Console.WriteLine($"Current Fuel: {Fuel}");
        }

        public void Start(int p_fuel)
        {
            Fuel = p_fuel;
            Console.WriteLine("The car is starting now!");
            Console.WriteLine($"Current Fuel: {Fuel}");

        }

        public Car()
        {
            _color = "Blue";
            _owner = "No Owner";
            _gallonPerMile = 10;
            Fuel = 100;    
        }

        //will give the total distance of the car
        public int TotalDistance()
        {
            return Fuel/_gallonPerMile;
        }

    }

}
