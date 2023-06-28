using System.Text;

namespace ORMShowdown
{
    public class Utils
    {
        public static string CreateProductName()
        {
            Random rand = new Random();
            var sb = new StringBuilder();
            char letter;
            for (int i = 0; i < 15; i++)
            {
                var randValue = rand.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                sb.Append(letter);
            }

            return sb.ToString();
        }
    }
}
