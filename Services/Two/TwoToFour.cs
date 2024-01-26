namespace FiveToSeven.Services.Mini;
public class TwoToFour : ITwoToFour
{
    public string PullNum(int num, int num1)
    {
        return $"The sum of {num} and {num1} is {num + num1}";
    }
}