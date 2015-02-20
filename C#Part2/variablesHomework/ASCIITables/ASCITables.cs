using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITables
{
    class ASCITables
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            //byte[] b=new byte[]{};
            //for (int i = 0; i <=255; i++)
            //{
            //   //Console.WriteLine("{0} = {1}", i,Convert.ToChar(i));
            //    char c = (char)i;
            //    string s1 = new string(c, 1);
            //    b= Encoding.ASCII.GetBytes(s1);
            //}
            //foreach (var item in b)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //char charData = (char)0x20AC;
            // 98 is the ascii value for b
            string e = "";
            int count=0;
            do
            {
                //e = Encoding.ASCII.GetString(new byte[] { (byte)count });
                //Някой от символите не се изобразяват правилно на конзолата.
                e = Encoding.Default.GetString(new byte[] { (byte)count });
                Console.Write(e);
                count++;
            } while (count != 255);
            // This will display c
          
         
            Console.ReadLine();
        }
    }
}
