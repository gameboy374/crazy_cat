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
        struct AnchorInfo_s {
            public  int anchor_id;
            public  double anchor_x;
            public  double anchor_y;
            public  double anchor_z;
        };

        private CoordPoint g_anchor1 = new CoordPoint( 0, 0, 0 );
        private CoordPoint g_anchor2 = new CoordPoint(100.0, 0, 0);
        private CoordPoint g_anchor3 = new CoordPoint(0, 100.0, 0);
        private CoordPoint g_anchor4 = new CoordPoint(0, 0, 100.0);
        private CoordPoint camera_location = new CoordPoint(0, 50, 300);
        private SerialPort ComDevice = new SerialPort();
        DrawMap draw_t;
        private void writeID_bt_Click(object sender, EventArgs e)
        {
            AnchorInfo_s anchor_info;
            double temp = 0.0;

            if((anchor_x.Text == "") || (anchor_y.Text == "") || (anchor_z.Text == ""))
            {
                MessageBox.Show("请输入正确的坐标地址");
                return;
            }

            if (!double.TryParse(anchor_x.Text, out temp))
            {
                MessageBox.Show("请正确输入X坐标");
                return;
            }
            else
            {
                if((temp <= 0.0)||(temp > 100.0))
                {
                    MessageBox.Show("请正确输入X坐标,(0.0 , 100.0]");
                    return;
                }
                anchor_info.anchor_x = temp;
            }

            if (!double.TryParse(anchor_y.Text, out temp))
            {
                MessageBox.Show("请正确输入Y坐标");
            }
            else
            {
                if ((temp <= 0.0) || (temp > 100.0))
                {
                    MessageBox.Show("请正确输入Y坐标,(0.0 , 100.0]");
                }
                anchor_info.anchor_y = temp;
            }

            if (!double.TryParse(anchor_z.Text, out temp))
            {
                MessageBox.Show("请正确输入Z坐标");
                return;
            }
            else
            {
                if ((temp <= 0.0) || (temp > 100.0))
                {
                    MessageBox.Show("请正确输入Z坐标,(0.0 , 100.0]");
                    return;
                }
                anchor_info.anchor_z = temp;
            }
            anchor_info.anchor_id = anchorID.SelectedIndex;

            if (ComDevice.IsOpen)
            {
                MessageBox.Show("写入成功");
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DrawMapTool()
        {
            InitializeComponent();
            ComPortInit();
            this.openGLControl1.MouseDown += glMap_MouseDown;
            this.openGLControl1.MouseMove += glMap_MouseMove;
            this.openGLControl1.MouseUp += glMap_MouseUp;
            this.openGLControl1.MouseWheel += glMap_MouseWheel;
        }

        private void glMap_MouseDown(object sender, MouseEventArgs e)
        {
            CoordPoint p = new CoordPoint(0, 50, 600);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draw_t.SetCameraPosition(openGLControl1.OpenGL, p);
            }
        }
        private void glMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

            }
        }
        private void glMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

            }
        }
        private void glMap_MouseWheel(object sender, MouseEventArgs e)
        {

        }
        public void ComPortInit()
        {
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
        
        private void bt_build_3D_model_Click(object sender, EventArgs e)
        {
            draw_t = new DrawMap(g_anchor1, g_anchor2, g_anchor3, g_anchor4, camera_location);

            draw_t.GLDrawCubeCoordinates(openGLControl1.OpenGL);
        }


    }
}
