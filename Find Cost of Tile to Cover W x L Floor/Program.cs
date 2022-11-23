namespace Find_Cost_of_Tile_to_Cover_W_x_L_Floor;
    class Program
    {
        const int TILE_PER_HOUR = 20;
        const double LABOUR_HOUR_PRICE = 86.0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello friend! Let's change your floor.\nWhat is the price you are expecting to pay per 1 tile?");
        double costSingleTile = Convert.ToDouble(Console.ReadLine());
        double roomArea = 0;
        Console.WriteLine("Got it!\nEnter the number corresponding with the room shape you have:\n" +
            "1. circle\r\n2. suqare or rectangular\r\n3. triangle\r\nType answer here and press enter:"); ;
        double roomShape = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your measurements:");
        if (roomShape == 1)
        {
            Console.WriteLine("Radius ");
            double radius = Convert.ToDouble(Console.ReadLine());
            roomArea = Math.PI * radius * radius;
        }
        if (roomShape == 2)
        {
            Console.WriteLine("What is width?");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is length?");
            double length = Convert.ToDouble(Console.ReadLine());
            roomArea = width * length;
        }
        if (roomShape == 3)
        {
            Console.WriteLine("What is base length?");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is height side length?");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            roomArea = 0.5 * (triangleBase * triangleHeight);
        }

        double priceTileAmmount = roomArea * costSingleTile;
        Console.WriteLine("Your price for tile is ${0:F2}", priceTileAmmount);
        double laborHours = (roomArea / TILE_PER_HOUR);
        double priceLabourAmmount = laborHours * LABOUR_HOUR_PRICE ;
        Console.WriteLine($"It will take {laborHours} hours to get it done, at the " +
            $"labour price of ${LABOUR_HOUR_PRICE} per hour. Grand total with tile supply and handy man work is ${priceLabourAmmount+priceTileAmmount}");
        Console.ReadKey(true);
    }
}
