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
           
                
                //int index = text.IndexOf(tags[0]);
                //int indexOfEndUrl = text.IndexOf(tags[2]);
                //if (index != -1)
                //{

                        aString = text.Replace(tags[0], words[0]).Replace(tags[2],words[2]).Replace(tags[1],words[1]);
                        
                        text = aString;
                    
               // }

            


            return aString;

        }




        static void Main()
        {
            /*Problem 15. Replace tags
             
             Write a program that replaces in a HTML document given as
             string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
             
             */

            

            string htmlText = @"<p>Please visit <a href="+"http://academy.telerik. com\""+">our site</a> to choose a training course. Also visit <a href=\""+"www.devbg.org\""+">our forum</a> to discuss the courses.</p>";

            

            string [] words=
            {
                "[URL=",
                "]",
                "[URL]"
                
               
            };
            string[] tags=
            {
                "<a href=",
                "\">",
                "</a>"
                
                
            };
            string result=ForbidenWord(htmlText, words, tags);
            Console.Write(result);
            Console.WriteLine();

        }
    }
}
