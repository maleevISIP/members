using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace members
{
    class mem
    {
        public int idNumber;
        private string sname;
        public string name;
        private string othestvo;
        internal long cNumber;
        internal int cTalk;
        internal int inCTalk;
    }
    class Program
    {
        static void Main(string[] args)
        {
            
                mem memOne = new mem();

                memOne.idNumber = Convert.ToInt32(Console.ReadLine());
                memOne.name = Console.ReadLine();

                Console.WriteLine(memOne.idNumber + " " + memOne.name);
                Console.ReadKey();
            }
        }
    }

