using HtmlEditor;
namespace Carbinet
{
    partial class frmQuestionMng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionMng));
            this.groupQuestion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.txtQuestionName = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAnswer = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupStatics = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.editor1 = new HtmlEditor.Editor();
            this.PieChart1 = new Nexus.Windows.Forms.PieChart();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnStatics = new System.Windows.Forms.Button();
            this.groupQuestion.SuspendLayout();
            this.groupStatics.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupQuestion
            // 
            this.groupQuestion.Controls.Add(this.label6);
            this.groupQuestion.Controls.Add(this.label5);
            this.groupQuestion.Controls.Add(this.btnDelete);
            this.groupQuestion.Controls.Add(this.btnDown);
            this.groupQuestion.Controls.Add(this.btnUP);
            this.groupQuestion.Controls.Add(this.btnNewQuestion);
            this.groupQuestion.Controls.Add(this.txtQuestionName);
            this.groupQuestion.Controls.Add(this.lblOrder);
            this.groupQuestion.Controls.Add(this.label4);
            this.groupQuestion.Controls.Add(this.label3);
            this.groupQuestion.Controls.Add(this.editor1);
            this.groupQuestion.Controls.Add(this.cmbAnswer);
            this.groupQuestion.Controls.Add(this.btnSave);
            this.groupQuestion.Controls.Add(this.label2);
            this.groupQuestion.Controls.Add(this.label1);
            this.groupQuestion.Location = new System.Drawing.Point(220, 29);
            this.groupQuestion.Name = "groupQuestion";
            this.groupQuestion.Size = new System.Drawing.Size(745, 506);
            this.groupQuestion.TabIndex = 1;
            this.groupQuestion.TabStop = false;
            this.groupQuestion.Text = "题目编辑";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "无";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "正确率：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(636, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(678, 44);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "下移(&N)";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(619, 44);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(55, 23);
            this.btnUP.TabIndex = 7;
            this.btnUP.Text = "上移(&P)";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Location = new System.Drawing.Point(399, 465);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(92, 28);
            this.btnNewQuestion.TabIndex = 6;
            this.btnNewQuestion.Text = "新建题目(&N)";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // txtQuestionName
            // 
            this.txtQuestionName.Location = new System.Drawing.Point(14, 45);
            this.txtQuestionName.Name = "txtQuestionName";
            this.txtQuestionName.Size = new System.Drawing.Size(512, 21);
            this.txtQuestionName.TabIndex = 5;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrder.Location = new System.Drawing.Point(579, 46);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(37, 14);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "次序";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "次序：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "名称：";
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnswer.FormattingEnabled = true;
            this.cmbAnswer.Location = new System.Drawing.Point(53, 471);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Size = new System.Drawing.Size(135, 20);
            this.cmbAnswer.TabIndex = 2;
            this.cmbAnswer.SelectedIndexChanged += new System.EventHandler(this.cmbAnswer_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(518, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "答案：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "内容：";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 506);
            this.treeView1.TabIndex = 4;
            // 
            // groupStatics
            // 
            this.groupStatics.Controls.Add(this.PieChart1);
            this.groupStatics.Controls.Add(this.zedGraphControl1);
            this.groupStatics.Controls.Add(this.button2);
            this.groupStatics.Controls.Add(this.button1);
            this.groupStatics.Controls.Add(this.label10);
            this.groupStatics.Controls.Add(this.label9);
            this.groupStatics.Controls.Add(this.groupBox2);
            this.groupStatics.Controls.Add(this.label8);
            this.groupStatics.Controls.Add(this.label7);
            this.groupStatics.Location = new System.Drawing.Point(220, 17);
            this.groupStatics.Name = "groupStatics";
            this.groupStatics.Size = new System.Drawing.Size(745, 506);
            this.groupStatics.TabIndex = 5;
            this.groupStatics.TabStop = false;
            this.groupStatics.Text = "正确率统计";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "柱状图：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "饼状图：";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(19, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 9);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "正确率：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "错误率：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(579, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(579, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(19, 275);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(698, 222);
            this.zedGraphControl1.TabIndex = 5;
            // 
            // editor1
            // 
            this.editor1.BodyHtml = null;
            this.editor1.BodyText = null;
            this.editor1.DocumentText = resources.GetString("editor1.DocumentText");
            this.editor1.EditorBackColor = System.Drawing.Color.White;
            this.editor1.EditorForeColor = System.Drawing.Color.Black;
            this.editor1.FontName = null;
            this.editor1.FontSize = HtmlEditor.FontSize.NA;
            this.editor1.Location = new System.Drawing.Point(14, 106);
            this.editor1.Name = "editor1";
            this.editor1.Size = new System.Drawing.Size(717, 349);
            this.editor1.TabIndex = 3;
            // 
            // PieChart1
            // 
            this.PieChart1.Location = new System.Drawing.Point(225, 34);
            this.PieChart1.Name = "PieChart1";
            this.PieChart1.Radius = 200F;
            this.PieChart1.Size = new System.Drawing.Size(277, 186);
            this.PieChart1.TabIndex = 6;
            this.PieChart1.Text = "pieChart1";
            this.PieChart1.Thickness = 10F;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(239, 540);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "题目信息";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnStatics
            // 
            this.btnStatics.Location = new System.Drawing.Point(239, 539);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(75, 23);
            this.btnStatics.TabIndex = 7;
            this.btnStatics.Text = "统计信息";
            this.btnStatics.UseVisualStyleBackColor = true;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // frmQuestionMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 586);
            this.Controls.Add(this.btnStatics);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupQuestion);
            this.Controls.Add(this.groupStatics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestionMng";
            this.Text = "课堂测验题目管理";
            this.groupQuestion.ResumeLayout(false);
            this.groupQuestion.PerformLayout();
            this.groupStatics.ResumeLayout(false);
            this.groupStatics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupQuestion;
        private System.Windows.Forms.ComboBox cmbAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private Editor editor1;
        private System.Windows.Forms.TextBox txtQuestionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupStatics;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Drawing.PieChart.PieChartControl m_panelDrawing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private Nexus.Windows.Forms.PieChart PieChart1;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnStatics;
    }
}