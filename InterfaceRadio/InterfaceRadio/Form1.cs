using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceRadio
{
    public partial class Form1 : Form
    {
        public SerialPort _portaSerial { get; set; }  
        public string[] valorSensor { get; private set; }  

        long tempo = 0;                 
        String serial;                  
        double valorSensor2;            
        double valorSensor1;            

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)   
        {
            var portas = SerialPort.GetPortNames();  
            foreach (var port in portas)
            {
                comserial.Items.Add(port);
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            _portaSerial = new SerialPort(comserial.Text, 115200); 
            try
            {
                if (!_portaSerial.IsOpen) 
                {
                    _portaSerial.Open(); 

                }

            }
            catch (Exception ex)
            {

            }
            Thread masterthread;
            masterthread = new Thread(runit);
            masterthread.Start();
        }
        void runit()
        {
            while (true)
            {
                try
                {
                    if (_portaSerial.IsOpen == true)
                    {

                        timer1.Enabled = true; 
                        serial = _portaSerial.ReadLine(); 
                        SepararSerial(serial);
                        Console.WriteLine("valor 1 " + valorSensor[0]);
                        Console.WriteLine("valor 2 " + valorSensor[1]);
                        Grafico1.Invoke((MethodInvoker)(() => Grafico1.Series["Sensor1"].Points.AddXY(tempo, valorSensor1)));
                        Grafico2.Invoke((MethodInvoker)(() => Grafico2.Series["Sensor2"].Points.AddXY(tempo, valorSensor2))); 
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e) 
        {
            tempo = timer1.Interval;
        }

        private void stop_Click(object sender, EventArgs e)  
        {
            try
            {
                if (_portaSerial.IsOpen == true)
                {
                    _portaSerial.Close();
                    timer1.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void SepararSerial(string menssagem)  
        {
            valorSensor = menssagem.Split(';'); 
            valorSensor1 = double.Parse(valorSensor[0].Replace('.', ',')); 
            valorSensor2 = double.Parse(valorSensor[1].Replace('.', ','));
        }
    }
}
