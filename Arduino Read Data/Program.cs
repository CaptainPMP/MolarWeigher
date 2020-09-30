using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Arduino_Read_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM4";
            myport.Open();

            while(true)
            {
                string data_rx = myport.ReadLine();
                Console.WriteLine(data_rx);
            }
        }
    }
}
