using System;
using System.Collections.Generic;
using System.Text;

namespace TickTackToe
{
    class Board
    {

        public string[] PlayFields { get; set; } = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public void createAndUpdateBoard()
        {

                Console.WriteLine("     " + "|" + "     " + "|" + "     ");
                Console.WriteLine("  {0}  " + "|" + "  {1}  " + "|" + "  {2}  ", PlayFields[0], PlayFields[1], PlayFields[2]);
                Console.WriteLine("_____" + "|" + "_____" + "|" + "_____");
                Console.WriteLine("     " + "|" + "     " + "|" + "     ");
                Console.WriteLine("  {0}  " + "|" + "  {1}  " + "|" + "  {2}  ", PlayFields[3], PlayFields[4], PlayFields[5]);
                Console.WriteLine("_____" + "|" + "_____" + "|" + "_____");
                Console.WriteLine("     " + "|" + "     " + "|" + "     ");
                Console.WriteLine("  {0}  " + "|" + "  {1}  " + "|" + "  {2}  ", PlayFields[6], PlayFields[7], PlayFields[8]);
                Console.WriteLine("     " + "|" + "     " + "|" + "     ");

            
        }
    }
}
