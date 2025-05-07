using System.Text;

public static class Pangram
{
    public static bool IsPangram(string input)
    {

        if(string.IsNullOrWhiteSpace(input)){
            return false;
        }

        List<char> auxStr = [];
        input = input.ToLower();

        foreach(char ch in input)
        {
            if(char.IsLetter(ch) && !auxStr.Contains(ch)){
                auxStr.Add(ch);          
            }

        }

        return auxStr.Count == 26;

    
    }
}
