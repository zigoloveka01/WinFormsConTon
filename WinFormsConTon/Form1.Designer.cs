namespace WinFormsConTon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(663, 390);
            button1.Name = "button1";
            button1.Size = new Size(113, 48);
            button1.TabIndex = 0;
            button1.Text = "ปิดโปรแกรม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 248);
            button2.Name = "button2";
            button2.Size = new Size(144, 84);
            button2.TabIndex = 1;
            button2.Text = "เปิดไฟ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // button3
            // 
            button3.Location = new Point(637, 139);
            button3.Name = "button3";
            button3.Size = new Size(139, 89);
            button3.TabIndex = 2;
            button3.Text = "ปิดไฟ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(75, 49);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(503, 179);
            label1.TabIndex = 3;
            label1.Text = "มหาลัยราชภัฏอุดรธานี";
            label1.Click += มหาวิทยาลัยราชภัฏอุดร;
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 351);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 67);
            textBox1.TabIndex = 4;
            textBox1.Text = "ควยยยยยยยยยยยย";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "windowfromcontrol";
            FormClosing += Form1_FormClosing;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
    }
}
