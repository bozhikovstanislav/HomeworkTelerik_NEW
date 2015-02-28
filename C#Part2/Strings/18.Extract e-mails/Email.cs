
namespace _18.Extract_e_mails
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    class Email
    {

        static void Main()
        {
            /*Problem 18. Extract e-mails
             Write a program for extracting all email addresses from given text.
             All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
             
             */
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
           RegexOptions.IgnoreCase);

            string text = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b. Extracted e-mail ";
            MatchCollection emailMatches = emailRegex.Matches(text);
            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            Console.Write(sb);

        }
    }
}
