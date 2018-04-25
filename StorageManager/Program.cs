using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public class Drive
    {
        public List<Track> Tracks;
        public Drive()
        {
            Tracks = new List<Track>();
        }
    }
    public class Sector
    {
        public static int Size;
        public List<Record> Records;
        public Sector()
        {
            Records = new List<Record>();
        }
    }
    public class Track
    {
        public List<Block> Blocks;
        public List<Cluster> Clusters;
        public static int Size;
        public Track()
        {
            Blocks = new List<Block>();
            Clusters = new List<Cluster>();
        }
        public Track(string organizaion)
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
        public static int BlockingFactor;
        public List<Record> Records;
        public int CountSubblock;
        public int KeySubblock;
    }
    public class Cluster
    {
        public static int NumOfSectors;
        public List<Sector> Sectors;
        public Cluster()
        {
            Sectors = new List<Sector>();
        }
    }
    public class Record
    {
        public static int Size;
        public List<string> Fields;
        public Record()
        {
            Fields = new List<string>();
        }
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
