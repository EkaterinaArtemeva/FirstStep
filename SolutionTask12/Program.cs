Console.WriteLine();

string? inputLineOne = Console.ReadLine();

string reminderSearcher(string? str)
{
    if(str != null)
    {
        try
        {
            string answer;
            int number = int.Parse(str);
            if (((number % 7) == 0) && ((number % 23) == 0))
            {
                answer = "yes for 7 and 23";
            }
            else
            {
                answer = "no for 7 and 23";
            }
            return answer;
            
        }
        catch(Exception e)
        {
            return "исключение: " + e.Message;
        }
    }
    return "";
}

Console.WriteLine(reminderSearcher(inputLineOne));
