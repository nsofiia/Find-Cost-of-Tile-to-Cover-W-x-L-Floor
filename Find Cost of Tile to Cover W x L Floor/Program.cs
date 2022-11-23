namespace Find_Cost_of_Tile_to_Cover_W_x_L_Floor;
class Program
{
    const int TILE_PER_HOUR = 20;
    const double LABOUR_HOUR_PRICE = 86.0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello friend! Let's change your floor.\nWhat is the price you are expecting to pay per 1 tile?");
        double costSingleTile = 0;
        double roomArea = 0;
        int roomShape = 0;
        while (costSingleTile == 0)
        {
            try
            {
                costSingleTile = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("this input is not supported, use only numbers for price entry");
            }
        }
        Console.WriteLine("Got it!\nEnter the number corresponding with the room shape you have:\n" +
            "1. circle\r\n2. suqare or rectangular\r\n3. triangle\r\nType answer here and press enter:");
        while (roomShape == 0 || roomShape > 3)
        {
            try
            {
                roomShape = Convert.ToInt32(Console.ReadLine());
                if (roomShape > 3)
                {
                    Console.WriteLine("this input is not supported, use numbers from 1 to 3 for room shape selection");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("this input is not supported, use numbers from 1 to 3 for room shape selection");
            }
        }
        Console.WriteLine("Enter your measurements:");
        if (roomShape == 1)
        {
            Console.WriteLine("Radius ");
            double radius = 0;
            while (radius == 0)
            {
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported, use numbers");
                }
            }
            roomArea = Math.PI * radius * radius;
        }
        if (roomShape == 2)
        {
            Console.WriteLine("What is width?");
            double width = 0;
            while (width == 0)
            {
                try
                {
                    width = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported, use numbers");
                }
            }
            Console.WriteLine("What is length?");
            double length = 0;
            while (length == 0)
            {
                try
                {
                    length = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported, use numbers");
                }
            }
            roomArea = width * length;
        }
        if (roomShape == 3)
        {
            Console.WriteLine("What is base length?");
            double triangleBase = 0;
            while (triangleBase == 0)
            {
                try
                {
                    triangleBase = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported, use numbers");
                }
            }
            Console.WriteLine("What is height side length?");
            double triangleHeight = 0;
            while (triangleHeight == 0)
            {
                try
                {
                    triangleHeight = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported, use numbers");
                }
            }
            roomArea = 0.5 * (triangleBase * triangleHeight);
        }
        double priceTileAmmount = roomArea * costSingleTile;
        Console.WriteLine("Your price for all tile is ${0:F2}", priceTileAmmount);
        double laborHours = (roomArea / TILE_PER_HOUR);
        double priceLabourAmmount = laborHours * LABOUR_HOUR_PRICE;
        double grandTotal = priceLabourAmmount + priceTileAmmount;
        Console.WriteLine($"It will take approximately {laborHours.ToString("F0")} hours to get it done, at the " +
            $"labour price of {LABOUR_HOUR_PRICE.ToString("C2")} per hour. Grand total with tile supply and handy man work is {grandTotal.ToString("C2")}");
        Console.ReadKey(true);
    }
}
