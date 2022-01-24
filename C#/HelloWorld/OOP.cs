namespace OOPFunction
{
    //base class
    public class OOP
    {
        public static void OOPMain()
        {
            Console.WriteLine("===Inheritance Demo==");
            Dog dog1 = new Dog();
            dog1.Talk();
            dog1.Talk("German Sheperd");
            Console.WriteLine(dog1.Name);
            
            Dog dog2 = new Dog("Minnie");
            Console.WriteLine(dog2.Name);
        }
    }

    //derrived class
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual void Talk()
        {
            Console.WriteLine("Animal is talking!");

        }

        //method overloading only works with parameters!!!
        public void Talk(string p_talk)
        {
            Console.WriteLine(p_talk + " is talking!");
        }

        public Animal(){
            Name = "Animal";
            Color = "Navy Blue";
        }

        public Animal(string p_name)
        {
            Name = p_name;
            Color = "Navy Blue";
        }

    }

    public class Dog : Animal
    {
        public Dog() : base()
        {

        }
        public Dog(string p_name) : base(p_name)
        {

        }
    
        public override void Talk()
        {
            Console.WriteLine("Barking!");
        }
    
    }

}