namespace CracklePop
{
    public class CracklePopHelper
    {
        public static string GetNumberOrReplacement(int i)
        {
            string output = i.ToString();

            if (i % 15 == 0)
            {
                output = "CracklePop";
            }
            else if (i % 3 == 0)
            {
                output = "Crackle";
            }
            else if (i % 5 == 0)
            {
                output = "Pop";
            }

            return output;
        }
    }
}