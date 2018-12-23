namespace Sudoku
{
    partial class Form1
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
            this.pBoard = new System.Windows.Forms.Panel();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pBoard
            // 
            this.pBoard.Location = new System.Drawing.Point(154, 12);
            this.pBoard.Name = "pBoard";
            this.pBoard.Size = new System.Drawing.Size(290, 290);
            this.pBoard.TabIndex = 0;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Dễ",
            "Thường",
            "Khó"});
            this.cbLevel.Location = new System.Drawing.Point(12, 75);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(121, 21);
            this.cbLevel.TabIndex = 1;
            this.cbLevel.Text = "Độ khó";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(5, 22);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(141, 37);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "00:15:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(12, 162);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(121, 140);
            this.txtKQ.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.pBoard);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBoard;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

