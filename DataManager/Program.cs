using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamEnzoRocheS00295665;// the program can't see this but this is add in dependency

namespace DataManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClubData db = new ClubData();
            using (db) 
            {
                Member m1 = new Member() { MemberId = 1, FirstName = "" };
            
            }
        }
    }
}
