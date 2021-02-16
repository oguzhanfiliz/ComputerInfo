using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HardwareInfo;
using WindowsDisplayAPI;

namespace ComputerInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
              

                //dataGridView1.DataSource = GetHddInfo();
                // HddSize.Text = HardwareInfo.GetHddInfo().ToString() ;

                DataTable tablo = new DataTable();
                tablo.Columns.Add("ID", typeof(int));
                tablo.Columns.Add("Type", typeof(string));
                tablo.Columns.Add("Properties", typeof(string));
                dataGridView1.DataSource = tablo;
                int indis = 0;
                List<string> result = GetHddInfo();

                foreach (string temp in result)
                {
                    tablo.Rows.Add(indis,"Hdd", temp);
                    indis++;
                    dataGridView1.DataSource = tablo;
                }



                DataTable tablo2 = new DataTable();
                tablo2.Columns.Add("ID", typeof(int));
                tablo2.Columns.Add("Type", typeof(string));
                tablo2.Columns.Add("Properties", typeof(string));
                dataGridView2.DataSource = tablo2;

                int indiss = 0;
                List<string> results = getMonitorCount();

                foreach (string tmp in results)
                {
                    tablo.Rows.Add(indiss,"Monitor", tmp);
                    indiss++;
                    dataGridView2.DataSource = tablo2;
                }
               
                DataTable tablo3 = new DataTable();
                tablo3.Columns.Add("ID", typeof(int));
                tablo3.Columns.Add("Properties", typeof(string));
                dataGridView2.DataSource = tablo3;

                int indisss = 0;
                List<string> resultss = getProgramList();

                foreach (string tmp in resultss)
                {
                    tablo3.Rows.Add(indisss, tmp);
                    indisss++;
                    dataGridView2.DataSource = tablo3;
                }
                //monitorinf.Text = HardwareInfo.getMonitorCount();
                HddSize.Text = HardwareInfo.getGraphicsCard();
                RamSlotNumber.Text = HardwareInfo.GetNoRamSlots();
                RamSizeLabel.Text = HardwareInfo.GetPhysicalMemory();
                MotherboardMaker.Text = HardwareInfo.GetBoardMaker();
                MotherboardSerial.Text = HardwareInfo.GetBoardProductId();
                GpuName.Text = HardwareInfo.getGpuinformation();
                Cpu.Text = HardwareInfo.GetProcessorInformation();
                OperatingSystem.Text = HardwareInfo.GetMemorySpeed();
            }

        }
        //buton grupları
        private void button1_Click(object sender, EventArgs e)
        {


     

        }

   
    }
    public class disk
    {
        public string name { get; set; }
        public string prop { get; set; }
    }
}
