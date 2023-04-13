using System;
using System.Collections;

namespace _27.CollectionDemo
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable[0] = "DotNetKorea";
            hashtable["NickName"] = "RedPlus";

            Console.WriteLine(hashtable[0]);
            Console.WriteLine(hashtable["NickName"]);

        }
    }
}
