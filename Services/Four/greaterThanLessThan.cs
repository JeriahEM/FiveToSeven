namespace FiveToSeven.Services.Mini;
public class greaterThanLessThan : IgreaterThanLessThan
{
    public string PullNum1(int num, int num1)
    {
        if (num >= num1)
        {
            return (num + " is greater than or equal to " + num1);
        }
        else
        {
            return (num + " is less than or equal to " + num1);
        }
    }
}
