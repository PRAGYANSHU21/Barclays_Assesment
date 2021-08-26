using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    


    public static class Program
    {
        public static void Main(string[] args)
        {
            Task t = new Task();
            t.Task1("-v", 10);
            t.Task2("-s", 20);
        }
    }
}
