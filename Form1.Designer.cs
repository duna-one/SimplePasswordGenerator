
namespace SimplePasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlphabetPath_textBox = new System.Windows.Forms.TextBox();
            this.OutputPath_textBox = new System.Windows.Forms.TextBox();
            this.AlphabetPath_Button = new System.Windows.Forms.Button();
            this.OutputPath_Button = new System.Windows.Forms.Button();
            this.isDefaultAlphabetUse = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PassLen_Input = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassLen_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to alphabet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path to output:";
            // 
            // AlphabetPath_textBox
            // 
            this.AlphabetPath_textBox.Enabled = false;
            this.AlphabetPath_textBox.Location = new System.Drawing.Point(106, 13);
            this.AlphabetPath_textBox.Name = "AlphabetPath_textBox";
            this.AlphabetPath_textBox.ReadOnly = true;
            this.AlphabetPath_textBox.Size = new System.Drawing.Size(296, 20);
            this.AlphabetPath_textBox.TabIndex = 2;
            // 
            // OutputPath_textBox
            // 
            this.OutputPath_textBox.Location = new System.Drawing.Point(106, 39);
            this.OutputPath_textBox.Name = "OutputPath_textBox";
            this.OutputPath_textBox.ReadOnly = true;
            this.OutputPath_textBox.Size = new System.Drawing.Size(296, 20);
            this.OutputPath_textBox.TabIndex = 3;
            // 
            // AlphabetPath_Button
            // 
            this.AlphabetPath_Button.Enabled = false;
            this.AlphabetPath_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabetPath_Button.Location = new System.Drawing.Point(405, 13);
            this.AlphabetPath_Button.Margin = new System.Windows.Forms.Padding(0);
            this.AlphabetPath_Button.Name = "AlphabetPath_Button";
            this.AlphabetPath_Button.Size = new System.Drawing.Size(34, 20);
            this.AlphabetPath_Button.TabIndex = 4;
            this.AlphabetPath_Button.Text = "...";
            this.AlphabetPath_Button.UseVisualStyleBackColor = true;
            this.AlphabetPath_Button.Click += new System.EventHandler(this.AlphabetPath_Button_Click);
            // 
            // OutputPath_Button
            // 
            this.OutputPath_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputPath_Button.Location = new System.Drawing.Point(405, 39);
            this.OutputPath_Button.Margin = new System.Windows.Forms.Padding(0);
            this.OutputPath_Button.Name = "OutputPath_Button";
            this.OutputPath_Button.Size = new System.Drawing.Size(34, 20);
            this.OutputPath_Button.TabIndex = 5;
            this.OutputPath_Button.Text = "...";
            this.OutputPath_Button.UseVisualStyleBackColor = true;
            this.OutputPath_Button.Click += new System.EventHandler(this.OutputPath_Button_Click);
            // 
            // isDefaultAlphabetUse
            // 
            this.isDefaultAlphabetUse.AutoSize = true;
            this.isDefaultAlphabetUse.Checked = true;
            this.isDefaultAlphabetUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDefaultAlphabetUse.Location = new System.Drawing.Point(442, 16);
            this.isDefaultAlphabetUse.Name = "isDefaultAlphabetUse";
            this.isDefaultAlphabetUse.Size = new System.Drawing.Size(124, 17);
            this.isDefaultAlphabetUse.TabIndex = 6;
            this.isDefaultAlphabetUse.Text = "Use default alphabet";
            this.isDefaultAlphabetUse.UseVisualStyleBackColor = true;
            this.isDefaultAlphabetUse.CheckedChanged += new System.EventHandler(this.isDefaultAlphabetUse_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(248, 92);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start Magic";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 92);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(561, 23);
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password length:";
            // 
            // PassLen_Input
            // 
            this.PassLen_Input.Location = new System.Drawing.Point(106, 66);
            this.PassLen_Input.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PassLen_Input.Name = "PassLen_Input";
            this.PassLen_Input.Size = new System.Drawing.Size(50, 20);
            this.PassLen_Input.TabIndex = 10;
            this.PassLen_Input.ValueChanged += new System.EventHandler(this.PassLen_Input_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 123);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassLen_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.isDefaultAlphabetUse);
            this.Controls.Add(this.OutputPath_Button);
            this.Controls.Add(this.AlphabetPath_Button);
            this.Controls.Add(this.OutputPath_textBox);
            this.Controls.Add(this.AlphabetPath_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PassLen_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AlphabetPath_textBox;
        private System.Windows.Forms.TextBox OutputPath_textBox;
        private System.Windows.Forms.Button AlphabetPath_Button;
        private System.Windows.Forms.Button OutputPath_Button;
        private System.Windows.Forms.CheckBox isDefaultAlphabetUse;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PassLen_Input;
        private System.Windows.Forms.Label label4;
    }
}

