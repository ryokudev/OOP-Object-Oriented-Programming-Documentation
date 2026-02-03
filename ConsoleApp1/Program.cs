using System;

public abstract class Works { // Abstraction Class
    public abstract void Papers();
    public abstract void Cleaning();
    public abstract void Washing();
}


public class Member : Works { // Parent Class
    // Encapsulated Properties
    public string Name { get; set; }
    public string Role { get; protected set; } = "member";
    public string PersonId { get; set; }

    public void SetInfo(string name, string personId) {
        Name = name; 
        PersonId = personId;
    }

    public void GetInfo() {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Role: " + Role);
        Console.WriteLine("PersonID: " + PersonId);
        Console.WriteLine("___________________");
    }

    public void Work() { // Inheritance
        Console.WriteLine("Member is Working...");
    }

    // Abstracts Override Works
    public override void Washing() {
        Console.WriteLine("Member is Washing...");
    }

    public override void Cleaning() {
        Console.WriteLine("Member is Cleaning...");
    }

    public override void Papers() {
        Console.WriteLine("Member is Working Papers...");
    }
}

public class Staff : Member { 
    public Staff() {
        Role = "staff"; // Override role for Staff
    }
}

public class Janitor : Member { // Child class or Sub Class
    public Janitor() {
        Role = "janitor"; // Override role for Janitor
    }
}


public class Program {
    public static void Main() {
        Member janitor = new Janitor(); // Polymorphism
        Member staff = new Staff(); // Polymorphism

        janitor.SetInfo("justeen", "19090");

        janitor.GetInfo();
        janitor.Cleaning();

        staff.Washing(); // Abstraction
        staff.Papers(); // Abstraction
    } 
}

/*
 * OOP CONCEPTS DEMONSTRATED IN THIS CODE:
 * 
 * 1. ABSTRACTION:
 *    - The 'Works' abstract class defines a contract with abstract methods (Papers, Cleaning, Washing)
 *    - These methods must be implemented by any class that inherits from Works
 *    - Hides complex implementation details and only shows essential features
 * 
 * 2. ENCAPSULATION:
 *    - Properties (Name, Role, PersonId) encapsulate data with controlled access
 *    - Role has a protected setter, restricting modification to the class and its children
 *    - Data is bundled together with methods that operate on that data
 * 
 * 3. INHERITANCE:
 *    - Member inherits from Works (implements abstract methods)
 *    - Staff and Janitor inherit from Member (child classes)
 *    - Promotes code reusability - child classes reuse parent class functionality
 * 
 * 4. POLYMORPHISM:
 *    - Method Overriding: Staff and Janitor override MakePaperWorks() with their own implementations
 *    - Runtime Polymorphism: Member reference variables (janitor, staff) hold child class objects
 *    - Same method call produces different behaviors depending on the actual object type
 *    - Virtual/Override keywords enable polymorphic behavior
 * 
 * EXECUTION FLOW:
 * - Creates Janitor and Staff objects but stores them as Member type (polymorphism)
 * - Sets janitor's info and displays it
 * - Calls inherited methods from Works abstract class
 * - Each object type executes its own version of inherited/overridden methods
 */