namespace WinForms.KeyboardAndMouseEvent
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
            lblResult = new Label();
            txtinput = new TextBox();
            label1 = new Label();
            txtPress = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(0, -1);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(47, 20);
            lblResult.TabIndex = 0;
            lblResult.Text = "-* * *-";
            // 
            // txtinput
            // 
            txtinput.Location = new Point(515, 84);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(125, 27);
            txtinput.TabIndex = 1;
            txtinput.KeyPress += txtinput_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 61);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "ตัวเลข";
            // 
            // txtPress
            // 
            txtPress.Location = new Point(515, 206);
            txtPress.Name = "txtPress";
            txtPress.Size = new Size(125, 27);
            txtPress.TabIndex = 3;
            txtPress.KeyPress += txtPress_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 183);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "ตัวอักษร";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 426);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 5;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 403);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 6;
            label3.Text = "ตัวอักษรไม่เกิน20 ห้ามใส่ตัวเลข";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 831);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtPress);
            Controls.Add(label1);
            Controls.Add(txtinput);
            Controls.Add(lblResult);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtinput;
        private Label label1;
        private TextBox txtPress;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}
