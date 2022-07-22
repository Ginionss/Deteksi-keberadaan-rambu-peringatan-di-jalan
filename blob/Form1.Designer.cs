namespace kuning
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_ukuranAsli = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.detectionButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.red_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.green_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blue_textBox = new System.Windows.Forms.TextBox();
            this.red_textBox1 = new System.Windows.Forms.TextBox();
            this.green_textBox1 = new System.Windows.Forms.TextBox();
            this.blue_textBox1 = new System.Windows.Forms.TextBox();
            this.button_rotate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lb_ukuranAsli);
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Image";
            // 
            // lb_ukuranAsli
            // 
            this.lb_ukuranAsli.AutoSize = true;
            this.lb_ukuranAsli.Location = new System.Drawing.Point(98, 3);
            this.lb_ukuranAsli.Name = "lb_ukuranAsli";
            this.lb_ukuranAsli.Size = new System.Drawing.Size(10, 13);
            this.lb_ukuranAsli.TabIndex = 28;
            this.lb_ukuranAsli.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(17, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(531, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "jumlah corner";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X-Y";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "rambu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(17, 12);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(80, 23);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Pilih File";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(525, 225);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // detectionButton
            // 
            this.detectionButton.Location = new System.Drawing.Point(190, 12);
            this.detectionButton.Name = "detectionButton";
            this.detectionButton.Size = new System.Drawing.Size(80, 23);
            this.detectionButton.TabIndex = 8;
            this.detectionButton.Text = "Deteksi";
            this.detectionButton.UseVisualStyleBackColor = true;
            this.detectionButton.Click += new System.EventHandler(this.detectionButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Location = new System.Drawing.Point(640, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 250);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deteksi objek ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Location = new System.Drawing.Point(640, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(537, 250);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crop";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 225);
            this.panel1.TabIndex = 0;
            // 
            // red_textBox
            // 
            this.red_textBox.Enabled = false;
            this.red_textBox.Location = new System.Drawing.Point(70, 304);
            this.red_textBox.Name = "red_textBox";
            this.red_textBox.Size = new System.Drawing.Size(29, 20);
            this.red_textBox.TabIndex = 16;
            this.red_textBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "R : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "G : ";
            // 
            // green_textBox
            // 
            this.green_textBox.Enabled = false;
            this.green_textBox.Location = new System.Drawing.Point(190, 304);
            this.green_textBox.Name = "green_textBox";
            this.green_textBox.Size = new System.Drawing.Size(29, 20);
            this.green_textBox.TabIndex = 18;
            this.green_textBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "B : ";
            // 
            // blue_textBox
            // 
            this.blue_textBox.Enabled = false;
            this.blue_textBox.Location = new System.Drawing.Point(311, 304);
            this.blue_textBox.Name = "blue_textBox";
            this.blue_textBox.Size = new System.Drawing.Size(29, 20);
            this.blue_textBox.TabIndex = 20;
            this.blue_textBox.Text = "0";
            // 
            // red_textBox1
            // 
            this.red_textBox1.Enabled = false;
            this.red_textBox1.Location = new System.Drawing.Point(109, 304);
            this.red_textBox1.Name = "red_textBox1";
            this.red_textBox1.Size = new System.Drawing.Size(29, 20);
            this.red_textBox1.TabIndex = 25;
            this.red_textBox1.Text = "0";
            // 
            // green_textBox1
            // 
            this.green_textBox1.Enabled = false;
            this.green_textBox1.Location = new System.Drawing.Point(234, 304);
            this.green_textBox1.Name = "green_textBox1";
            this.green_textBox1.Size = new System.Drawing.Size(29, 20);
            this.green_textBox1.TabIndex = 26;
            this.green_textBox1.Text = "0";
            // 
            // blue_textBox1
            // 
            this.blue_textBox1.Enabled = false;
            this.blue_textBox1.Location = new System.Drawing.Point(361, 304);
            this.blue_textBox1.Name = "blue_textBox1";
            this.blue_textBox1.Size = new System.Drawing.Size(29, 20);
            this.blue_textBox1.TabIndex = 27;
            this.blue_textBox1.Text = "0";
            // 
            // button_rotate
            // 
            this.button_rotate.Location = new System.Drawing.Point(103, 12);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(80, 23);
            this.button_rotate.TabIndex = 28;
            this.button_rotate.Text = "Rotate";
            this.button_rotate.UseVisualStyleBackColor = true;
            this.button_rotate.Click += new System.EventHandler(this.button_rotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 633);
            this.Controls.Add(this.button_rotate);
            this.Controls.Add(this.blue_textBox1);
            this.Controls.Add(this.green_textBox1);
            this.Controls.Add(this.red_textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blue_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.green_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.red_textBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.detectionButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deteksi rambu peringatan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button detectionButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox red_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox green_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox blue_textBox;
        private System.Windows.Forms.TextBox red_textBox1;
        private System.Windows.Forms.TextBox green_textBox1;
        private System.Windows.Forms.TextBox blue_textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lb_ukuranAsli;
        private System.Windows.Forms.Button button_rotate;
    }
}

