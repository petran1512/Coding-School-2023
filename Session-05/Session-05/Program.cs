using Session_05;
{
    Console.WriteLine("First Exersice:"); ExersiceOne exersiceone = new ExersiceOne();
    Console.Write(exersiceone.Reverse()); Console.WriteLine("\n");

    Console.WriteLine("Second Exersice:"); ExersiceTwo exersicetwo = new ExersiceTwo();
    Console.Write(exersicetwo.Choose()); Console.WriteLine("\n");

    Console.WriteLine("Third Exersice:"); ExThree exersicethree = new ExThree();
    Console.Write(exersicethree.Prime()); Console.WriteLine(" \n");

    Console.WriteLine("Fourth Exersice:"); ExFour exercisefour = new ExFour();
    Console.Write(exercisefour.Multi()); Console.WriteLine(" \n");

    Console.WriteLine("Fifth Exersice:"); ExFive exercisefive = new ExFive();
    Console.Write(exercisefive.Lohi()); Console.WriteLine(" \n");

    Console.ReadLine();
}
