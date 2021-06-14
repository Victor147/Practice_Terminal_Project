using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable IDE0017 // Simplify object initialization
#pragma warning disable CS0168 // Variable is declared but never used

namespace Practice_Terminal_Project
{
  public partial class Form1 : Form
  {
    SerialPort serialPort = new SerialPort();

    public Form1()
    {
      InitializeComponent();

      List<string> ports = new List<string>(SerialPort.GetPortNames());
      List<string> bauds = new List<string>(new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });

      cbCOM.DataSource = ports;
      cbBaud.DataSource = bauds;

      serialPort.DataReceived += SerialPort_DataReceived;
    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string indata = serialPort.ReadExisting();
      TerminalUpdate(indata);
    }

    private void TerminalUpdate(string data)
    {
      if (txtHistory.InvokeRequired)
      {
        txtHistory.Invoke(new Action(() =>
        {
          txtHistory.Text += data;
          txtHistory.SelectionStart = txtHistory.Text.Length;
          txtHistory.ScrollToCaret();
        }));
      }
      else
      {
        txtHistory.Text += data;
        txtHistory.SelectionStart = txtHistory.Text.Length;
        txtHistory.ScrollToCaret();
      }

    }

    private void btnSet_Click(object sender, EventArgs e)
    {
      try
      {
        if (!serialPort.IsOpen)
        {
          picPortIndicator.BackColor = Color.Lime;
          serialPort.PortName = cbCOM.Text;
          serialPort.BaudRate = int.Parse(cbBaud.Text);
          serialPort.Parity = Parity.None;
          serialPort.StopBits = StopBits.One;
          serialPort.DataBits = 8;
          serialPort.Encoding = Encoding.GetEncoding("iso-8859-1");
          serialPort.RtsEnable = true;
          serialPort.Open();
          btnSet.Text = "Disconnect";
        }
        else
        {
          btnSet.Text = "Connect";
          picPortIndicator.BackColor = Color.Red;
          serialPort.Close();
        }
      }
      catch { }
    }

    private void SendCommand(string cmd)
    {
      serialPort.Write(cmd + "\r");
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      SendCommand(txtChatText.Text);

      txtHistory.Text += txtChatText.Text + Environment.NewLine;
      txtHistory.SelectionStart = txtHistory.Text.Length;
      txtHistory.ScrollToCaret();


      txtChatText.Text = string.Empty;
      txtChatText.Focus();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      serialPort.Close();
    }

    private void txtChatText_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnSend.PerformClick();
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      if (serialPort.IsOpen)
      {

        picPortIndicator.BackColor = Color.Lime;
      }
      else
      {

        picPortIndicator.BackColor = Color.Red;
      }
    }
  }
}