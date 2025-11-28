Console.WriteLine("Carpet Cleaning Service");
Console.WriteLine("Small carpet pricem=25$");
Console.WriteLine("Large carpet pricem=35$");
Console.WriteLine("enter the number of Small carpet");
    int number_of_smallcarpets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the number of Large carpet");
     int number_of_largecarpets = Convert.ToInt32(Console.ReadLine());

int number_of_totalcarpets = number_of_smallcarpets + number_of_largecarpets;

int cost_of_smallcarpets = number_of_smallcarpets * 25;
int cost_of_largecarpets = number_of_largecarpets * 35;
int total_cost = cost_of_smallcarpets + cost_of_largecarpets;
int tax = total_cost / 6;
int total_estimate = total_cost + tax;
Console.WriteLine($"number of small carpets={number_of_smallcarpets}");
Console.WriteLine($"number of large carpets={number_of_largecarpets}");
Console.WriteLine($"total number of carpets={number_of_totalcarpets}");
Console.WriteLine($"cost of small carpets={cost_of_smallcarpets}$");
Console.WriteLine($"cost of large carpets={cost_of_largecarpets}$");

Console.WriteLine($"total cost={total_cost}$");
Console.WriteLine($"tax={tax}$");
Console.WriteLine($"total estimate={total_estimate}$");
Console.WriteLine("this estimate is valid for 30 days");
Console.WriteLine("Cashier's name: Ahmed Elsayed Eid");





