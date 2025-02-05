namespace Area_or_volume_counter
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
            this.radioButton2D = new System.Windows.Forms.RadioButton();
            this.radioButton3D = new System.Windows.Forms.RadioButton();
            this.comboBox2D = new System.Windows.Forms.ComboBox();
            this.comboBox3D = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton2D
            // 
            this.radioButton2D.AutoSize = true;
            this.radioButton2D.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton2D.Location = new System.Drawing.Point(253, 53);
            this.radioButton2D.Name = "radioButton2D";
            this.radioButton2D.Size = new System.Drawing.Size(93, 17);
            this.radioButton2D.TabIndex = 0;
            this.radioButton2D.TabStop = true;
            this.radioButton2D.Text = "radioButton2D";
            this.radioButton2D.UseVisualStyleBackColor = true;
            this.radioButton2D.CheckedChanged += new System.EventHandler(this.radioButton2D_CheckedChanged);
            // 
            // radioButton3D
            // 
            this.radioButton3D.AutoSize = true;
            this.radioButton3D.Location = new System.Drawing.Point(516, 53);
            this.radioButton3D.Name = "radioButton3D";
            this.radioButton3D.Size = new System.Drawing.Size(93, 17);
            this.radioButton3D.TabIndex = 1;
            this.radioButton3D.TabStop = true;
            this.radioButton3D.Text = "radioButton3D";
            this.radioButton3D.UseVisualStyleBackColor = true;
            this.radioButton3D.CheckedChanged += new System.EventHandler(this.radioButton3D_CheckedChanged);
            // 
            // comboBox2D
            // 
            this.comboBox2D.FormattingEnabled = true;
            this.comboBox2D.Location = new System.Drawing.Point(352, 127);
            this.comboBox2D.Name = "comboBox2D";
            this.comboBox2D.Size = new System.Drawing.Size(121, 21);
            this.comboBox2D.TabIndex = 2;
            // 
            // comboBox3D
            // 
            this.comboBox3D.FormattingEnabled = true;
            this.comboBox3D.Location = new System.Drawing.Point(352, 127);
            this.comboBox3D.Name = "comboBox3D";
            this.comboBox3D.Size = new System.Drawing.Size(121, 21);
            this.comboBox3D.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(378, 272);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "button1";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.comboBox3D);
            this.Controls.Add(this.comboBox2D);
            this.Controls.Add(this.radioButton3D);
            this.Controls.Add(this.radioButton2D);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2D;
        private System.Windows.Forms.RadioButton radioButton3D;
        private System.Windows.Forms.ComboBox comboBox2D;
        private System.Windows.Forms.ComboBox comboBox3D;
        private System.Windows.Forms.Button confirmButton;
    }
}

