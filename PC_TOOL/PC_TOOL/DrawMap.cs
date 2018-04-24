using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpGL;
using SharpGL.SceneGraph.Quadrics;
namespace PC_TOOL
{
    public struct CoordPoint
    {
        public double x;
        public double y;
        public double z;
        public CoordPoint(double x1, double y1, double z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
    };
    public class DrawMap
    {

        private float AXES_LEN = 10.0f;
        private CoordPoint origin_coordinates;
        private CoordPoint x_coordinates;
        private CoordPoint y_coordinates;
        private CoordPoint z_coordinates;
        private CoordPoint camera_location;

        public DrawMap(CoordPoint p0, CoordPoint p_x, CoordPoint p_y, CoordPoint p_z, CoordPoint p_camera)
        {
            origin_coordinates = p0;
            x_coordinates = p_x;
            y_coordinates = p_y;
            z_coordinates = p_z;
            camera_location = p_camera;
        }

        public void SetCameraPosition(OpenGL gl, CoordPoint p_camera)
        {
            camera_location = p_camera;
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(camera_location.x, camera_location.y, camera_location.z, 0, 0, 0, 0, 1, 0);
            GLDrawCubeCoordinates(gl);
        }
        public void GLInitWindow(OpenGL gl)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(40, 1, 1, 500);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();
            gl.LookAt(camera_location.x, camera_location.y, camera_location.z, 0, 0, 0, 0, 1, 0);
        }
        public void GLDrawGrid(OpenGL gl, CoordPoint pt1, CoordPoint pt2, int num)
        {
            double _xLen = (pt2.x - pt1.x) / num;
            double _yLen = (pt2.y - pt1.y) / num;
            double _zLen = (pt2.z - pt1.z) / num;
            gl.LineWidth(1.0f);
            gl.LineStipple(1, 0x0303);//线条样式
            gl.Begin(OpenGL.GL_LINES);
            gl.Enable(OpenGL.GL_LINE_SMOOTH);
            //glColor3f(0.0f,0.0f, 1.0f); //白色线条
            int xi = 0;
            int yi = 0;
            int zi = 0;
            //绘制平行于X的直线
            for (zi = 0; zi <= num; zi++)
            {
                double z = _zLen * zi + pt1.z;
                for (yi = 0; yi <= num; yi++)
                {
                    double y = _yLen * yi + pt1.y;
                    gl.Vertex(pt1.x, y, z);
                    gl.Vertex(pt2.x, y, z);
                }
            }
            //绘制平行于Y的直线
            for (zi = 0; zi <= num; zi++)
            {
                double z = _zLen * zi + pt1.z;
                for (xi = 0; xi <= num; xi++)
                {
                    double x = _xLen * xi + pt1.x;
                    gl.Vertex(x, pt1.y, z);
                    gl.Vertex(x, pt2.y, z);
                }
            }
            //绘制平行于Z的直线
            for (yi = 0; yi <= num; yi++)
            {
                double y = _yLen * yi + pt1.y;
                for (xi = 0; xi <= num; xi++)
                {
                    double x = _xLen * xi + pt1.x;
                    gl.Vertex(x, y, pt1.z);
                    gl.Vertex(x, y, pt2.z);
                }
            }
            gl.End();
        }
        public void GLDrawSpaceAxes(OpenGL gl)
        {
            GLInitWindow(gl);
            gl.PushMatrix();
            gl.Color(1.0f, 1.0f, 1.0f);
            var sphere = gl.NewQuadric();
            gl.QuadricDrawStyle(sphere, OpenGL.GL_QUADS);
            gl.QuadricNormals(sphere, OpenGL.GLU_SMOOTH);
            gl.QuadricOrientation(sphere, (int)OpenGL.GLU_OUTSIDE);
            gl.QuadricTexture(sphere, (int)OpenGL.GLU_FALSE);
            gl.Sphere(sphere, 0.1, 8, 8);
            gl.DeleteQuadric(sphere);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Cylinder(gl.NewQuadric(), 0.02, 0.02, AXES_LEN, 10, 5);
            gl.Translate(0, 0, AXES_LEN);
            gl.Cylinder(gl.NewQuadric(), 0.1, 0.0, 0.1, 10, 5);                 //Z
            gl.PopMatrix();
            gl.PushMatrix();
            gl.Translate(0, 0.5, AXES_LEN);
            gl.Rotate(90, 0.0, 1.0, 0.0);
            GLPrint(gl,"Z");                                               // Print GL Text ToThe Screen
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Rotate(-90, 1.0, 0.0, 0.0);
            gl.Cylinder(gl.NewQuadric(), 0.02, 0.02, AXES_LEN, 10, 5);
            gl.Translate(0, 0, AXES_LEN);
            gl.Cylinder(gl.NewQuadric(), 0.1, 0.0, 0.6, 10, 5);                 //Y
            gl.PopMatrix();
            gl.PushMatrix();
            gl.Translate(0.5, AXES_LEN, 0);
            GLPrint(gl, "Y");                                               // Print GL Text ToThe Screen
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Rotate(90, 0.0, 1.0, 0.0);
            gl.Cylinder(gl.NewQuadric(), 0.02, 0.02, AXES_LEN, 10, 5);         //X
            gl.Translate(0, 0, AXES_LEN);
            gl.Cylinder(gl.NewQuadric(), 0.1, 0.0, 0.6, 10, 5);                 //X
            gl.PopMatrix();
            gl.PushMatrix();
            gl.Translate(AXES_LEN, 0.5, 0);
            GLPrint(gl, "X");                                               // Print GL Text ToThe Screen
            gl.PopMatrix();
        }
        public void GLDrawCubeCoordinates(OpenGL gl)
        {
            /*****网格绘制*****/
            /*****使用颜色混合来消除一些锯齿， 主要针对点和线
            以及不相互重叠的多边形的反锯齿。*****/
            gl.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);
            gl.Enable(OpenGL.GL_BLEND);
            gl.Enable(OpenGL.GL_POINT_SMOOTH);                   //设置反走样
            gl.Hint(OpenGL.GL_POINT_SMOOTH_HINT, OpenGL.GL_NICEST);       //设置反走样
            gl.Enable(OpenGL.GL_LINE_SMOOTH);
            gl.Hint(OpenGL.GL_LINE_SMOOTH_HINT, OpenGL.GL_NICEST);
            gl.Enable(OpenGL.GL_POLYGON_SMOOTH);
            gl.Hint(OpenGL.GL_POLYGON_SMOOTH_HINT, OpenGL.GL_NICEST);
            GLInitWindow(gl);
            //绘制立体坐标系
            gl.Rotate(-45, 0.0, 1.0, 0.0);
            //确定坐标系原点
            gl.PushMatrix();
            gl.Color(1.0f, 1.0f, 1.0f);
            //gl.Translate(-5, 0, -5);
            gl.Sphere(gl.NewQuadric(), 0.2, 20, 20);
            gl.PopMatrix();
            //画网格线,X-Z平面
            CoordPoint cpoint1 = new CoordPoint ( 0, 0, 0 );
            CoordPoint cpoint2 = new CoordPoint ( x_coordinates.x, 0, z_coordinates.z );
            gl.Color(0.9f, 0.9f, 0.9f);
            GLDrawGrid(gl, cpoint1, cpoint2, 10);
            //画网格线,
            gl.PushMatrix();
            gl.Rotate(90, 1.0, 0.0, 0.0);
            gl.Translate(0.0f, 0.0f, -z_coordinates.z);
            CoordPoint cpoint3 = new CoordPoint ( 0, 0, 0 );
            CoordPoint cpoint4 = new CoordPoint (x_coordinates.x, 0, z_coordinates.z);
            gl.Color(0.9f, 0.9f, 0.0f);
            GLDrawGrid(gl, cpoint3, cpoint4, 10);
            gl.PopMatrix();
            //画网格线
            gl.PushMatrix();
            gl.Rotate(90, 0.0, 0.0, 1.0);
            //gl.Translate(5, 5, -0);
            CoordPoint cpoint5 = new CoordPoint(0, 0, 0 );
            CoordPoint cpoint6 = new CoordPoint(x_coordinates.x, 0, z_coordinates.z);
            gl.Color(0.0f, 0.9f, 0.0f);
            GLDrawGrid(gl, cpoint5, cpoint6, 10);
            gl.PopMatrix();
            //画坐标轴
            gl.PushMatrix();
            gl.Color(0.0f, 1, 0.0f);
            gl.Cylinder(gl.NewQuadric(), 0.05, 0.05, z_coordinates.z, 10, 5);           //Z
            gl.Translate(0, 0, z_coordinates.z);
            gl.Cylinder(gl.NewQuadric(), 0.2, 0.0, 0.5, 10, 5);                 //Z
            gl.PopMatrix();
            gl.PushMatrix();
            gl.Translate(0, 0.2, z_coordinates.z);
            GLPrint(gl, "Z");                                               // Print GL Text ToThe Screen
            gl.PopMatrix();
            //画坐标轴
            gl.PushMatrix();
            gl.Color(1, 0, 0.0f);
            gl.Rotate(90, 0.0, 1.0, 0.0);
            gl.Cylinder(gl.NewQuadric(), 0.05, 0.05,x_coordinates.x, 10, 5);           //X
            gl.Translate(0, 0, x_coordinates.x);
            gl.Cylinder(gl.NewQuadric(), 0.2, 0.0, 0.5, 10, 5);                 //X
            gl.PopMatrix();
            gl.PushMatrix();
            gl.Rotate(90, 0.0, 1.0, 0.0);
            gl.Translate(0, 0.2, x_coordinates.x);
            GLPrint(gl, "X");                                               // Print GL Text ToThe Screen
            gl.PopMatrix();
            //画坐标轴
            gl.PushMatrix();
            gl.Color(1, 1, 0.0f);
            gl.Rotate(-90, 1.0, 0.0, 0.0);
            gl.Cylinder(gl.NewQuadric(), 0.05, 0.05, y_coordinates.y, 10, 5);           //Y
            gl.Translate(0, 0, y_coordinates.y);
            gl.Cylinder(gl.NewQuadric(), 0.2, 0.0, 0.5, 10, 5);                 //Y
            gl.PopMatrix();
            gl.PushMatrix();
            gl.Rotate(-90, 1.0, 0.0, 0.0);
            gl.Translate(0.0, 0.6, y_coordinates.y);
            gl.Rotate(90, 1.0, 0.0, 0.0);
            GLPrint(gl, "Y");                                               // Print GL Text ToThe Screen
            gl.PopMatrix();
            /*****取消反锯齿*****/
            gl.Disable(OpenGL.GL_BLEND);
            gl.Disable(OpenGL.GL_LINE_SMOOTH);
            gl.Disable(OpenGL.GL_POINT_SMOOTH);
            gl.Disable(OpenGL.GL_POLYGON_SMOOTH);
        }

