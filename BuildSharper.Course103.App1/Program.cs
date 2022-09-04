using BuildSharper.Course103.App1.Models;

#region Build list of items

var item1 = new Item()
{
    Description = "Sword",
    Price = 3.25
};

var item2 = new Item()
{
    Description = "Shield",
    Price = 2.75
};

var item3 = new Item()
{
    Description = "Armor",
    Price = 9.05
};

var item4 = new Item()
{
    Description = "Potion",
    Price = 6.45
};

var item5 = new Item()
{
    Description = "Candle",
    Price = 1.75
};

#endregion

//let's give the user a starting balance in their wallet
var wallet = 25.75;

//use a variable to track when the user is done, so we can break out of the while loop
var done = false;

while (!done)
{
    //clear the screen and display the menu
    Console.Clear();
    Console.WriteLine($"Your balance is {wallet.ToString("$0.00")}. Buy somethin' will ya!");
    Console.WriteLine($"1.) {item1.Description}\t\t\t{item1.Price.ToString("$0.00")}");
    Console.WriteLine($"2.) {item2.Description}\t\t\t{item2.Price.ToString("$0.00")}");
    Console.WriteLine($"3.) {item3.Description}\t\t\t{item3.Price.ToString("$0.00")}");
    Console.WriteLine($"4.) {item4.Description}\t\t\t{item4.Price.ToString("$0.00")}");
    Console.WriteLine($"5.) {item5.Description}\t\t\t{item5.Price.ToString("$0.00")}");
    Console.WriteLine($"6.) Exit");

    //capture the user's input
    var input = Console.ReadLine();

    //let's make sure they entered an integer
    if (int.TryParse(input, out var selection))
    {
        //perform a switch on the user's selection
        switch (selection)
        {
            case 1:
                wallet = PurchaseItem(wallet, item1);
                break;
            case 2:
                wallet = PurchaseItem(wallet, item2);
                break;
            case 3:
                wallet = PurchaseItem(wallet, item3);
                break;
            case 4:
                wallet = PurchaseItem(wallet, item4);
                break;
            case 5:
                wallet = PurchaseItem(wallet, item5);
                break;
            case 6:
                //they entered 6, so let's bail
                done = true;
                Console.WriteLine("Bye bye!");
                break;
            default:
                //they entered a number other than 1-6, so display an error message
                Console.WriteLine("Invalid selection, please try again.");
                break;
        }

        //wait for the user's input, giving them a chance to read the message
        Console.ReadLine();
    }
    else
    {
        //the user didn't enter an integer, display an error message
        Console.WriteLine("Invalid selection, please try again.");
        Console.ReadLine();
    }
}

//instead of repeating this code for each item, we're using a function that can be called multiple times
static double PurchaseItem(double walletBalance, Item item)
{
    //ensure that the user can afford this item
    if (walletBalance >= item.Price)
    {
        //deduct from their wallet
        walletBalance -= item.Price;
        Console.WriteLine($"Thanks!  That'll be {item.Price.ToString("$0.00")}.  Enjoy your new {item.Description}.");
    }
    else
    {
        //nope, they can't afford it.
        Console.WriteLine($"I'm sorry, you don't have enough money for the {item.Description}.");
    }

    //return the resulting walletBalance
    return walletBalance;
}