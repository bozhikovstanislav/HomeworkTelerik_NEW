namespace _05.Parse_tags
{
    using System;
    using System.Collections.Generic;
    class ParseTags
    {
        static List<int> UpdateTages(string text,string tag)
        {
            List<int> indexesList = new List<int>();
            int index = text.IndexOf(tag);
            while (index != -1)
            {

                indexesList.Add(index);

                index = text.IndexOf(tag, index + 1);
            }
            return indexesList;
        }

        static string uperCase(string text, string tagOpen, string tagClosed)
        {
            int indexOpenTag = text.IndexOf(tagOpen);
            int indexClosedTag = text.IndexOf(tagClosed);

         
            string subStringTemp = string.Empty;
            string resultOf = string.Empty;
            List<int> openTagIndexList = new List<int>();
            List<int> CloseTagIndexList = new List<int>();
          
            while (indexClosedTag!=-1)
            {
                openTagIndexList.Add(indexOpenTag);
                CloseTagIndexList.Add(indexClosedTag);
                indexOpenTag = text.IndexOf(tagOpen, indexOpenTag+1);
                indexClosedTag = text.IndexOf(tagClosed, indexClosedTag+1);
            }
            string nextString = string.Empty;
            for (int i = 0; i < openTagIndexList.Count; i++)
            {
                for (int k =i; k < CloseTagIndexList.Count; k++)
                {
                    //if(k%2!=0)
                    //{
                    //    continue;
                    //}
                   if (i % 2 != 0)
                    {
                        subStringTemp = text.Substring(openTagIndexList[i] + tagOpen.Length, CloseTagIndexList[k] - openTagIndexList[i] - tagOpen.Length).ToUpper();
                    }
                    else  if(i%2==0)
                    {
                        subStringTemp = text.Substring(openTagIndexList[i] + tagOpen.Length, CloseTagIndexList[k] - openTagIndexList[i] - tagOpen.Length).ToUpper();
                    }
                    resultOf = text.Replace(subStringTemp.ToLower(), subStringTemp);
                    nextString = resultOf;
                    text = resultOf;
                }
               
            }


            return resultOf.Replace(tagOpen,string.Empty).Replace(tagClosed,string.Empty);
        }


        static void Main()
        {
            /*Problem 5. Parse tags
             You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
             The tags cannot be nested.
             */


            string text = @" We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";


            Console.WriteLine(uperCase(text, "<upcase>", "</upcase>"));


        }
    }
}