        private void GLPrint(OpenGL gl,string str)
        {
            gl.LineWidth(3.0f);
            gl.LineStipple(1, 0xFFFF);//线条样式
            if ("X" == str)
            {
                gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(1.0f, -1.0f, 0.0f);
                gl.Vertex(1.0f, 0.0f, 0.0f);
                gl.Vertex(0.0f, -1.0f, 0.0f);
                gl.End();
            }
            else if("Y" == str)
            {
                gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(0.0f, -1.0f, 0.0f);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(-0.5f, 0.5f, 0.0f);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(0.5f, 0.5f, 0.0f);
                gl.End();
            }
            else if("Z" == str)
            {
                gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(0.0f, 0.0f, 0.0f);
                gl.Vertex(0.5f, 0.0f, 0.0f);
                gl.Vertex(0.5f, 0.0f, 0.0f);
                gl.Vertex(0.0f, -0.5f, 0.0f);
                gl.Vertex(0.0f, -0.5f, 0.0f);
                gl.Vertex(0.5f, -0.5f, 0.0f);
                gl.End();
            }
        }
        public bool DrawGLScene(OpenGL gl) // 这个自定义函数用于完成窗口场景绘制
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            // 清屏及深度缓存
            gl.LoadIdentity();
            // 重置模型观察矩阵
            gl.Translate(-1.0f, -1.0f, -6.0f);
            //平移绘制起点（向左平移1个单位，向下平移1个单位，朝垂直屏幕向内平移6个单位）
            gl.Color(1.0f, 0.0f, 0.0f);
            // 设置画笔颜色（RGB：此处为红色）

