namespace FiveToSeven.Services.BSeven;
public class BSevenServices : IBSevenServices
{
    public string seven(string userInput)
    {
        int j = 0;
        int reminder = 0;

        bool success = Int32.TryParse(userInput, out int num);
        if (success)
        {
            while (num > 0)
            {

                reminder = num % 10;


                j = (j * 10) + reminder;

                num = num / 10;
            }

            return userInput + " reversed is " + j.ToString();

        }
        else
        {
            return "failed, that was not a number";
        }
    }

}