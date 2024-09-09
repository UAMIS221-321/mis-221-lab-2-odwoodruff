class SHerlinthiaSanwichSHop  //title of this operation
{
    static void Main(string[] args) //function 

    {
//Constants 
        const double COST_OF_SANDWICH = 4.75;
        const double COST_OF_TOPPING = 0.55;
        const double DISCOUNT_AMOUNT = 0.10;
// Input
        Console.Write("Enter the number of sandwiches: ");
        int numberOfSandwiches = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of toppings: ");
        int numberOfToppings = int.Parse(Console.ReadLine());

        Console.Write("Enter the tip (as a decimal, e.g., 5% is 0.05): ");
        double tip = double.Parse(Console.ReadLine());

        // Processing
        double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
        double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
        double baseCost = totalSandwichCost + totalToppingCost;

        // Applying discount
        double discountedCost = baseCost * (1 - DISCOUNT_AMOUNT);

        // Final order cost including tip
        double orderCost = discountedCost + tip;

        // Output
        Console.WriteLine($"The total order cost is: ${orderCost:F2}");
    }




    }













