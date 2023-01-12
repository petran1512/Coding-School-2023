using Session_04;{
    Console.WriteLine("First Exersice:"); ExersiceOne exersiceone = new ExersiceOne();
    Console.WriteLine(exersiceone.HelloName()); Console.WriteLine("\n");

    Console.WriteLine("Second Exersice:"); ExersiceTwo exersicetwo = new ExersiceTwo();
    Console.WriteLine(exersicetwo.twonum()); Console.WriteLine("\n");

    Console.WriteLine("Third Exersice:"); ExersiceThree exersicethree = new ExersiceThree();
    Console.WriteLine(exersicethree.operations()); Console.WriteLine("\n");

    Console.WriteLine("Fourth Exersice:"); ExersiceFour exersicefour = new ExersiceFour();
    Console.WriteLine(exersicefour.Agener()); Console.WriteLine("\n");

    Console.WriteLine("Fifth Exersice:"); ExersiceFive exersicefive = new ExersiceFive();
    Console.WriteLine(exersicefive.seconds()); Console.WriteLine("\n");

    Console.WriteLine("Sixth Exersice:"); ExersiceSix exersicesix = new ExersiceSix();
    Console.WriteLine(exersicesix.secondswithNetLib()); Console.WriteLine("\n");

    Console.WriteLine("Seventh Exersice:"); ExersiceSeven exersiceseven = new ExersiceSeven();
    Console.WriteLine(exersiceseven.convertion());
    
    Console.ReadLine();
}