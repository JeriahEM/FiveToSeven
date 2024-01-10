namespace FiveToSeven.Services.Six;
public class SixServices : ISixServices
{
    public string oddOrEven(string input)
    {
        bool success = Int32.TryParse(input, out int num);
        if (success)
        {
            if (num % 2 == 0)
            {
                return $"{num} is an even number";
            }
            else
            {
                return $"{num} is an odd number";
            }
        }
        else
        {
            return ($"failed, that was not a number");
        }
    }
}