namespace Menu
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 26);
            label1.TabIndex = 0;
            label1.Text = "主餐";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(54, 101);
            label2.Name = "label2";
            label2.Size = new Size(54, 26);
            label2.TabIndex = 1;
            label2.Text = "單點";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Big Mac", "Quarter Pounder with Cheese", "Double Cheeseburger", "McChicken", "Filet-O-Fish" });
            comboBox1.Location = new Point(134, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "World Famous Fries(S)", "Chicken McNuggets(4)", "Chicken McNuggets(6)", "Chicken McNuggets(10)", "Chicken McNuggets(20)" });
            comboBox2.Location = new Point(134, 98);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 28);
            comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(114, 162);
            button1.Name = "button1";
            button1.Size = new Size(87, 32);
            button1.TabIndex = 4;
            button1.Text = "下一步";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 231);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "點餐";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}