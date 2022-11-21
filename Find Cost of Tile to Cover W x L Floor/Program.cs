namespace Find_Cost_of_Tile_to_Cover_W_x_L_Floor;
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello friend! Let's change your floor.\nWhat is the price you are expecting to pay per 1 tile?");
        double costSingleTile = (double)Convert.ToDouble(Console.ReadLine());

        double roomArea = 0;

        Console.WriteLine("Got it!\nEnter the number corresponding with the room shape you have:\n" +
            "1. circle\r\n2. suqare or rectangular\r\n3. triangle\r\nType answer here and press enter:"); ;

        double roomShape = (double)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your measurements:");



        if (roomShape == 1)
        {
            Console.WriteLine("Radius ");
            double radius = (double)Convert.ToDouble(Console.ReadLine());

            roomArea = 3.14 * radius* radius;
        }

        if (roomShape== 2)
        {
            Console.WriteLine("What is width?");
            double width = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is length?");
            double length = (double)Convert.ToDouble(Console.ReadLine());

            roomArea = width * length;
        }

        if (roomShape == 3)
        {
            Console.WriteLine("What is base length?");
            double triangleBase = (double)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is height side length?");
            double triangleHeight = (double)Convert.ToDouble(Console.ReadLine());

            roomArea = 1 / 2 * triangleBase * triangleHeight;
        }


        double totalPriceTile = roomArea * costSingleTile;

        Console.WriteLine("Your total price of tile is "+ totalPriceTile);
        double tilesCount = roomArea / 1;
        Console.WriteLine($"Need {tilesCount} pieces of tile 1x1 sized to get it covered.");
        double priseLaborHour = (tilesCount / 20);
        double totalCostWithLabour = priseLaborHour * 86;
        Console.WriteLine($"Will take {priseLaborHour} hours to get it done, at the labour price of $86 per hour. Total cost of tile and worker labour is $ {totalCostWithLabour}");
        Console.ReadKey(true);


    }
}

