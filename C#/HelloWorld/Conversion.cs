namespace ConversionFunction
{
    public class Conversion
    {
        
        public static int _num;
                
        

        //static means that the method will belong to the class itself
        //you do not need an object for this
        //Console.write is an example of a static method in console class
        public static void ConversionMain()
        {
            //implicit - means something done automatically
            //explicit - means you have to write something to tell
            Console.WriteLine("===Conversion Demo");
            int x = 10;
            double y = 85.29;
            string str = ("hello world");

            double anotherDouble = x;
            Console.WriteLine(anotherDouble);

            int anotherInt = (int)y;
            Console.WriteLine(anotherInt);

        }

        public int GiveMeNumber()
        {
            return _num;
        }

    }
}