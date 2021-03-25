namespace WorkingWithText
{
    public class StringUtility
    {
        public static string Summarize(string text, int length = 20)
        {
            string[] words = text.Split(' ');
            var summary = "";
            foreach (var word in words)
            {
                if (summary.Length >= length)
                {
                    break;
                }
                summary += word + " ";
            }
            return summary.Trim() + "...";
        }
    }
}
