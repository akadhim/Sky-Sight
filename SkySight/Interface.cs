using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using System.IO.Ports;
using SlimDX.XInput;

namespace SkySight
{
    public partial class Interface : Form
    {        
        //private SerialPort serialPort = new SerialPort();
        private delegate void UpdateTextBoxHandler(String addMessage);

        public bool _advClickNotice = true;

        //media
        private LiveJob _mediaJob;
        private LiveDeviceSource _mediaDeviceSource;
        //private bool _mediaStartedRecording = false;
        private EncoderDevice video = null;
        private EncoderDevice audio = null;

        public Interface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            advancedToolStripMenuItem.HideDropDown();
            tabControl1.Hide();
            timer1.Interval = 200;
            
            joystickStatus.Text = "Joystick Disabled";
            JoystickProgressBar.Value = 1;

            KeyPreview = true;

            portComboBox.Enabled = false;
            fillComboBoxes(); // fill com-ports, video/audio boxes available
            audioComboBox.Enabled = false;
        }

        private void fillComboBoxes()
        {
            // filol comPorts combo box
            string[] ports = SerialPort.GetPortNames();
            foreach (string str in ports)
            {
                //serialPort = new SerialPort(str);
                if (serialPort.IsOpen == false)
                    portComboBox.Items.Add(str);
            }

            //fill video/audio combo boxes
            foreach (EncoderDevice vDevice in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                videoComboBox.Items.Add(vDevice.Name);
            }

            foreach (EncoderDevice aDevice in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                audioComboBox.Items.Add(aDevice.Name);
            }
        }

        private void baudrateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = int.Parse(baudrateComboBox.Text); //sets baudrate
            baudrateComboBox.Enabled = false;
            portComboBox.Enabled = true;
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = portComboBox.Text;

            try
            {
                //open serial port
                serialPort.Open();
                portComboBox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                portComboBox.Text = "";
            }
        }

        private void updateTextBox(String message)
        {
            textBox1.Text += message;
            textBox1.Text += Environment.NewLine;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string capture = serialPort.ReadLine();
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //string words;

            if (textBox1.InvokeRequired)
                textBox1.Invoke(new UpdateTextBoxHandler(updateTextBox), capture);
            else
               updateTextBox(capture);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GamepadStates g = new GamepadStates(UserIndex.One);

            if (g.Connected)
            {
                joystickStatus.Text = "Joystick Connected";
                JoystickProgressBar.Value = 10;

                System.Threading.Thread.Sleep(10);
                g.Update();

                stickValueRequest(g);
                buttonPushRequests(g);
            }
            else
            {
                joystickStatus.Text = "Joystick Not Connected";
                JoystickProgressBar.Value = 0;
            }
        }

        private void stickValueRequest(GamepadStates gpStick) //gamepad thumb stick
        {
            elevationLabelValue.Text = Convert.ToString(gpStick.LeftStick.Position.Y);
            elevationTrackBar.Value = Convert.ToInt32(gpStick.LeftStick.Position.Y);

            moveXLabelValue.Text = Convert.ToString(gpStick.RightStick.Position.X);
            moveXTrackBar.Value = Convert.ToInt32(gpStick.RightStick.Position.X);

            moveYLabelValue.Text = Convert.ToString(gpStick.RightStick.Position.Y);
            moveYTrackBar.Value = Convert.ToInt32(gpStick.RightStick.Position.Y);
        }

        private void buttonPushRequests(GamepadStates gp) // gampad buttons
        {
            if (gp.X)
            {
                if (radioButton1.Checked)
                    radioButton1.Checked = false;
                else
                    radioButton1.Checked = true;
            }
            if (gp.Y)
            {
                if (radioButton4.Checked)
                    radioButton4.Checked = false;
                else
                    radioButton4.Checked = true;
            }
            if (gp.A)
            {
                if (radioButton2.Checked)
                    radioButton2.Checked = false;
                else
                    radioButton2.Checked = true;
            }
            if (gp.B)
            {
                if (radioButton3.Checked)
                    radioButton3.Checked = false;
                else
                    radioButton3.Checked = true;
            }

            if (gp.LeftShoulder)
            {
                if (radioButton5.Checked)
                    radioButton5.Checked = false;
                else
                    radioButton5.Checked = true;
            }
            if (gp.RightShoulder)
            {
                if (radioButton6.Checked)
                    radioButton6.Checked = false;
                else
                    radioButton6.Checked = true;
            }
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_advClickNotice)
            {
                tabControl1.Hide();
                _advClickNotice = false;
            }
            else
            {
                tabControl1.Show();
                _advClickNotice = true;
            }
        }

        private void activateJoystick_Click(object sender, EventArgs e)
        {
            timer1.Start();
            activateJoystick.Hide();
            tabControl1.Show();
            advancedToolStripMenuItem.ShowDropDown();
        }

        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            // Close serial port (if opened)
            if (serialPort.IsOpen)
            {
                try
                {
                    if (serialPort.IsOpen == true)
                        serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        serialPort.Write("3");
                        break;

                    case Keys.Up:
                        serialPort.Write("2");
                        break;

                    case Keys.T:
                        serialPort.Write("1");
                        break;

                    case Keys.S:
                        serialPort.Write("0");
                        break;

                    default:
                        break;
                }
            }
        }

        private void videoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (EncoderDevice vDevice in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(vDevice.Name, videoComboBox.Text) == 0)
                {
                    video = vDevice;              
                    break;
                }
            }
            videoComboBox.Enabled = false;
            audioComboBox.Enabled = true;
        }

        private void mediaPlay()
        {
            _mediaJob = new LiveJob();
            _mediaDeviceSource = _mediaJob.AddDeviceSource(video, audio);
            _mediaDeviceSource.PickBestVideoFormat(new Size(640, 480), 15);

            _mediaDeviceSource.PreviewWindow = new PreviewWindow(new System.Runtime.InteropServices.HandleRef(videoPanel, videoPanel.Handle));
            _mediaJob.ActivateSource(_mediaDeviceSource);
        }

        private void audioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (EncoderDevice aDevice in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                if (String.Compare(aDevice.Name, audioComboBox.Text) == 0)
                {
                    audio = aDevice;
                    break;
                }
            }
            audioComboBox.Enabled = false;
            mediaPlay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("savedLog.txt", textBox1.Text);
        }
    }
}