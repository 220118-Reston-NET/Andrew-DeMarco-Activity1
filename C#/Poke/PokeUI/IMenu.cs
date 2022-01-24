namespace PokeUI
{   
    //put I before your interfaceName (IMenu) as a naming convention for interfaces
    //interface keyword is what defines an interface (used for our menu)
    public interface IMenu
    {       
            /// <summary>
            /// Will display the menu and user choices in terminal
            /// </summary>
            void Display();

            /// <summary>
            /// will record the users choice and change/route menu based on choice
            /// </summary>
            /// <returns>Return the menu that will change your screen</returns>
            string UserChoice();
    }
}