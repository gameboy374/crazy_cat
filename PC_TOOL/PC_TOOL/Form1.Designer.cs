namespace PC_TOOL
{
    partial class DrawMapTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.bt_openCom = new System.Windows.Forms.Button();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.anchor1_z = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anchor1_y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.anchor1_x = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.anchor2_z = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.anchor2_y = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.anchor2_x = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.anchor3_z = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.anchor3_y = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.anchor3_x = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.anchor4_z = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.anchor4_y = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.anchor4_x = new System.Windows.Forms.TextBox();
            this.bt_build_3D_model = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.AutoSize = true;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openGLControl1.Location = new System.Drawing.Point(246, 3);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(810, 680);
            this.openGLControl1.TabIndex = 0;
            // 
            // bt_openCom
            // 
            this.bt_openCom.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_openCom.Location = new System.Drawing.Point(123, 12);
            this.bt_openCom.Name = "bt_openCom";
            this.bt_openCom.Size = new System.Drawing.Size(117, 54);
            this.bt_openCom.TabIndex = 1;
            this.bt_openCom.Text = "打开串口";
            this.bt_openCom.UseVisualStyleBackColor = true;
            this.bt_openCom.Click += new System.EventHandler(this.bt_openCom_Click);
            // 
            // comPortBox
            // 
            this.comPortBox.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(12, 25);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(88, 29);
            this.comPortBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.anchor1_z);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.anchor1_y);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.anchor1_x);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(7, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 96);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "基站坐标1:";
            // 
            // anchor1_z
            // 
            this.anchor1_z.Location = new System.Drawing.Point(159, 62);
            this.anchor1_z.Name = "anchor1_z";
            this.anchor1_z.Size = new System.Drawing.Size(55, 26);
            this.anchor1_z.TabIndex = 6;
            this.anchor1_z.Text = "0";
            this.anchor1_z.TextChanged += new System.EventHandler(this.anchor1_z_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(156, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(81, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // anchor1_y
            // 
            this.anchor1_y.Location = new System.Drawing.Point(84, 62);
            this.anchor1_y.Name = "anchor1_y";
            this.anchor1_y.Size = new System.Drawing.Size(55, 26);
            this.anchor1_y.TabIndex = 5;
            this.anchor1_y.Text = "0";
            this.anchor1_y.TextChanged += new System.EventHandler(this.anchor1_y_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // anchor1_x
            // 
            this.anchor1_x.Location = new System.Drawing.Point(11, 62);
            this.anchor1_x.Name = "anchor1_x";
            this.anchor1_x.Size = new System.Drawing.Size(55, 26);
            this.anchor1_x.TabIndex = 1;
            this.anchor1_x.Text = "0";
            this.anchor1_x.TextChanged += new System.EventHandler(this.anchor1_x_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.anchor2_z);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.anchor2_y);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.anchor2_x);
            this.panel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(7, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 96);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "基站坐标2:";
            // 
            // anchor2_z
            // 
            this.anchor2_z.Location = new System.Drawing.Point(159, 62);
            this.anchor2_z.Name = "anchor2_z";
            this.anchor2_z.Size = new System.Drawing.Size(55, 26);
            this.anchor2_z.TabIndex = 6;
            this.anchor2_z.Text = "0";
            this.anchor2_z.TextChanged += new System.EventHandler(this.anchor2_z_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(156, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(81, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y:";
            // 
            // anchor2_y
            // 
            this.anchor2_y.Location = new System.Drawing.Point(84, 62);
            this.anchor2_y.Name = "anchor2_y";
            this.anchor2_y.Size = new System.Drawing.Size(55, 26);
            this.anchor2_y.TabIndex = 5;
            this.anchor2_y.Text = "0";
            this.anchor2_y.TextChanged += new System.EventHandler(this.anchor2_y_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "X:";
            // 
            // anchor2_x
            // 
            this.anchor2_x.Location = new System.Drawing.Point(11, 62);
            this.anchor2_x.Name = "anchor2_x";
            this.anchor2_x.Size = new System.Drawing.Size(55, 26);
            this.anchor2_x.TabIndex = 1;
            this.anchor2_x.Text = "0";
            this.anchor2_x.TextChanged += new System.EventHandler(this.anchor2_x_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.anchor3_z);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.anchor3_y);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.anchor3_x);
            this.panel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.Location = new System.Drawing.Point(7, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 96);
            this.panel3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "基站坐标3:";
            // 
            // anchor3_z
            // 
            this.anchor3_z.Location = new System.Drawing.Point(159, 62);
            this.anchor3_z.Name = "anchor3_z";
            this.anchor3_z.Size = new System.Drawing.Size(55, 26);
            this.anchor3_z.TabIndex = 6;
            this.anchor3_z.Text = "0";
            this.anchor3_z.TextChanged += new System.EventHandler(this.anchor3_z_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(156, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Z:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(81, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Y:";
            // 
            // anchor3_y
            // 
            this.anchor3_y.Location = new System.Drawing.Point(84, 62);
            this.anchor3_y.Name = "anchor3_y";
            this.anchor3_y.Size = new System.Drawing.Size(55, 26);
            this.anchor3_y.TabIndex = 5;
            this.anchor3_y.Text = "0";
            this.anchor3_y.TextChanged += new System.EventHandler(this.anchor3_y_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(8, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "X:";
            // 
            // anchor3_x
            // 
            this.anchor3_x.Location = new System.Drawing.Point(11, 62);
            this.anchor3_x.Name = "anchor3_x";
            this.anchor3_x.Size = new System.Drawing.Size(55, 26);
            this.anchor3_x.TabIndex = 1;
            this.anchor3_x.Text = "0";
            this.anchor3_x.TextChanged += new System.EventHandler(this.anchor3_x_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.anchor4_z);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.anchor4_y);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.anchor4_x);
            this.panel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel4.Location = new System.Drawing.Point(7, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 96);
            this.panel4.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "基站坐标4:";
            // 
            // anchor4_z
            // 
            this.anchor4_z.Location = new System.Drawing.Point(159, 62);
            this.anchor4_z.Name = "anchor4_z";
            this.anchor4_z.Size = new System.Drawing.Size(55, 26);
            this.anchor4_z.TabIndex = 6;
            this.anchor4_z.Text = "0";
            this.anchor4_z.TextChanged += new System.EventHandler(this.anchor4_z_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(156, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Z:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(81, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Y:";
            // 
            // anchor4_y
            // 
            this.anchor4_y.Location = new System.Drawing.Point(84, 62);
            this.anchor4_y.Name = "anchor4_y";
            this.anchor4_y.Size = new System.Drawing.Size(55, 26);
            this.anchor4_y.TabIndex = 5;
            this.anchor4_y.Text = "0";
            this.anchor4_y.TextChanged += new System.EventHandler(this.anchor4_y_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(8, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "X:";
            // 
            // anchor4_x
            // 
            this.anchor4_x.Location = new System.Drawing.Point(11, 62);
            this.anchor4_x.Name = "anchor4_x";
            this.anchor4_x.Size = new System.Drawing.Size(55, 26);
            this.anchor4_x.TabIndex = 1;
            this.anchor4_x.Text = "0";
            this.anchor4_x.TextChanged += new System.EventHandler(this.anchor4_x_TextChanged);
            // 
            // bt_build_3D_model
            // 
            this.bt_build_3D_model.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_build_3D_model.Location = new System.Drawing.Point(45, 564);
            this.bt_build_3D_model.Name = "bt_build_3D_model";
            this.bt_build_3D_model.Size = new System.Drawing.Size(132, 48);
            this.bt_build_3D_model.TabIndex = 9;
            this.bt_build_3D_model.Text = "构建空间模型";
            this.bt_build_3D_model.UseVisualStyleBackColor = true;
            this.bt_build_3D_model.Click += new System.EventHandler(this.bt_build_3D_model_Click);
            // 
            // DrawMapTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 685);
            this.Controls.Add(this.bt_build_3D_model);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.bt_openCom);
            this.Controls.Add(this.openGLControl1);
            this.Name = "DrawMapTool";
            this.Text = "PC_TOOL";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Button bt_openCom;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox anchor1_x;
        private System.Windows.Forms.TextBox anchor1_z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox anchor1_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anchor2_z;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox anchor2_y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox anchor2_x;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anchor3_z;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox anchor3_y;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox anchor3_x;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox anchor4_z;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox anchor4_y;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox anchor4_x;
        private System.Windows.Forms.Button bt_build_3D_model;
    }
}

