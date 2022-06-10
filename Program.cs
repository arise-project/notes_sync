using System;
using System.IO;
using notes_sync.Unit;

namespace notes_sync
{
    class Program
    {
        static void Main(string[] args)
        {
        	//PZRK Perun
        	//FH70
        	//Igla
            Console.WriteLine("Notes Sync");
            
            //NYT
        	new RenameFilesUnit().Run(args);
        }
    }
}
