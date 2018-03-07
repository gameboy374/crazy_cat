using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpGL;

namespace PC_TOOL
{
    public partial class DrawMapTool : Form
    {
        DrawMap draw_t = new DrawMap();
        public DrawMapTool()
        {
            InitializeComponent();
            draw_t.GLDrawCubeCoordinates(openGLControl1.OpenGL);
            //draw_t.GLDrawSpaceAxes(openGLControl1.OpenGL);
            //draw_t.DrawGLScene(openGLControl1.OpenGL);
        }
    }
}