            // 绘制x、y、z轴线段
            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0.0f, 0.0f, 0.0f);
            //绘制线段的起点，这里为相对坐标，即相将glTranslatef移动后的点作为原点
            gl.Vertex(3.0f, 0.0f, 0.0f);
            //确定第一条线段的终点（3，0，0） 
            gl.Vertex(0.0f, 0.0f, 0.0f);
            //确定第二条线段的起点（0，0，0）
            gl.Vertex(0.0f, 3.0f, 0.0f);
            //确定第二条线段的终点（0，3，0）
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 3.0f);
            gl.End();

            //平移起点并重新设置画笔颜色用于区分绘制的物体
            gl.Translate(-1.0f, -1.0f, -6.0f);
            gl.Color(0.5f, 0.5f, 1.0f);

            //绘制一个矩形  
            gl.Begin(OpenGL.GL_QUADS);

            gl.Vertex(0.0f, 0.0f, 0.0f);
            // Top Left
            gl.Vertex(0.0f, 3.0f, 0.0f);
            // Top Right
            gl.Vertex(0.0f, 3.0f, 3.0f);
            // Bottom Right
            gl.Vertex(0.0f, 0.0f, 3.0f);
            // Bottom Left
            gl.End();

            //更改画笔颜色，并绘制另外一个矩形

            gl.Color(0.0f, 0.0f, 1.0f);
            // Set The Color To Blue One Time Only
            gl.Begin(OpenGL.GL_QUADS);
            // Draw A Quad
            gl.Vertex(0.0f, 0.0f, 0.0f);
            // Top Left
            gl.Vertex(3.0f, 0.0f, 0.0f);
            // Top Right
            gl.Vertex(3.0f, 0.0f, 3.0f);
            // Bottom Right
            gl.Vertex(0.0f, 0.0f, 3.0f);
            // Bottom Left
            gl.End();

            //在窗口上显示“X”表示X轴
            gl.Translate(4.0f, 0.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0.0f, 0.0f, 0.0f);

            gl.Vertex(1.0f, -1.0f, 0.0f);

            gl.Vertex(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, -1.0f, 0.0f);
            gl.End();

            //在窗口上显示“Y”表示Y轴
            gl.Translate(-5.0f, 4.0f, 0.0f);
            gl.Color(0.0f, 0.5f, 0.5f);
            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0.0f, 0.0f, 0.0f);

            gl.Vertex(0.0f, -1.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(-0.5f, 0.5f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.Vertex(0.5f, 0.5f, 0.0f);
            gl.End();

            //在窗口上显示“Z”表示Z轴
            gl.Translate(0.0f, -4.0f, 4.0f);
            gl.Color(0.5f, 0.0f, 0.5f);
            gl.Begin(OpenGL.GL_LINES);

            gl.Vertex(0.0f, 0.0f, 0.0f);

            gl.Vertex(0.5f, 0.0f, 0.0f);
            gl.Vertex(0.5f, 0.0f, 0.0f);
            gl.Vertex(0.0f, -0.5f, 0.0f);
            gl.Vertex(0.0f, -0.5f, 0.0f);
            gl.Vertex(0.5f, -0.5f, 0.0f);
            gl.End();
            return true;
        }
    }
}
