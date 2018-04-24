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
            this.anchorID = new System.Windows.Forms.ComboBox();
            this.writeID_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anchor_z = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.anchor_y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.anchor_x = new System.Windows.Forms.TextBox();
            this.bt_build_3D_model = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.anchorID);
            this.panel1.Controls.Add(this.writeID_bt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.anchor_z);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.anchor_y);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.anchor_x);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(7, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 213);
            this.panel1.TabIndex = 3;
            // 
            // anchorID
            // 
            this.anchorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anchorID.FormattingEnabled = true;
            this.anchorID.Items.AddRange(new object[] {
            "A0",
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "A10",
            "A11",
            "A12",
            "A13",
            "A14",
            "A15"});
            this.anchorID.Location = new System.Drawing.Point(74, 52);
            this.anchorID.Name = "anchorID";
            this.anchorID.Size = new System.Drawing.Size(81, 24);
            this.anchorID.TabIndex = 11;
            // 
            // writeID_bt
            // 
            this.writeID_bt.Location = new System.Drawing.Point(62, 146);
            this.writeID_bt.Name = "writeID_bt";
            this.writeID_bt.Size = new System.Drawing.Size(93, 55);
            this.writeID_bt.TabIndex = 10;
            this.writeID_bt.Text = "写入配置";
            this.writeID_bt.UseVisualStyleBackColor = true;
            this.writeID_bt.Click += new System.EventHandler(this.writeID_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "基站ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "配置基站坐标:";
            // 
            // anchor_z
            // 
            this.anchor_z.Location = new System.Drawing.Point(159, 111);
            this.anchor_z.Name = "anchor_z";
            this.anchor_z.Size = new System.Drawing.Size(55, 26);
            this.anchor_z.TabIndex = 6;
            this.anchor_z.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(156, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Z(m):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(81, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y(m):";
            // 
            // anchor_y
            // 
            this.anchor_y.Location = new System.Drawing.Point(84, 111);
            this.anchor_y.Name = "anchor_y";
            this.anchor_y.Size = new System.Drawing.Size(55, 26);
            this.anchor_y.TabIndex = 5;
            this.anchor_y.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X(m):";
            // 
            // anchor_x
            // 
            this.anchor_x.Location = new System.Drawing.Point(11, 111);
            this.anchor_x.Name = "anchor_x";
            this.anchor_x.Size = new System.Drawing.Size(55, 26);
            this.anchor_x.TabIndex = 1;
            this.anchor_x.Text = "0";
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.bt_openCom);
            this.Controls.Add(this.openGLControl1);
            this.Name = "DrawMapTool";
            this.Text = "PC_TOOL";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Button bt_openCom;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox anchor_x;
        private System.Windows.Forms.TextBox anchor_z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox anchor_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_build_3D_model;
        private System.Windows.Forms.Button writeID_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox anchorID;
    }
}

