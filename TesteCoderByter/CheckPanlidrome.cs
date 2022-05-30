namespace TesteESSPalindrome
{
    public static class checkpanlidrome
    {
        public static string checkPalindrome(string mainString)
        {
            var stringReverse = new string(mainString.Reverse().ToArray());
            var aux = new List<string>();
            for(var i = 0; i <= (mainString.Length/2); i++)
            {
                var stringCheck = stringReverse.Substring(0, (mainString.Length / 2));
                if (!stringCheck.Contains(mainString[i]))
                {
                    aux.Add(mainString[i].ToString());
                }
            }
            if (aux.Count() > 2)
                return "not possible";

            foreach (var item in aux)
                mainString = mainString.Remove(mainString.IndexOf(item), 1);

            stringReverse = new string(mainString.Reverse().ToArray());
            
            if (stringReverse == mainString)
                return String.Join(", ", aux.ToArray());
            else
                return "not possible";
        }
    }
}
