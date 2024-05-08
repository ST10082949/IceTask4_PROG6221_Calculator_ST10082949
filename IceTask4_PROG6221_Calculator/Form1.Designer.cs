namespace IceTask4_PROG6221_Calculator
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
            lbl_num1 = new Label();
            lbl_num2 = new Label();
            txtbox_num1 = new TextBox();
            txtbox_num2 = new TextBox();
            lbl_result = new Label();
            lbl_ans = new Label();
            btn_add = new Button();
            btn_subtract = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 22);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(107, 102);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(63, 15);
            lbl_num1.TabIndex = 1;
            lbl_num1.Text = "Number 1:";
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Location = new Point(397, 107);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(63, 15);
            lbl_num2.TabIndex = 2;
            lbl_num2.Text = "Number 2:";
            // 
            // txtbox_num1
            // 
            txtbox_num1.Location = new Point(176, 99);
            txtbox_num1.Name = "txtbox_num1";
            txtbox_num1.Size = new Size(100, 23);
            txtbox_num1.TabIndex = 3;
            // 
            // txtbox_num2
            // 
            txtbox_num2.Location = new Point(481, 102);
            txtbox_num2.Name = "txtbox_num2";
            txtbox_num2.Size = new Size(100, 23);
            txtbox_num2.TabIndex = 4;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_result.Location = new Point(258, 176);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(45, 15);
            lbl_result.TabIndex = 5;
            lbl_result.Text = "Result:";
            // 
            // lbl_ans
            // 
            lbl_ans.AutoSize = true;
            lbl_ans.Location = new Point(328, 176);
            lbl_ans.Name = "lbl_ans";
            lbl_ans.Size = new Size(0, 15);
            lbl_ans.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LightCoral;
            btn_add.Location = new Point(146, 245);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(79, 49);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_subtract
            // 
            btn_subtract.BackColor = SystemColors.ActiveCaption;
            btn_subtract.Location = new Point(249, 245);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(79, 49);
            btn_subtract.TabIndex = 8;
            btn_subtract.Text = "Subtract";
            btn_subtract.UseVisualStyleBackColor = false;
            btn_subtract.Click += btn_subtract_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = Color.PaleGreen;
            btn_multiply.Location = new Point(351, 245);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(78, 49);
            btn_multiply.TabIndex = 9;
            btn_multiply.Text = "Multiply";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.NavajoWhite;
            btn_divide.Location = new Point(454, 245);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(75, 49);
            btn_divide.TabIndex = 10;
            btn_divide.Text = "Divide";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.DarkGray;
            btn_clear.Location = new Point(280, 320);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(131, 29);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(707, 444);
            Controls.Add(btn_clear);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_subtract);
            Controls.Add(btn_add);
            Controls.Add(lbl_ans);
            Controls.Add(lbl_result);
            Controls.Add(txtbox_num2);
            Controls.Add(txtbox_num1);
            Controls.Add(lbl_num2);
            Controls.Add(lbl_num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_num1;
        private Label lbl_num2;
        private TextBox txtbox_num1;
        private TextBox txtbox_num2;
        private Label lbl_result;
        private Label lbl_ans;
        private Button btn_add;
        private Button btn_subtract;
        private Button btn_multiply;
        private Button btn_divide;
        private Button btn_clear;
    }
}
