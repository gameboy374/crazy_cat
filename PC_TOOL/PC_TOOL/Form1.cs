using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using SharpGL;

namespace PC_TOOL
{
    public partial class DrawMapTool : Form
    {
        public enum anchor_enum
        {
            ANCHOR1_X,
            ANCHOR1_Y,
            ANCHOR1_Z,
            ANCHOR2_X,
            ANCHOR2_Y,
            ANCHOR2_Z,
            ANCHOR3_X,
            ANCHOR3_Y,
            ANCHOR3_Z,
            ANCHOR4_X,
            ANCHOR4_Y,
            ANCHOR4_Z,

            MAX
        }

        private int g_anchor1_x = 0, g_anchor1_y = 0, g_anchor1_z = 0;
        private int g_anchor2_x = 0, g_anchor2_y = 0, g_anchor2_z = 0;
        private int g_anchor3_x = 0, g_anchor3_y = 0, g_anchor3_z = 0;
        private int g_anchor4_x = 0, g_anchor4_y = 0, g_anchor4_z = 0;
        private SerialPort ComDevice = new SerialPort();
        DrawMap draw_t = new DrawMap();


        public DrawMapTool()
        {
            InitializeComponent();
            ComPortInit();
        }

        public void ComPortInit()
        {
            g_anchor1_x = int.Parse(anchor1_x.Text);
            g_anchor1_y = int.Parse(anchor1_y.Text);
            g_anchor1_z = int.Parse(anchor1_z.Text);

            g_anchor2_x = int.Parse(anchor2_x.Text);
            g_anchor2_y = int.Parse(anchor2_y.Text);
            g_anchor2_z = int.Parse(anchor2_z.Text);

            g_anchor3_x = int.Parse(anchor3_x.Text);
            g_anchor3_y = int.Parse(anchor3_y.Text);
            g_anchor3_z = int.Parse(anchor3_z.Text);

            g_anchor4_x = int.Parse(anchor4_x.Text);
            g_anchor4_y = int.Parse(anchor4_y.Text);
            g_anchor4_z = int.Parse(anchor4_z.Text);

            comPortBox.Items.AddRange(SerialPort.GetPortNames());
            if (comPortBox.Items.Count > 0)
            {
                comPortBox.SelectedIndex = 0;
            }
        }

        private void bt_openCom_Click(object sender, EventArgs e)
        {
            if (comPortBox.Items.Count <= 0)
            {
                MessageBox.Show("没有发现串口！");
                return;
            }

            if (ComDevice.IsOpen == false)
            {
                ComDevice.PortName = comPortBox.SelectedItem.ToString();
                ComDevice.BaudRate = 9600;
                ComDevice.Parity = Parity.None;
                ComDevice.DataBits = 8;
                ComDevice.StopBits = StopBits.One;
                ComDevice.RtsEnable = true;
                ComDevice.DtrEnable = true;
                ComDevice.ReceivedBytesThreshold = 1;
                try
                {
                    ComDevice.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bt_openCom.Text = "关闭串口";
            }
            else
            {
                try
                {
                    ComDevice.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bt_openCom.Text = "打开串口";
            }
            comPortBox.Enabled = !ComDevice.IsOpen;
        }

        private void parse_coordinate(anchor_enum anchor)
        {
            int temp = 0;
            switch (anchor)
            {
                case anchor_enum.ANCHOR1_X:
                    if (0 != anchor1_x.Text.Length)
                    {
                        if (!int.TryParse(anchor1_x.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor1_x = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR1_Y:
                    if (0 != anchor1_y.Text.Length)
                    {
                        if (!int.TryParse(anchor1_y.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor1_y = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR1_Z:
                    if (0 != anchor1_z.Text.Length)
                    {
                        if (!int.TryParse(anchor1_z.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor1_z = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR2_X:
                    if (0 != anchor2_x.Text.Length)
                    {
                        if (!int.TryParse(anchor2_x.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor2_x = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR2_Y:
                    if (0 != anchor1_y.Text.Length)
                    {
                        if (!int.TryParse(anchor2_y.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor2_y = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR2_Z:
                    if (0 != anchor1_z.Text.Length)
                    {
                        if (!int.TryParse(anchor2_z.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor2_z = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR3_X:
                    if (0 != anchor1_x.Text.Length)
                    {
                        if (!int.TryParse(anchor3_x.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor3_x = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR3_Y:
                    if (0 != anchor1_y.Text.Length)
                    {
                        if (!int.TryParse(anchor3_y.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor3_y = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR3_Z:
                    if (0 != anchor1_z.Text.Length)
                    {
                        if (!int.TryParse(anchor3_z.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor3_z = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR4_X:
                    if (0 != anchor1_x.Text.Length)
                    {
                        if (!int.TryParse(anchor4_x.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor4_x = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR4_Y:
                    if (0 != anchor1_y.Text.Length)
                    {
                        if (!int.TryParse(anchor4_y.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor4_y = temp;
                        }
                    }
                    break;
                case anchor_enum.ANCHOR4_Z:
                    if (0 != anchor1_z.Text.Length)
                    {
                        if (!int.TryParse(anchor4_z.Text, out temp))
                        {
                            MessageBox.Show("请正确输入数字");
                        }
                        else
                        {
                            g_anchor4_z = temp;
                        }
                    }
                    break;
            }
        }

        private void anchor1_x_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR1_X);
        }

        private void anchor1_y_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR1_Y);
        }

        private void anchor1_z_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR1_Z);
        }

        private void anchor2_x_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR2_X);
        }

        private void anchor2_y_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR2_Y);
        }

        private void anchor2_z_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR2_Z);
        }

        private void anchor3_x_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR3_X);
        }

        private void anchor3_y_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR3_Y);
        }

        private void anchor3_z_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR3_Z);
        }

        private void anchor4_x_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR4_X);
        }

        private void anchor4_y_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR4_Y);
        }

        private void anchor4_z_TextChanged(object sender, EventArgs e)
        {
            parse_coordinate(anchor_enum.ANCHOR4_Z);
        }

        private void bt_build_3D_model_Click(object sender, EventArgs e)
        {
            draw_t.GLDrawCubeCoordinates(openGLControl1.OpenGL);
        }

    }
}
