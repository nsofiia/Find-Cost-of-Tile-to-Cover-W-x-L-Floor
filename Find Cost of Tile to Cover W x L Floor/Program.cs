namespace Find_Cost_of_Tile_to_Cover_W_x_L_Floor;
class Program
{
    const int TILE_PER_HOUR = 20;
    const double LABOUR_HOUR_PRICE = 86.0;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello friend, let's change your floor!");
        double costSingleTile = 0;
        double roomArea = 0;
        int roomShape = 0;

        while (costSingleTile <= 0)  //if input does not switch initial value to be more than 0 - keep executing
        {
            Console.Write("\nWhat price are you comfortable paying per 1 tile?\n:$");
            try
            {
                costSingleTile = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException) // if entered value can not be converted into double, show following text
            {
                Console.WriteLine("this input is not supported, try again");
            }
        }

        Console.WriteLine("\nGot it!\nEnter the number corresponding with the room shape:\n" +
            "1. room is shaped like circle\r\n2. suqare or rectangular\r\n3. triangle shape\r\nType number and press enter:");

        while (roomShape < 1 || roomShape > 3)
        {
            try
            {
                roomShape = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("this input is not supported");
            }
        }

        if (roomShape == 1)
        {
            Console.Write("What is Radius:");
            double radius = 0;

            while (radius <= 0)
            {
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported");
                }
            }
            roomArea = Math.PI * radius * radius; //calculating the area
        }
        if (roomShape == 2)
        {
            Console.WriteLine("What is width?");
            double width = 0;
            double length = 0;

            while (width <= 0)
            {
                try
                {
                    width = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported");
                }
            }

            Console.WriteLine("What is length?");

            while (length <= 0)
            {
                try
                {
                    length = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported");
                }
            }
            roomArea = width * length;
        }
        if (roomShape == 3)
        {
            Console.WriteLine("What is triangle base length?");
            double triangleBase = 0;
            double triangleHeight = 0;

            while (triangleBase <= 0)
            {
                try
                {
                    triangleBase = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported");
                }
            }

            Console.WriteLine("What is triangle height length?");

            while (triangleHeight <= 0)
            {
                try
                {
                    triangleHeight = Convert.ToDouble(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("this input is not supported");
                }
            }
            roomArea = 0.5 * (triangleBase * triangleHeight);
        }

        double priceTileAmmount = roomArea * costSingleTile;
        double numberOfTiles = priceTileAmmount / costSingleTile;
        //ammount of tile needed
        //cost for all tile
        //need handy man help? - yes - no(find out total)
        //handy man price
        //handy man can finish all floor in
        //get handyman - yes - show grand total - no (show total for only all tile)
        Console.WriteLine($"\nResult is ready:\n{numberOfTiles.ToString("0")} pieces of tile needed!");
        double laborHours = (roomArea / TILE_PER_HOUR);
        double priceLabourAmmount = laborHours * LABOUR_HOUR_PRICE;
        double grandTotal = priceLabourAmmount + priceTileAmmount;
        char addHandyMan = '0';

        while (true)
        {
            Console.WriteLine($"Would you like to use help of our handyman to finish the project?\ny - see handy man price; n - go to check out with tile");
            addHandyMan = Char.ToUpper(Console.ReadKey().KeyChar);
            if(addHandyMan == 'Y' || addHandyMan == 'N')
            {
                break;
            }
        }
        if (addHandyMan == 'Y')
        {
            Console.Clear();
            Console.WriteLine($"Our handyman can finish {TILE_PER_HOUR.ToString("0.00")} tiles in 1 hour.\n" +
                $"With our best handyman the project will be done in {laborHours.ToString("0")} hours, at the " +
            $"labour price of {LABOUR_HOUR_PRICE.ToString("C2")}hour.\n");

            Console.WriteLine("Check out without handyman - press n\nAdd handyman help and check out - press h");
            addHandyMan = Char.ToUpper(Console.ReadKey().KeyChar);

        


            Console.Write($"Grand total with tile supply and handy man work is {grandTotal.ToString("C2")}");

        }
        if (addHandyMan == 'N')
        {
            Console.Clear();
            Console.WriteLine($"Check out:\nroom shape {roomShape}\nhandy man {addHandyMan}\nprice per 1 tile ${costSingleTile} x {numberOfTiles.ToString("0")}\n" +
            $"Total: ${priceTileAmmount.ToString("0.00")}\nSwipe your card");
            Console.ReadKey();
        }
        Console.ReadKey();
    }
}