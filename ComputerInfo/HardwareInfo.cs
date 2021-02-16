using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Collections;
using System.Windows.Forms;
using System.Net;
using System.IO;


public static class HardwareInfo
{
    /*   public class disk
       {
           public string name { get; set; }
           public string DriveType { get; set; }
           public string VolumeLabel { get; set; }
           public string DriveFormat { get; set; }
           public string AvailableFreeSpace { get; set; }
           public string TotalFreeSpace { get; set; }
           public string TotalSize { get; set; }


       }
    */


    //get all disk info 
 
    /// Retrieving Processor Id.

    public static String GetProcessorId()
    {

        ManagementClass mc = new ManagementClass("win32_processor");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["processorID"].Value.ToString();
            break;
        }
        return Id;

    }   
    public static List<string> GetHddInfo()
    {

        List<String> result;

        var query2 = new WqlObjectQuery("SELECT * FROM Win32_DiskDrive");
        using (var searcher = new ManagementObjectSearcher(query2))
        {
            result = searcher.Get()
                             .OfType<ManagementObject>()
                             .Select(o => o.Properties["DeviceID"].Value.ToString()
                             + " - " + o.Properties["SerialNumber"].Value.ToString()
                              + " - " + o.Properties["Description"].Value.ToString()
                               //+ " - " + o.Properties["Availability"].Value.ToString()
                               + " - " + o.Properties["Model"].Value.ToString()
                                 + " - " + o.Properties["Size"].Value.ToString()
                                  + " - " + o.Properties["SystemName"].Value.ToString())
                             .ToList();
        }
        return result;
    }
    public static String getGraphicsCard()
    {
        ManagementObjectSearcher graphics = new ManagementObjectSearcher("Select * From Win32_VideoController");
        string temp = "";
        foreach (ManagementObject Mobject in graphics.Get())
        {
             temp =  Mobject["name"].ToString() + " " + Mobject["AdapterRam"].ToString();
        }
        return temp; 
    }  
    public static List<string> getProgramList()
    {
        List<string> program = new List<string>();
        ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
        foreach (ManagementObject mo in mos.Get())
        {
            program.Add(mo["Caption"].ToString());
        }
        return program; 
    } 
    
    
    

    public static List<string> getMonitorCount()
    {
         
        List<string> monitor = new List<string>();
        foreach (var screen in System.Windows.Forms.Screen.AllScreens)
        {
            monitor.Add(screen.DeviceName.ToString() + "-" + screen.Bounds.ToString() + "-" + screen.WorkingArea.ToString() + "-" + screen.Primary.ToString() + "-Ekran Sayısı" + Screen.AllScreens.Length) ;
            
            
        }
        return monitor; 
    }

    public static String getProcessorType()
    {

        ManagementClass mc = new ManagementClass("win32_usbcontroller");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["Status"].Value.ToString();
            break;
        }
        return Id;

    }  

    //ekran kartı gpu
    public static String getGpuinformation()
    {

        ManagementClass mc = new ManagementClass("win32_VideoController");
        ManagementObjectCollection moc = mc.GetInstances();
        String Id = String.Empty;
        foreach (ManagementObject mo in moc)
        {

            Id = mo.Properties["Name"].Value.ToString();
            break;
        }
        return Id;

    }
    ///  
    /// Retrieving HDD Serial No.
    /// hdd seri numarası
    ///  
    ///  
    /// 

    public static String GetHDDSerialNo()
    {
        ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
        ManagementObjectCollection mcol = mangnmt.GetInstances();
        string result = "";
        foreach (ManagementObject strt in mcol)
        {
            result += Convert.ToString(strt["VolumeSerialNumber"]);
        }
        return result;
    }
    public static String GetHddSize()
    {
        long memory=0;
        var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
        string Model, InterfaceType, Caption, SerialNo = "", Capabilities;
        foreach (ManagementObject wmi_HD in searcher.Get())
        {
            //  mCap = Convert.ToInt64(obj["Capacity"]);
            // MemSize += mCap;
            memory = Convert.ToInt64(wmi_HD["size"])/ 1048576;
            Capabilities = wmi_HD["size"].ToString() ;
            Model = wmi_HD["Model"].ToString();
            InterfaceType = wmi_HD["InterfaceType"].ToString();
            Caption = wmi_HD["Caption"].ToString();
            SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString();
           // CapabilitiesInt = Convert.ToInt32(Capabilities) / 1073741824;
            return memory.ToString()+"GB";
         
        }
        return SerialNo;
    }
    ///  
    /// Retrieving System MAC Address.
    ///  
    /// mac adress
    ///  
    public static string GetMACAddress()
    {
        ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
        ManagementObjectCollection moc = mc.GetInstances();
        string MACAddress = String.Empty;
        foreach (ManagementObject mo in moc)
        {
            if (MACAddress == String.Empty)
            {
                if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
            }
            mo.Dispose();
        }

        MACAddress = MACAddress.Replace(":", "");
        return MACAddress;
    }
    ///  
    /// Retrieving Motherboard Manufacturer.
    ///  
    /// Anakart Markası
    ///  
    public static string GetBoardMaker()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return wmi.GetPropertyValue("Manufacturer").ToString();
            }

            catch { }

        }

        return "Board Maker: Unknown";

    }
    ///  
    /// Retrieving Motherboard Product Id.
    /// anakart idsi
    ///  
    ///  
    public static string GetBoardProductId()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return wmi.GetPropertyValue("Product").ToString();

            }

            catch { }

        }

        return "Product: Unknown";

    }
    ///  
    /// Retrieving CD-DVD Drive Path.
    ///  
    /// cd drive sayısı
    ///  
    public static string GetCdRomDrive()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return wmi.GetPropertyValue("Drive").ToString();

            }

            catch { }

        }

        return "CD ROM Drive Letter: Unknown";

    }
    ///  
    /// Retrieving BIOS Maker.
    /// Bios markası
    ///  
    ///  
    public static string GetBIOSmaker()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return wmi.GetPropertyValue("Manufacturer").ToString();

            }

            catch { }

        }

        return "BIOS Maker: Unknown";

    }
    ///  
    /// Retrieving BIOS Serial No.
    ///  
    /// Bios Seri no 
    ///  
    public static string GetBIOSserNo()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return wmi.GetPropertyValue("SerialNumber").ToString();

            }

            catch { }

        }

        return "BIOS Serial Number: Unknown";

    }
    ///  
    /// Retrieving BIOS Caption.
    ///  
    /// Bios Başlığı
    ///  
    public static string GetBIOScaption()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return wmi.GetPropertyValue("Caption").ToString();

            }
            catch { }
        }
        return "BIOS Caption: Unknown";
    }
    ///  
    /// Retrieving System Account Name.
    ///  
    /// Kullanıcı adı
    ///  
    public static string GetAccountName()
    {

        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");

        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {

                return wmi.GetPropertyValue("Name").ToString();
            }
            catch { }
        }
        return "User Account Name: Unknown";

    }
    ///  
    /// Retrieving Physical Ram Memory.
    ///  
    /// Ram Boyutu
    ///  
    public static string GetPhysicalMemory()
    {
        ManagementScope oMs = new ManagementScope();
        ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
        ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
        ManagementObjectCollection oCollection = oSearcher.Get();

        long MemSize = 0;
        long mCap = 0;

        // In case more than one Memory sticks are installed
        foreach (ManagementObject obj in oCollection)
        {
            mCap = Convert.ToInt64(obj["Capacity"]);
            MemSize += mCap;
        }
        MemSize = (MemSize / 1024) / 1024;
        return MemSize.ToString() + "MB";
    }
    ///  
    /// Retrieving No of Ram Slot on Motherboard.
    ///  
    /// Ram Slotu
    ///  
    public static string GetNoRamSlots()
    {

        int MemSlots = 0;
        ManagementScope oMs = new ManagementScope();
        ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
        ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
        ManagementObjectCollection oCollection2 = oSearcher2.Get();
        foreach (ManagementObject obj in oCollection2)
        {
            MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

        }
        return MemSlots.ToString();
    }
    //Get CPU Temprature.
    ///  
    /// method for retrieving the CPU Manufacturer
    /// using the WMI class
    ///

    public static string GetMemorySpeed()
    {
        String dd="";
        var searcher = new ManagementObjectSearcher(
            "select MaxClockSpeed from Win32_Processor");
        foreach (var item in searcher.Get())
        {
            var clockSpeed = (uint)item["MaxClockSpeed"];
            return clockSpeed.ToString();

        }
        return dd;
        /*  ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
          ManagementObjectCollection moc = mc.GetInstances();
          string MemorySpeed = String.Empty;
          foreach (ManagementObject mo in moc)
          {
              MemorySpeed = mo.Properties["MaxClockSpeed"].Value.ToString();
          }

          return MemorySpeed;*/
    }
    public static string GetCPUManufacturer()
    {
        string cpuMan = String.Empty;
        //create an instance of the Managemnet class with the
        //Win32_Processor class
        ManagementClass mgmt = new ManagementClass("Win32_Processor");
        //create a ManagementObjectCollection to loop through
        ManagementObjectCollection objCol = mgmt.GetInstances();
        //start our loop for all processors found
        foreach (ManagementObject obj in objCol)
        {
            if (cpuMan == String.Empty)
            {
                // only return manufacturer from first CPU
                cpuMan = obj.Properties["Manufacturer"].Value.ToString();
            }
        }
        return cpuMan;
    }
    ///  
    /// method to retrieve the CPU's current
    /// clock speed using the WMI class
    ///  
    /// Cpu hızı
    /// 
    public static int GetCPUCurrentClockSpeed()
    {
        int cpuClockSpeed = 0;
        //create an instance of the Managemnet class with the
        //Win32_Processor class
        ManagementClass mgmt = new ManagementClass("Win32_Processor");
        //create a ManagementObjectCollection to loop through
        ManagementObjectCollection objCol = mgmt.GetInstances();
        //start our loop for all processors found
        foreach (ManagementObject obj in objCol)
        {
            if (cpuClockSpeed == 0)
            {
                // only return cpuStatus from first CPU
                cpuClockSpeed = Convert.ToInt32(obj.Properties["CurrentClockSpeed"].Value.ToString());
            }
        }
        //return the status
        return cpuClockSpeed;
    }
    ///  
    /// method to retrieve the network adapters
    /// default IP gateway using WMI
    /// Hatalı düzeltilmesi lazım
    ///  
    /// 
    public static string GetDefaultIPGateway()
    {
        //create out management class object using the
        //Win32_NetworkAdapterConfiguration class to get the attributes
        //of the network adapter
        ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
        //create our ManagementObjectCollection to get the attributes with
        ManagementObjectCollection objCol = mgmt.GetInstances();
        string gateway = String.Empty;
        //loop through all the objects we find
        foreach (ManagementObject obj in objCol)
        {
            if (gateway == String.Empty)  // only return MAC Address from first card
            {
                //grab the value from the first network adapter we find
                //you can change the string to an array and get all
                //network adapters found as well
                //check to see if the adapter's IPEnabled
                //equals true
                if ((bool)obj["IPEnabled"] == true)
                {
                    gateway = obj["DefaultIPGateway"].ToString();
                }
            }
            //dispose of our object
            obj.Dispose();
        }
        //replace the ":" with an empty space, this could also
        //be removed if you wish
        gateway = gateway.Replace(":", "");
        //return the mac address
        return gateway;
    }
    ///  
    /// Retrieve CPU Speed.
    /// Gpu hızı
    ///  
    ///  
    public static double? GetCpuSpeedInGHz()
    {
        double? GHz = null;
        using (ManagementClass mc = new ManagementClass("Win32_Processor"))
        {
            foreach (ManagementObject mo in mc.GetInstances())
            {
                GHz = 0.001 * (UInt32)mo.Properties["CurrentClockSpeed"].Value;
                break;
            }
        }
        return GHz;
    }

    ///  
    /// Retrieving Current Language.
    /// İşletim sistemi bilgisi
    ///  
    ///  
    public static string GetOSInformation()
    {
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
        foreach (ManagementObject wmi in searcher.Get())
        {
            try
            {
                return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["Version"] + ", " + (string)wmi["OSArchitecture"];
            }
            catch { }
        }
        return "BIOS Maker: Unknown";
    }
    ///  
    /// Retrieving Processor Information.
    /// Bütün İşlemci bilgisi
    ///  
    ///  
    public static String GetProcessorInformation()
    {
        ManagementClass mc = new ManagementClass("win32_processor");
        ManagementObjectCollection moc = mc.GetInstances();
        String info = String.Empty;
        foreach (ManagementObject mo in moc)
        {
            string name = (string)mo["Name"];
            name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

            info = name + ", " + (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
            //mo.Properties["Name"].Value.ToString();
            //break;
        }
        return info;
    }
    ///  
    /// Retrieving Computer Name.
    ///  
    ///  
    public static String GetComputerName()
    {
        ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
        ManagementObjectCollection moc = mc.GetInstances();
        String info = String.Empty;
        foreach (ManagementObject mo in moc)
        {
            info = (string)mo["Name"];
            //mo.Properties["Name"].Value.ToString();
            //break;
        }
        return info;
    } 
    //ip bilgileri
  /*  public static String  getIpinfo()
    {
        string host = Dns.GetHostName();
        IPHostEntry ip = Dns.GetHostByName(host);
        return ip.AddressList[0].ToString();
        //birden fazla ip olabilceğinden burada ilk bulunanı alıyoruz.
    }*/

}
