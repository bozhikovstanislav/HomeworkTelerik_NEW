namespace _15.Replace_tags
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceTag
    {
        static string ForbidenWord(string text, string[] words,string[] tags)
        {
           
            string aString = string.Empty;
            string textStr = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                
                int index = text.IndexOf(tags[i]);
                int indexOfNext = text.IndexOf(tags[i], index+1);
                if (index != -1)
                {
                   
                        aString = text.Replace(tags[i], words[i]);
                        index = text.IndexOf(tags[i],index+1);
                        text = aString;
                    
                   
                }

            }


            return aString;

        }
        static void Main()
        {
            /*Problem 15. Replace tags
             
             Write a program that replaces in a HTML document given as
             string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
             
             */

            

            string htmlText = @"<p>Please visit <a href="+"http://academy.telerik. com"+">our site</a> to choose a training course. Also visit <a href="+"www.devbg.org"+">our forum</a> to discuss the courses.</p>";



            string [] words=
            {
                "[URL=",
                "[URL]"
                
               
            };
            string[] tags=
            {
                "<a href=",
                
                "</a>"
                
                
            };
            string result=ForbidenWord(htmlText, words, tags);

            int indexClosedHref = result.IndexOf('>');

            
            for (int i = 0; i < result.Length; i++)
            {
                indexClosedHref = result.IndexOf(tags[i], indexClosedHref + 1);
                string tag = htmlText.Substring(2-indexClosedHref,3);
                
                Console.Write(tag);
            }

          

            Console.WriteLine();

        }
    }
}
