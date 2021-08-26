using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class Task:ITask
    {
        FileDetails fd = new FileDetails();
        
        public void Task1(string generalizedString, int num)
        {
            try
            {
                if (generalizedString == "-v")
                {
                    Console.WriteLine(fd.Version("C:/test.txt"));
                    //Console.ReadKey();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Task2(string generalizedString, int num)
        {
            try { 
                if (generalizedString == "-v" || generalizedString == "--v" || generalizedString == "/v" || generalizedString == "--version")
                {
                    Console.WriteLine(fd.Version("C:/test.txt"));
                    Console.ReadKey();
                }

                if (generalizedString == "-s" || generalizedString == "--s" || generalizedString == "/s" || generalizedString == "--size")
                {
                    Console.WriteLine(fd.Size("C:/test.txt"));
                    Console.ReadKey();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}
