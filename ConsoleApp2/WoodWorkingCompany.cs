using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class WoodWorkingCompany
    {
        public static string woodName = "Ring-shaped wood";
        public int age { get; set; }
        public float size { get; set; }
        public void Backgammon()
        {
            DateTime thisDay = DateTime.Today;
            string text = thisDay.ToString("d");
            string[] words = text.Split(new char[] { '.' });
            int count = int.Parse(words[0]);
            Console.WriteLine("Hi, today we can made " + count + " backgammon");
        }
        public void Chess()
        {
            DateTime thisDay = DateTime.Today;
            string text = thisDay.ToString("d");
            string[] words = text.Split(new char[] { '.' });
            int count = int.Parse(words[0]);
            Console.WriteLine("Hi, today we can made " + count + " chess");
        }
        public void Shogi()
        {
            DateTime thisDay = DateTime.Today;
            string text = thisDay.ToString("d");
            string[] words = text.Split(new char[] { '.' });
            int count = int.Parse(words[0]);
            Console.WriteLine("Hi, today we can made " + count + " shodi");
        }
    }
}
