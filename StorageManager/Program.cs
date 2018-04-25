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
        Drive()
        {
            Tracks = new List<Track>();
            Tracks
        }
    }
    public class Sector
    {
        int Size;
        List<Record> Records;
        Sector()
        {
            Records = new List<Record>();
        }
    }
    public class Track
    {
        List<Block> Blocks;
        List<Cluster> Clusters;
        int Size;
        Track()
        {
            Blocks = new List<Block>();
            Clusters = new List<Cluster>();
        }
        Track(string organizaion)
        {
            if (organizaion == "Cluster")
            {
                Clusters = new List<Cluster>();
            }
            if (organizaion == "Block")
            {
                Blocks = new List<Block>();
            }
        }
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
        public static Drive maindrive;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            maindrive = new Drive();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_start());
        }
    }
}
