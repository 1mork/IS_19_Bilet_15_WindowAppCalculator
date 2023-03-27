namespace IS_19_Bilet_15_WindowAppCalculator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlusPhotoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsliguComboBox = new System.Windows.Forms.ComboBox();
            this.GluhoeRbutton = new System.Windows.Forms.RadioButton();
            this.PovorotnoeRbutton = new System.Windows.Forms.RadioButton();
            this.OtkidnoeRButton = new System.Windows.Forms.RadioButton();
            this.FramuzhnoeRbutton = new System.Windows.Forms.RadioButton();
            this.RazdvizhnoeRbutton = new System.Windows.Forms.RadioButton();
            this.ShirinaTextBox = new System.Windows.Forms.TextBox();
            this.VysotaTextBox = new System.Windows.Forms.TextBox();
            this.RaschetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ControllSumma = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PlusCheckButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(608, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 302);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlusPhotoButton
            // 
            this.PlusPhotoButton.Location = new System.Drawing.Point(707, 334);
            this.PlusPhotoButton.Name = "PlusPhotoButton";
            this.PlusPhotoButton.Size = new System.Drawing.Size(161, 37);
            this.PlusPhotoButton.TabIndex = 1;
            this.PlusPhotoButton.Text = "Добавть фото";
            this.PlusPhotoButton.UseVisualStyleBackColor = true;
            this.PlusPhotoButton.Click += new System.EventHandler(this.PlusPhotoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Услуга";
            // 
            // UsliguComboBox
            // 
            this.UsliguComboBox.FormattingEnabled = true;
            this.UsliguComboBox.Items.AddRange(new object[] {
            "Окна",
            "Балконы",
            "Двери"});
            this.UsliguComboBox.Location = new System.Drawing.Point(31, 64);
            this.UsliguComboBox.Name = "UsliguComboBox";
            this.UsliguComboBox.Size = new System.Drawing.Size(260, 28);
            this.UsliguComboBox.TabIndex = 3;
            // 
            // GluhoeRbutton
            // 
            this.GluhoeRbutton.AutoSize = true;
            this.GluhoeRbutton.Location = new System.Drawing.Point(31, 112);
            this.GluhoeRbutton.Name = "GluhoeRbutton";
            this.GluhoeRbutton.Size = new System.Drawing.Size(85, 24);
            this.GluhoeRbutton.TabIndex = 4;
            this.GluhoeRbutton.TabStop = true;
            this.GluhoeRbutton.Text = "Глухое";
            this.GluhoeRbutton.UseVisualStyleBackColor = true;
            this.GluhoeRbutton.CheckedChanged += new System.EventHandler(this.GluhoeRbutton_CheckedChanged);
            // 
            // PovorotnoeRbutton
            // 
            this.PovorotnoeRbutton.AutoSize = true;
            this.PovorotnoeRbutton.Location = new System.Drawing.Point(31, 154);
            this.PovorotnoeRbutton.Name = "PovorotnoeRbutton";
            this.PovorotnoeRbutton.Size = new System.Drawing.Size(127, 24);
            this.PovorotnoeRbutton.TabIndex = 5;
            this.PovorotnoeRbutton.TabStop = true;
            this.PovorotnoeRbutton.Text = "Поворотное";
            this.PovorotnoeRbutton.UseVisualStyleBackColor = true;
            // 
            // OtkidnoeRButton
            // 
            this.OtkidnoeRButton.AutoSize = true;
            this.OtkidnoeRButton.Location = new System.Drawing.Point(31, 202);
            this.OtkidnoeRButton.Name = "OtkidnoeRButton";
            this.OtkidnoeRButton.Size = new System.Drawing.Size(110, 24);
            this.OtkidnoeRButton.TabIndex = 6;
            this.OtkidnoeRButton.TabStop = true;
            this.OtkidnoeRButton.Text = "Откидное";
            this.OtkidnoeRButton.UseVisualStyleBackColor = true;
            // 
            // FramuzhnoeRbutton
            // 
            this.FramuzhnoeRbutton.AutoSize = true;
            this.FramuzhnoeRbutton.Location = new System.Drawing.Point(31, 243);
            this.FramuzhnoeRbutton.Name = "FramuzhnoeRbutton";
            this.FramuzhnoeRbutton.Size = new System.Drawing.Size(123, 24);
            this.FramuzhnoeRbutton.TabIndex = 7;
            this.FramuzhnoeRbutton.TabStop = true;
            this.FramuzhnoeRbutton.Text = "Фрамужное";
            this.FramuzhnoeRbutton.UseVisualStyleBackColor = true;
            // 
            // RazdvizhnoeRbutton
            // 
            this.RazdvizhnoeRbutton.AutoSize = true;
            this.RazdvizhnoeRbutton.Location = new System.Drawing.Point(31, 290);
            this.RazdvizhnoeRbutton.Name = "RazdvizhnoeRbutton";
            this.RazdvizhnoeRbutton.Size = new System.Drawing.Size(128, 24);
            this.RazdvizhnoeRbutton.TabIndex = 8;
            this.RazdvizhnoeRbutton.TabStop = true;
            this.RazdvizhnoeRbutton.Text = "Раздвижное";
            this.RazdvizhnoeRbutton.UseVisualStyleBackColor = true;
            // 
            // ShirinaTextBox
            // 
            this.ShirinaTextBox.Location = new System.Drawing.Point(129, 359);
            this.ShirinaTextBox.Name = "ShirinaTextBox";
            this.ShirinaTextBox.Size = new System.Drawing.Size(162, 26);
            this.ShirinaTextBox.TabIndex = 9;
            // 
            // VysotaTextBox
            // 
            this.VysotaTextBox.Location = new System.Drawing.Point(129, 406);
            this.VysotaTextBox.Name = "VysotaTextBox";
            this.VysotaTextBox.Size = new System.Drawing.Size(162, 26);
            this.VysotaTextBox.TabIndex = 10;
            // 
            // RaschetButton
            // 
            this.RaschetButton.Location = new System.Drawing.Point(31, 467);
            this.RaschetButton.Name = "RaschetButton";
            this.RaschetButton.Size = new System.Drawing.Size(133, 42);
            this.RaschetButton.TabIndex = 11;
            this.RaschetButton.Text = "Расчет";
            this.RaschetButton.UseVisualStyleBackColor = true;
            this.RaschetButton.Click += new System.EventHandler(this.RaschetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ширина (см)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Высота (см)";
            // 
            // ControllSumma
            // 
            this.ControllSumma.AutoSize = true;
            this.ControllSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControllSumma.Location = new System.Drawing.Point(47, 573);
            this.ControllSumma.Name = "ControllSumma";
            this.ControllSumma.Size = new System.Drawing.Size(162, 25);
            this.ControllSumma.TabIndex = 14;
            this.ControllSumma.Text = "Вывод расчетов";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(31, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 10);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 124);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(31, 659);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 10);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(297, 544);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 125);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(31, 544);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 125);
            this.panel5.TabIndex = 18;
            // 
            // PlusCheckButton
            // 
            this.PlusCheckButton.Location = new System.Drawing.Point(313, 626);
            this.PlusCheckButton.Name = "PlusCheckButton";
            this.PlusCheckButton.Size = new System.Drawing.Size(202, 42);
            this.PlusCheckButton.TabIndex = 19;
            this.PlusCheckButton.Text = "Оформить квитанцию";
            this.PlusCheckButton.UseVisualStyleBackColor = true;
            this.PlusCheckButton.Click += new System.EventHandler(this.PlusCheckButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(340, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 368);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Миниатюра выбранного окна";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PlusCheckButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControllSumma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RaschetButton);
            this.Controls.Add(this.VysotaTextBox);
            this.Controls.Add(this.ShirinaTextBox);
            this.Controls.Add(this.RazdvizhnoeRbutton);
            this.Controls.Add(this.FramuzhnoeRbutton);
            this.Controls.Add(this.OtkidnoeRButton);
            this.Controls.Add(this.PovorotnoeRbutton);
            this.Controls.Add(this.GluhoeRbutton);
            this.Controls.Add(this.UsliguComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlusPhotoButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlusPhotoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UsliguComboBox;
        private System.Windows.Forms.RadioButton GluhoeRbutton;
        private System.Windows.Forms.RadioButton PovorotnoeRbutton;
        private System.Windows.Forms.RadioButton OtkidnoeRButton;
        private System.Windows.Forms.RadioButton FramuzhnoeRbutton;
        private System.Windows.Forms.RadioButton RazdvizhnoeRbutton;
        private System.Windows.Forms.TextBox ShirinaTextBox;
        private System.Windows.Forms.TextBox VysotaTextBox;
        private System.Windows.Forms.Button RaschetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ControllSumma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button PlusCheckButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}

