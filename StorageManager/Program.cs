using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public class Drive
    {
        List<Track> Tracks;
    }
    public class Sector
    {
        int Size;
        List<Record> Record;
    }
    public class Track
    {
        List<Block> Blocks;
        List<Cluster> Clusters;
        int Size;
    }
    public class Block
    {
        int BlockingFactor;
        List<Record> Records;
        int CountSubblock;
        int KeySubblock;
    }
    public class Cluster
    {
        List<Sector> Sectors;
    }
    public class Record
    {
        int Size;
        List<string> Fields;
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_start());
        }
    }
}
