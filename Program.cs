

// This file contains the main entry point of the application,
//  where we create an instance of the Account class and provide 
// a simple console interface for the user to interact with their account.

// Oop is a programming paradigm that uses "objects" to design applications.
// Classes are the blueprints for these objects, defining their properties and behaviors.
// Objects are instances of classes, created in memory to perform specific tasks.

// 1.Encapsulation: Bundling data (properties) and methods (functions) that operate on the data into a single unit (class).
// 2.Inheritance: A new class can inherit
// 3.characteristics (properties and methods) from an existing class, 
// allowing for code reuse and the creation of a hierarchical relationship between classes.
// 4.Polymorphism: The ability of different classes to be treated as instances of the same class through a common interface, allowing for flexibility and the ability to use different implementations of a method.
// 5.Abstraction: Hiding the complex implementation details of a class and exposing only the necessary features to the user, making it easier to use and understand.











namespace PataSpaceAcademy {
// --- THE MAIN PROGRAM ---
// This is where the actual application starts running.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Welcome to the Financial Console ===");
        
        // 4. CREATING AN OBJECT (Instantiation)
        // We use the 'Account' blueprint to build a real, active account in memory.
        Account myAccount = new Account("Pata Space");
        Console.WriteLine($"Account created for: {myAccount.AccountName}");

        // 5. THE CONTROL LOOP
        // This keeps the menu running continuously until the user chooses to exit.
        bool running = true;
        while (running)
        {
            // Display the menu options to the user
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Funds");
            Console.WriteLine("3. Withdraw Funds");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            
            // Capture what the user types. The '?? ""' prevents errors if they hit enter without typing.
            string choice = Console.ReadLine() ?? "";

            // 6. THE LOGIC ROUTING (Handling the user's choice)
            if (choice == "1")
            {
                // Accessing the 'Balance' property of our specific object
                Console.WriteLine($"Current Balance: {myAccount.Balance} KES");
            }
            else if (choice == "2")
            {
                Console.Write("Enter amount to deposit: ");
                // Convert the typed text into a decimal number (double)
                double amount = Convert.ToDouble(Console.ReadLine());
                // Trigger the Deposit action on our object
                myAccount.Deposit(amount);
            }
            else if (choice == "3")
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                // Trigger the Withdraw action on our object
                myAccount.Withdraw(amount);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting system. Have a great night!");
                running = false; // This breaks the loop and ends the program safely
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}

}