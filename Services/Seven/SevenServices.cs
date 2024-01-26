namespace FiveToSeven.Services.Seven;
public class SevenServices : ISevenServices
{
    public string heptagon(string userInput)
    {
        string reversed = "";

        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversed += userInput[i];
        }
        return userInput + " reversed is " + reversed;
    }
}