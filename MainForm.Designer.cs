namespace Calculator
{
    partial class Calculator
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
            this.txt_display = new System.Windows.Forms.TextBox();
            this.txt_field = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_fraction = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_display
            // 
            this.txt_display.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_display.Location = new System.Drawing.Point(12, 25);
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(362, 40);
            this.txt_display.TabIndex = 0;
            this.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_display.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_field
            // 
            this.txt_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_field.Location = new System.Drawing.Point(12, 71);
            this.txt_field.Name = "txt_field";
            this.txt_field.Size = new System.Drawing.Size(362, 45);
            this.txt_field.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btn_fraction
            // 
            this.btn_fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_fraction.Location = new System.Drawing.Point(16, 123);
            this.btn_fraction.Name = "btn_fraction";
            this.btn_fraction.Size = new System.Drawing.Size(85, 65);
            this.btn_fraction.TabIndex = 10;
            this.btn_fraction.Text = "F";
            this.btn_fraction.UseVisualStyleBackColor = true;
            this.btn_fraction.Click += new System.EventHandler(this.btn_fraction_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_result.Location = new System.Drawing.Point(107, 407);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(176, 65);
            this.btn_result.TabIndex = 14;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_right.Location = new System.Drawing.Point(107, 123);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(85, 65);
            this.btn_right.TabIndex = 15;
            this.btn_right.Text = "R";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.Location = new System.Drawing.Point(198, 123);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 65);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_off
            // 
            this.btn_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_off.Location = new System.Drawing.Point(289, 123);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(85, 65);
            this.btn_off.TabIndex = 17;
            this.btn_off.Text = "Off";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_divide.Location = new System.Drawing.Point(289, 194);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(85, 65);
            this.btn_divide.TabIndex = 18;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_multiply.Location = new System.Drawing.Point(289, 265);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(85, 65);
            this.btn_multiply.TabIndex = 19;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minus.Location = new System.Drawing.Point(289, 336);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(85, 65);
            this.btn_minus.TabIndex = 20;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.Location = new System.Drawing.Point(289, 407);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(85, 65);
            this.btn_plus.TabIndex = 21;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_9.Location = new System.Drawing.Point(198, 194);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(85, 65);
            this.btn_9.TabIndex = 22;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_6.Location = new System.Drawing.Point(198, 265);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(85, 65);
            this.btn_6.TabIndex = 23;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_3.Location = new System.Drawing.Point(198, 336);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(85, 65);
            this.btn_3.TabIndex = 24;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8.Location = new System.Drawing.Point(107, 194);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(85, 65);
            this.btn_8.TabIndex = 25;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_7.Location = new System.Drawing.Point(16, 194);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(85, 65);
            this.btn_7.TabIndex = 26;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_5.Location = new System.Drawing.Point(107, 265);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(85, 65);
            this.btn_5.TabIndex = 27;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_4.Location = new System.Drawing.Point(16, 265);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(85, 65);
            this.btn_4.TabIndex = 28;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_2.Location = new System.Drawing.Point(107, 336);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(85, 65);
            this.btn_2.TabIndex = 29;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_1.Location = new System.Drawing.Point(16, 336);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(85, 65);
            this.btn_1.TabIndex = 30;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_0.Location = new System.Drawing.Point(16, 407);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(85, 65);
            this.btn_0.TabIndex = 31;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 492);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_fraction);
            this.Controls.Add(this.txt_field);
            this.Controls.Add(this.txt_display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.TextBox txt_field;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_fraction;
    }
}

