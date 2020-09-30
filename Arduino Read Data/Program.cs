using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports; //import library ที่ใช้กับ arduino หรือ usb
namespace Arduino_Read_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort myport = new SerialPort(); //สร้าง SerailPort ให้เครื่องรู้
            myport.BaudRate = 9600; //เชื่อมกับ Port 9600
            myport.PortName = "COM4"; //บอกว่าใช้กับ COM4
            myport.Open(); //เริ่มเปิด Port (สื่อสาร)

            while(true)
            {
                string data_rx = myport.ReadLine(); //สร้างตัวแปรที่อ่านค่าที่ได้รับมา
                Console.WriteLine(data_rx); //เขียนค่าที่อ่านมาได้
            }
        }
    }
}
