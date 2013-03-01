using System.Drawing;
namespace Carbinet
{
    partial class frmSelect
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelect));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxChair = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupPie = new System.Windows.Forms.GroupBox();
            this.m_panelDrawing = new System.Drawing.PieChart.PieChartControl();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnHideSeat = new System.Windows.Forms.Button();
            this.btnClearState = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.groupBox_command = new System.Windows.Forms.GroupBox();
            this.groupBoxChair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPie.SuspendLayout();
            this.groupBox_command.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "A 不选择";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "C 基本明白";
            // 
            // groupBoxChair
            // 
            this.groupBoxChair.BackColor = System.Drawing.Color.White;
            this.groupBoxChair.Controls.Add(this.button6);
            this.groupBoxChair.Controls.Add(this.pictureBox1);
            this.groupBoxChair.Location = new System.Drawing.Point(7, 2);
            this.groupBoxChair.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBoxChair.Name = "groupBoxChair";
            this.groupBoxChair.Size = new System.Drawing.Size(806, 609);
            this.groupBoxChair.TabIndex = 20;
            this.groupBoxChair.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Carbinet.Properties.Resources.grey;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(295, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 34);
            this.button6.TabIndex = 22;
            this.button6.Text = "教师讲台";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 589);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "D 一知半解";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "B 完全明白";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "E 完全不明白";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(907, 616);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 28);
            this.btnQuit.TabIndex = 25;
            this.btnQuit.Text = "关闭(&Q)";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupPie
            // 
            this.groupPie.Controls.Add(this.m_panelDrawing);
            this.groupPie.Controls.Add(this.btn3);
            this.groupPie.Controls.Add(this.label1);
            this.groupPie.Controls.Add(this.label5);
            this.groupPie.Controls.Add(this.btn1);
            this.groupPie.Controls.Add(this.label4);
            this.groupPie.Controls.Add(this.btn2);
            this.groupPie.Controls.Add(this.label3);
            this.groupPie.Controls.Add(this.btn4);
            this.groupPie.Controls.Add(this.label2);
            this.groupPie.Controls.Add(this.btn5);
            this.groupPie.Location = new System.Drawing.Point(826, 2);
            this.groupPie.Name = "groupPie";
            this.groupPie.Size = new System.Drawing.Size(167, 401);
            this.groupPie.TabIndex = 32;
            this.groupPie.TabStop = false;
            // 
            // m_panelDrawing
            // 
            this.m_panelDrawing.Location = new System.Drawing.Point(8, 15);
            this.m_panelDrawing.Name = "m_panelDrawing";
            this.m_panelDrawing.Size = new System.Drawing.Size(149, 149);
            this.m_panelDrawing.TabIndex = 21;
            this.m_panelDrawing.ToolTips = null;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.BackgroundImage = global::Carbinet.Properties.Resources.orange;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(13, 312);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 23);
            this.btn3.TabIndex = 18;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.BackgroundImage = global::Carbinet.Properties.Resources.grey;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(13, 183);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 23);
            this.btn1.TabIndex = 18;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.BackgroundImage = global::Carbinet.Properties.Resources.yellow;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(13, 269);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 23);
            this.btn2.TabIndex = 18;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.BackgroundImage = global::Carbinet.Properties.Resources.blue;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(13, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 23);
            this.btn4.TabIndex = 18;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.BackgroundImage = global::Carbinet.Properties.Resources.purple;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(13, 355);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 23);
            this.btn5.TabIndex = 18;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btnHideSeat
            // 
            this.btnHideSeat.BackgroundImage = global::Carbinet.Properties.Resources.IconsLand_002_left;
            this.btnHideSeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHideSeat.FlatAppearance.BorderSize = 0;
            this.btnHideSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideSeat.Location = new System.Drawing.Point(10, 9);
            this.btnHideSeat.Name = "btnHideSeat";
            this.btnHideSeat.Size = new System.Drawing.Size(40, 38);
            this.btnHideSeat.TabIndex = 34;
            this.btnHideSeat.UseVisualStyleBackColor = true;
            this.btnHideSeat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClearState
            // 
            this.btnClearState.BackgroundImage = global::Carbinet.Properties.Resources.clear_state;
            this.btnClearState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearState.FlatAppearance.BorderSize = 0;
            this.btnClearState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearState.Location = new System.Drawing.Point(114, 11);
            this.btnClearState.Name = "btnClearState";
            this.btnClearState.Size = new System.Drawing.Size(40, 35);
            this.btnClearState.TabIndex = 33;
            this.btnClearState.UseVisualStyleBackColor = true;
            this.btnClearState.Click += new System.EventHandler(this.btnClearState_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(826, 618);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(82, 25);
            this.btnMin.TabIndex = 34;
            this.btnMin.Text = "最小化(&M)";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Visible = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // groupBox_command
            // 
            this.groupBox_command.Controls.Add(this.btnClearState);
            this.groupBox_command.Controls.Add(this.btnHideSeat);
            this.groupBox_command.Location = new System.Drawing.Point(826, 395);
            this.groupBox_command.Name = "groupBox_command";
            this.groupBox_command.Size = new System.Drawing.Size(167, 94);
            this.groupBox_command.TabIndex = 35;
            this.groupBox_command.TabStop = false;
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1002, 655);
            this.Controls.Add(this.groupPie);
            this.Controls.Add(this.groupBox_command);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupBoxChair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "课堂互动";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSelect_Load);
            this.groupBoxChair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPie.ResumeLayout(false);
            this.groupPie.PerformLayout();
            this.groupBox_command.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.PieChart.PieChartControl m_panelDrawing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxChair;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupPie;
        private System.Windows.Forms.Button btnClearState;
        private System.Windows.Forms.Button btnHideSeat;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.GroupBox groupBox_command;
    }
}

