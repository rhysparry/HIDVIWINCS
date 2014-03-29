// Delcom C# USB HID Visual Indicator Example
// Dec 16, 2008
// This code show how to control the Delcom USB HID Device.

// Steps to make this project.
// 1 Create your project
// 2 Copy the follow file in the project source directory
//      DelcomHID.cs, DeviceManagement.cs, DeviceManademenedDeclarations.cs
//      FileIODeclarations.cs, Hid.cs, HidDeclarations.cs
// 3 Add the above file to your project. Use add existing in Solution Explorer
// 4 Add the following inside your namespace:
//      DelcomHID Delcom = new DelcomHID();   // declare the Delcom class



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIDIOWINCS;

namespace HIDVIWINCS
{
    using System.Globalization;
    using System.Threading.Tasks;
    using System.Windows.Forms.VisualStyles;
    using BookSleeve;
    using Properties;

    public partial class MainForm : Form
    {

        private DelcomHID Delcom = new DelcomHID();   // declare the Delcom class
        private DelcomHID.HidTxPacketStruct TxCmd;

        private readonly RedisConnection _readSettings;
        private readonly RedisConnection _updateWatcher;
        private RedisSubscriberConnection _updateChannel;

        private DeviceStatus _deviceStatus;

        private readonly LightControlSet _red;
        private readonly LightControlSet _green;
        private readonly LightControlSet _blueYellow;

        Byte LED_GREEN_PIN, LED_RED_PIN, LED_BLUE_PIN;

        public MainForm()
        {
            InitializeComponent();
            _readSettings = new RedisConnection(Settings.Default.RedisHost, Settings.Default.RedisPort);
            _updateWatcher = new RedisConnection(Settings.Default.RedisHost, Settings.Default.RedisPort);
            _red = new LightControlSet(button_RedOn, button_RedOff, button_RedFlash, textBox_RedOnDuty, textBox_RedOffDuty, textBox_RedOffset, textBox_RedPower, button_RedApply);
            _green = new LightControlSet(button_GreenOn, button_GreenOff, button_GreenFlash, textBox_GreenOnDuty, textBox_GreenOffDuty, textBox_GreenOffset, textBox_GreenPower, button_GreenApply);
            _blueYellow = new LightControlSet(button_BlueOn, button_BlueOff, button_BlueFlash, textBox_BlueOnDuty, textBox_BlueOffDuty, textBox_BlueOffset, textBox_BluePower, button_BlueApply);
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            // Current TID and SID are not supported

            if (Delcom.Open() == 0)
            {
                UInt32 FamilyCode, SerialNumber, Version, Date, Month, Year, SecurityNumber, ChipType;
                FamilyCode = SerialNumber = Version = Date = Month = Year = SecurityNumber = ChipType = 0;
                Delcom.GetDeviceInfo(ref FamilyCode, ref SerialNumber, ref Version, ref Date, ref Month, ref Year, ref SecurityNumber, ref ChipType);
                Year += 2000;
                label_DeviceName.Text = "DeviceName: " + Delcom.GetDeviceName();
                label_DeviceStatus.Text = "Device Status: Found. FamilyCode=" + FamilyCode.ToString() + " SerialNumber=" + SerialNumber.ToString() + " Version=" + Version.ToString() + " " + Month.ToString() + "/" + Date.ToString() + "/" + Year.ToString();
                if (SecurityNumber > 0)
                    label_DeviceStatus.Text += " Security Number: " + SecurityNumber.ToString();

                // Del 11-10-2011 - Added test to map LEDs
                if (ChipType == 30 && FamilyCode != 2 && FamilyCode != 3)
                {
                    LED_GREEN_PIN = 0x10;
                    LED_RED_PIN = 0x20;
                    LED_BLUE_PIN = 0x40;
                    // Port0 - All inputs except P0.7 which is the buzzer, Default all high, All Pullups on, All Interrupts Off
                    Delcom.SetupPort(0, 0xFF, 0x7F, 0xFF, 0x00);
                    // Port1 - P1.4-7 Outputs, LED drive pins, Default all high, All Pullups on, All Interrupts Off
                    Delcom.SetupPort(1, 0xFF, 0x0F, 0xFF, 0x00);
                }
                else
                {  // Port1
                    LED_GREEN_PIN = 0x01;
                    LED_RED_PIN = 0x02;
                    LED_BLUE_PIN = 0x04;
                }

                // Optionally -Enable event counter use that auto switch feature work
                TxCmd.MajorCmd = 101;
                TxCmd.MinorCmd = 38;
                TxCmd.LSBData = 1;
                TxCmd.MSBData = 0;
                Delcom.SendCommand(TxCmd);

            }
            else
            {
                label_DeviceName.Text = "DeviceName: offine";
                label_DeviceStatus.Text = "Error: Unable to open device.";
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Delcom.Close();
            label_DeviceName.Text = "DeviceName: offine";
            label_DeviceStatus.Text = "Device Closed.";
        }

        private Boolean IsPresent()
        {
            if (Delcom.IsOpen()) return true;
            MessageBox.Show("Device not openned. Open device first!\r\nCommand canncelled.", "Warning - Device Not Openned!");
            return false;
        }



        private void button_GreenOff_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = LED_GREEN_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = LED_GREEN_PIN;
            Delcom.SendCommand(TxCmd);

        }

