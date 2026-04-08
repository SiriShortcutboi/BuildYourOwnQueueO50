using System;
using System.Runtime.InteropServices.Marshalling;

public class Program //BuildYourOwnQueueO51
{
	public static void Main()
	{
		Queue<string> turnQueue = new Queue<string>();

        turnQueue.Enqueue("Knight");
        turnQueue.Enqueue("Mage");
        turnQueue.Enqueue("Archer");

        Console.WriteLine($"{turnQueue.Dequeue()} delivers a jousting stab!");//same command prints 
        Console.WriteLine($"{turnQueue.Dequeue()} fires multi-shot explosion spell!");// out 3 different 
        Console.WriteLine($"{turnQueue.Dequeue()} must keep up with the Mage. Fires a volley!");// things
        Console.WriteLine("All turns completed");
    }
}

/* public class SimpleQueue
{
    Enqueue(string item)
    {
        items.Add(inputItem);
        count++;
    }

     Dequeue(string item)
    {
        items.subtract;//not real needs to change
        count++;

    } 
}*/

