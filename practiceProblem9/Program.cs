using System;

class Program
{
    static void Main()
    {
        // Accept integer input for water temperature
        int temperature = int.Parse(Console.ReadLine());

        // Declare variables for water state and safety comment
        string waterState = "";
        string safetyComment = "";

        // Use switch statement for determining water state and safety comment
        switch (temperature)
        {
            case int t when (t < 33):
                waterState = "Frozen";
                safetyComment = "Watch out for ice!";
                break;
            case int t when (t >= 33 && t <= 80):
                waterState = "Cold";
                break;
            case int t when (t >= 80 && t <= 115):
                waterState = "Warm";
                break;
            case int t when (t >= 115 && t <= 211):
                waterState = "Hot";
                break;
            default: // temperature >= 212
                waterState = "Boiling";
                safetyComment = "Caution: Hot!";
                break;
        }

        // Output the results
        Console.WriteLine(waterState);
        if (!string.IsNullOrEmpty(safetyComment))
        {
            Console.WriteLine(safetyComment);
        }
    }
}
// or if else statements can be used
/*using System;

class Program
{
    static void Main()
    {
        // Accept integer input for water temperature
        int temperature = int.Parse(Console.ReadLine());

        // Declare variables for water state and safety comment
        string waterState = "";
        string safetyComment = "";

        // Determine the water state and safety comment
        if (temperature < 33)
        {
            waterState = "Frozen";
            safetyComment = "Watch out for ice!";
        }
        else if (temperature >= 33 && temperature <= 80)
        {
            waterState = "Cold";
        }
        else if (temperature >= 80 && temperature <= 115)
        {
            waterState = "Warm";
        }
        else if (temperature >= 115 && temperature <= 211)
        {
            waterState = "Hot";
        }
        else // temperature >= 212
        {
            waterState = "Boiling";
            safetyComment = "Caution: Hot!";
        }

        // Output the results
        Console.WriteLine(waterState);
        if (!string.IsNullOrEmpty(safetyComment))
        {
            Console.WriteLine(safetyComment);
        }
    }
}*/