        private void button_GreenOn_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = LED_GREEN_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = LED_GREEN_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);
        }

        private void button_GreenFlash_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = LED_GREEN_PIN;
            Delcom.SendCommand(TxCmd);  // enable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = LED_GREEN_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd); // and turn it on

        }


        private void button_RedOff_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = LED_RED_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = LED_RED_PIN;
            Delcom.SendCommand(TxCmd);

        }

        private void button_RedOn_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = LED_RED_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = LED_RED_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);
        }

        private void button_RedFlash_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = LED_RED_PIN;
            Delcom.SendCommand(TxCmd);  // enable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = LED_RED_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd); // and turn it on

        }


        private void button_BlueOff_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = LED_BLUE_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = LED_BLUE_PIN;
            Delcom.SendCommand(TxCmd);

        }

        private void button_BlueOn_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = LED_BLUE_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = LED_BLUE_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd);
        }

        private void button_BlueFlash_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 20;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = LED_BLUE_PIN;
            Delcom.SendCommand(TxCmd);  // enable the flash mode 

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 12;
            TxCmd.LSBData = LED_BLUE_PIN;
            TxCmd.MSBData = 0;
            Delcom.SendCommand(TxCmd); // and turn it on

        }

        private void button_GreenApply_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            Byte OffDuty, OnDuty, Offset, Power;
            try
            {
                OffDuty = Convert.ToByte(textBox_GreenOffDuty.Text);
                OnDuty = Convert.ToByte(textBox_GreenOnDuty.Text);
                Offset = Convert.ToByte(textBox_GreenOffset.Text);
                Power = Convert.ToByte(textBox_GreenPower.Text);
                if (Power > 100) { Power = 0; Power /= Power; } // force the catch by divide by zero
            }
            catch (Exception ex)
            {
                MessageBox.Show("LED Paramters out of range!\r\nDuty 0-255\r\nOffet 0-255.\r\nPower 0-100", "Warning - Range Error!");
                return; //exit
            }

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 21;
            TxCmd.LSBData = OffDuty;
            TxCmd.MSBData = OnDuty;
            Delcom.SendCommand(TxCmd); // Load the duty cycle

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 26;
            TxCmd.LSBData = Offset;
            Delcom.SendCommand(TxCmd); // Load the offset

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 34;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = Power;
            Delcom.SendCommand(TxCmd); // Load the offset
        }


        private void button_RedApply_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            Byte OffDuty, OnDuty, Offset, Power;
            try
            {
                OffDuty = Convert.ToByte(textBox_RedOffDuty.Text);
                OnDuty = Convert.ToByte(textBox_RedOnDuty.Text);
                Offset = Convert.ToByte(textBox_RedOffset.Text);
                Power = Convert.ToByte(textBox_RedPower.Text);
                if (Power > 100) { Power = 0; Power /= Power; } // force the catch by divide by zero
            }
            catch (Exception ex)
            {
                MessageBox.Show("LED Paramters out of range!\r\nDuty 0-255\r\nOffet 0-255.\r\nPower 0-100", "Warning - Range Error!");
                return; //exit
            }

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 22;
            TxCmd.LSBData = OffDuty;
            TxCmd.MSBData = OnDuty;
            Delcom.SendCommand(TxCmd); // Load the duty cycle

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 27;
            TxCmd.LSBData = Offset;
            Delcom.SendCommand(TxCmd); // Load the offset

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 34;
            TxCmd.LSBData = 1;
            TxCmd.MSBData = Power;
            Delcom.SendCommand(TxCmd); // Load the offset

        }


        private void button_BlueApply_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            Byte OffDuty, OnDuty, Offset, Power;
            try
            {
                OffDuty = Convert.ToByte(textBox_BlueOffDuty.Text);
                OnDuty = Convert.ToByte(textBox_BlueOnDuty.Text);
                Offset = Convert.ToByte(textBox_BlueOffset.Text);
                Power = Convert.ToByte(textBox_BluePower.Text);
                if (Power > 100) { Power = 0; Power /= Power; } // force the catch by divide by zero
            }
            catch (Exception ex)
            {
                MessageBox.Show("LED Paramters out of range!\r\nDuty 0-255\r\nOffet 0-255.\r\nPower 0-100", "Warning - Range Error!");
                return; //exit
            }

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 23;
            TxCmd.LSBData = OffDuty;
            TxCmd.MSBData = OnDuty;
            Delcom.SendCommand(TxCmd); // Load the duty cycle

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 28;
            TxCmd.LSBData = Offset;
            Delcom.SendCommand(TxCmd); // Load the offset

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 34;
            TxCmd.LSBData = 2;
            TxCmd.MSBData = Power;
            Delcom.SendCommand(TxCmd); // Load the offset


        }


        private void button_Sync_Click(object sender, EventArgs e)
        {

            if (!IsPresent()) return;
            Byte GreenOffset, RedOffset, BlueOffset;
            try
            {
                GreenOffset = Convert.ToByte(textBox_GreenOffset.Text);
                RedOffset = Convert.ToByte(textBox_RedOffset.Text);
                BlueOffset = Convert.ToByte(textBox_BlueOffset.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LED Paramters out of range!\r\nDuty 0-255\r\nOffet 0-255.\r\nPower 0-100", "Warning - Range Error!");
                return; //exit
            }

            // Alwasy reload the offset, as it is clear each time
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 26;
            TxCmd.LSBData = GreenOffset;
            Delcom.SendCommand(TxCmd); // Load the offset

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 27;
            TxCmd.LSBData = RedOffset;
            Delcom.SendCommand(TxCmd); // Load the offset

            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 28;
            TxCmd.LSBData = BlueOffset;
            Delcom.SendCommand(TxCmd); // Load the offset


            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 25;
            TxCmd.LSBData = Convert.ToByte(LED_GREEN_PIN | LED_RED_PIN | LED_BLUE_PIN);      // Sync Green, red & blue
            TxCmd.MSBData = 0;      // 0=off. 1=on - all on
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 
        }

        private void button_Prescaler_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            Byte Prescaler;
            try
            {
                Prescaler = Convert.ToByte(textBox_PreScaler.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prescaler out of range!\r\nPrescaler range 0-255\r\nUnits are in ms.\r\nDefault is 10ms", "Warning - Range Error!");
                return; //exit
            }

            // Alwasy reload the offset, as it is clear each time
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 19;
            TxCmd.LSBData = Prescaler;
            Delcom.SendCommand(TxCmd); // Load the offset

        }

        private void button_UpdateSwitch_Click(object sender, EventArgs e)
        {
            uint Port0 = 0;
            if (!IsPresent()) return;
            Delcom.ReadPort0(ref Port0);
            if ((Port0 & 0x1) == 0x01) checkBox_Switch.Checked = false;
            else checkBox_Switch.Checked = true;

        }

        private void checkBox_SwitchAudiConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 72;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = 0;

            if (checkBox_SwitchAudiConfirm.Checked) TxCmd.MSBData = 0x80;
            else TxCmd.LSBData = 0x80;
            Delcom.SendCommand(TxCmd);
        }

        private void checkBox_SwitchAutoClear_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 72;
            TxCmd.LSBData = 0;
            TxCmd.MSBData = 0;

            if (checkBox_SwitchAutoClear.Checked) TxCmd.MSBData = 0x40;
            else TxCmd.LSBData = 0x40;
            Delcom.SendCommand(TxCmd);
        }


        private void button_BuzzerStart_Click(object sender, EventArgs e)
        {

            if (!IsPresent()) return;
            Byte Freq, Repeat, OnTime, OffTime;
            try
            {
                Freq = Convert.ToByte(textBox_BuzzerFreq.Text);
                Repeat = Convert.ToByte(textBox_BuzzerRepeat.Text);
                OnTime = Convert.ToByte(textBox_BuzzerOnTime.Text);
                OffTime = Convert.ToByte(textBox_BuzzerOffTime.Text);
                if (Freq == 0) { Freq /= Freq; } // force the catch by divide by zero
            }
            catch (Exception ex)
            {
                MessageBox.Show("Buzzer Paramters out of range!\r\nFreq 1-255 Value=1/(FreqHz*256E-6)\r\nRepeat 0-255 0=Continous, 255= Repeat forever.\r\nOnTime 0-100 Units ms.\r\nOffTime 0-100 Units ms.", "Warning - Range Error!");
                return; //exit
            }



            TxCmd.MajorCmd = 102;
            TxCmd.MinorCmd = 70;
            TxCmd.LSBData = 1;          // Enable buzzer
            TxCmd.MSBData = Freq;       // =1/(freqHz*256us)
            TxCmd.ExtData0 = Repeat;    // repeat value
            TxCmd.ExtData1 = OnTime;    // On time
            TxCmd.ExtData2 = OffTime;   // Off time

            Delcom.SendCommand(TxCmd);  // always disable the flash mode 

        }

        private void button_BuzzerStop_Click(object sender, EventArgs e)
        {
            if (!IsPresent()) return;
            TxCmd.MajorCmd = 101;
            TxCmd.MinorCmd = 70;
            TxCmd.LSBData = 0;      // 0=off. 1=on
            Delcom.SendCommand(TxCmd);  // always disable the flash mode 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Delay(500).ContinueWith(t =>
            {
                _readSettings.Open();
                _updateWatcher.Open();
                button_Open.Invoke((Action)button_Open.PerformClick);
                UpdateDeviceStatus();
                _updateChannel = _updateWatcher.GetOpenSubscriberChannel();
                _updateChannel.Subscribe(Settings.Default.UpdateChannel, (m, b) => UpdateDeviceStatus());
            });
        }

        private void UpdateDeviceStatus()
        {
            if (_deviceStatus == null)
            {
                _deviceStatus = ReadFormStatus();
            }

            var updatedStatus = ReadDeviceStatus();

            if (_deviceStatus == updatedStatus) return;

            if (updatedStatus.Red != _deviceStatus.Red)
            {
                UpdateLightStatus(_red, updatedStatus.Red, _deviceStatus.Red);
            }

            if (updatedStatus.Green != _deviceStatus.Green)
            {
                UpdateLightStatus(_green, updatedStatus.Green, _deviceStatus.Green);
            }

            if (updatedStatus.BlueYellow != _deviceStatus.BlueYellow)
            {
                UpdateLightStatus(_blueYellow, updatedStatus.BlueYellow, _deviceStatus.BlueYellow);
            }

            _deviceStatus = updatedStatus;
        }

        private DeviceStatus ReadFormStatus()
        {
            return new DeviceStatus
            {
                Red = ReadFormLightStatus(_red),
                Green = ReadFormLightStatus(_green),
                BlueYellow = ReadFormLightStatus(_blueYellow)
            };
        }

        private LightStatus ReadFormLightStatus(LightControlSet controls)
        {
            return new LightStatus
            {
                State = controls.GetState(),
                Power = int.Parse(controls.PowerValue.Text.EmptyOrNullAs("0")),
                OffDuty = int.Parse(controls.OffDutyValue.Text.EmptyOrNullAs("0")),
                OnDuty = int.Parse(controls.OnDutyValue.Text.EmptyOrNullAs("0")),
                Offset = int.Parse(controls.OffsetValue.Text.EmptyOrNullAs("0"))
            };
        }

        private static void UpdateLightStatus(LightControlSet controls, LightStatus updatedStatus, LightStatus previousStatus)
        {
            if (previousStatus.State != updatedStatus.State)
            {
                controls.SetState(updatedStatus.State);
            }

            var change = false;
            if (previousStatus.OffDuty != updatedStatus.OffDuty)
            {
                controls.OffDutyValue.Invoke((Action)(() =>
                {
                    controls.OffDutyValue.Text = updatedStatus.OffDuty.ToString(CultureInfo.InvariantCulture);
                }));
                change = true;
            }

            if (previousStatus.OnDuty != updatedStatus.OnDuty)
            {
                controls.OffDutyValue.Invoke((Action)(() =>
                {
                    controls.OnDutyValue.Text = updatedStatus.OnDuty.ToString(CultureInfo.InvariantCulture);
                }));
                change = true;
            }

            if (previousStatus.Offset != updatedStatus.Offset)
            {
                controls.OffDutyValue.Invoke((Action)(() =>
                {
                    controls.OffsetValue.Text = updatedStatus.Offset.ToString(CultureInfo.InvariantCulture);
                }));
                change = true;
            }

            if (previousStatus.Power != updatedStatus.Power)
            {
                controls.OffDutyValue.Invoke((Action)(() =>
                {
                    controls.PowerValue.Text = updatedStatus.Power.ToString(CultureInfo.InvariantCulture);
                }));
                change = true;
            }

            if (change)
            {
                controls.OffDutyValue.Invoke((Action)(controls.ApplyButton.PerformClick));
            }
        }

        private DeviceStatus ReadDeviceStatus()
        {
            return new DeviceStatus
            {
                Red = ReadLightStatus("red"),
                Green = ReadLightStatus("green"),
                BlueYellow = ReadLightStatus("blueyellow")
            };
        }

        private LightStatus ReadLightStatus(string color)
        {
            var db = Settings.Default.Database;
            var hash = _readSettings.Wait(_readSettings.Hashes.GetAll(db, color));
            if (hash.Count == 0)
            {
                var defaultStatus = new LightStatus
                {
                    State = LightState.Off,
                    OffDuty = 50,
                    OnDuty = 50,
                    Offset = 0,
                    Power = 80
                };

                WriteLightStatus(color, defaultStatus);
                return defaultStatus;
            }

            var ls = new LightStatus
            {
                State = (LightState)hash["state"][0],
                OffDuty = hash["offduty"][0],
                OnDuty = hash["onduty"][0],
                Offset = hash["offset"][0],
                Power = hash["power"][0]
            };

            return ls;
        }

        private void WriteLightStatus(string color, LightStatus ls)
        {
            var hash = new Dictionary<string, byte[]>
            {
                {"state", new[] {(byte) ls.State}},
                {"offduty", new[] {(byte) ls.OffDuty}},
                {"onduty", new[] {(byte) ls.OnDuty}},
                {"offset", new [] {(byte)ls.Offset}},
                {"power", new[] {(byte) ls.Power}}
            };
            _readSettings.Hashes.Set(Settings.Default.Database, color, hash);
        }

        private void MainForm_Close(object sender, FormClosedEventArgs e)
        {
            if (_updateChannel != null)
            {
                _updateChannel.Dispose();
            }

            _updateWatcher.Dispose();
            _readSettings.Dispose();
        }
    }
}