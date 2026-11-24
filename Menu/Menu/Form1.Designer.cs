namespace Menu
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 2;
            label1.Text = "選擇內用或是外帶，開始點餐";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 79);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 286);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(247, 374);
            button1.Name = "button1";
            button1.Size = new Size(83, 37);
            button1.TabIndex = 4;
            button1.Text = "結束";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(346, 374);
            button2.Name = "button2";
            button2.Size = new Size(83, 37);
            button2.TabIndex = 8;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.burger;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button4.Location = new Point(480, 237);
            button4.Name = "button4";
            button4.Size = new Size(177, 156);
            button4.TabIndex = 10;
            button4.Text = "外帶";
            button4.TextAlign = ContentAlignment.BottomRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.fast_food;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(480, 60);
            button3.Name = "button3";
            button3.Size = new Size(177, 156);
            button3.TabIndex = 11;
            button3.Text = "內用";
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "點餐";
            Activated += Form1_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
    }
}
