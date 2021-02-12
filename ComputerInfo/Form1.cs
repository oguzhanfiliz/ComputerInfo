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
              

            }

        }
        //buton grupları
        private void button1_Click(object sender, EventArgs e)
        {


            //dataGridView1.DataSource = GetHddInfo();
            // HddSize.Text = HardwareInfo.GetHddInfo().ToString() ;
         
            DataTable tablo = new DataTable();
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("Properties", typeof(string));
            dataGridView1.DataSource = tablo;
            int indis = 0;
            List<string>result = GetHddInfo(); 
            foreach (string temp in result)
            {
                Console.WriteLine(temp);
                tablo.Rows.Add(indis,temp);
                indis++;
                dataGridView1.DataSource = tablo;
            }
            RamSlotNumber.Text = HardwareInfo.GetNoRamSlots();
            RamSizeLabel.Text = HardwareInfo.GetPhysicalMemory();
            MotherboardMaker.Text = HardwareInfo.GetBoardMaker();
            MotherboardSerial.Text = HardwareInfo.GetBoardProductId();
            GpuName.Text = HardwareInfo.getGpuinformation();
            Cpu.Text = HardwareInfo.GetProcessorInformation();
            OperatingSystem.Text = HardwareInfo.GetMemorySpeed();

        }

   
    }
    public class disk
    {
        public string name { get; set; }
        public string prop { get; set; }
    }
}
