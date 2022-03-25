using System;

namespace DistinctCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string str = "hello world";
            Console.WriteLine("string:" + str);
            while(str.Length>0)
            {
                Console.Write(str[0] + "=");

                for(int i=0;i<str.Length;i++)
                {
                    if (str[0] == str[i])
                        num++;

                }
                Console.WriteLine(num);
                str = str.Replace(str[0].ToString(), String.Empty);
            }
            Console.ReadLine();
        }
    }
}
