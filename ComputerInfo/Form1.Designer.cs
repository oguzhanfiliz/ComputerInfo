
namespace ComputerInfo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RamSizeLabel = new System.Windows.Forms.Label();
            this.HddSize = new System.Windows.Forms.Label();
            this.MotherboardMaker = new System.Windows.Forms.Label();
            this.MotherboardSerial = new System.Windows.Forms.Label();
            this.GpuName = new System.Windows.Forms.Label();
            this.Cpu = new System.Windows.Forms.Label();
            this.OperatingSystem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.monitor = new System.Windows.Forms.Label();
            this.monitorinf = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bilgileri Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Donanım bilgileri";
            // 
            // RamSizeLabel
            // 
            this.RamSizeLabel.AutoSize = true;
            this.RamSizeLabel.Location = new System.Drawing.Point(192, 83);
            this.RamSizeLabel.Name = "RamSizeLabel";
            this.RamSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.RamSizeLabel.TabIndex = 8;
            this.RamSizeLabel.Text = "Ram Boyutu";
            // 
            // HddSize
            // 
            this.HddSize.AutoSize = true;
            this.HddSize.Location = new System.Drawing.Point(192, 112);
            this.HddSize.Name = "HddSize";
            this.HddSize.Size = new System.Drawing.Size(90, 13);
            this.HddSize.TabIndex = 10;
            this.HddSize.Text = "Hard Disk Boyutu";
            // 
            // MotherboardMaker
            // 
            this.MotherboardMaker.AutoSize = true;
            this.MotherboardMaker.Location = new System.Drawing.Point(192, 140);
            this.MotherboardMaker.Name = "MotherboardMaker";
            this.MotherboardMaker.Size = new System.Drawing.Size(84, 13);
            this.MotherboardMaker.TabIndex = 12;
            this.MotherboardMaker.Text = "Anakart Üreticisi";
            // 
            // MotherboardSerial
            // 
            this.MotherboardSerial.AutoSize = true;
            this.MotherboardSerial.Location = new System.Drawing.Point(192, 172);
            this.MotherboardSerial.Name = "MotherboardSerial";
            this.MotherboardSerial.Size = new System.Drawing.Size(72, 13);
            this.MotherboardSerial.TabIndex = 13;
            this.MotherboardSerial.Text = "Anakart Serisi";
            // 
            // GpuName
            // 
            this.GpuName.AutoSize = true;
            this.GpuName.Location = new System.Drawing.Point(192, 206);
            this.GpuName.Name = "GpuName";
            this.GpuName.Size = new System.Drawing.Size(59, 13);
            this.GpuName.TabIndex = 14;
            this.GpuName.Text = "Ekran Kartı";
            // 
            // Cpu
            // 
            this.Cpu.AutoSize = true;
            this.Cpu.Location = new System.Drawing.Point(192, 230);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(74, 13);
            this.Cpu.TabIndex = 15;
            this.Cpu.Text = "İşlemci Bilgileri";
            // 
            // OperatingSystem
            // 
            this.OperatingSystem.AutoSize = true;
            this.OperatingSystem.Location = new System.Drawing.Point(192, 254);
            this.OperatingSystem.Name = "OperatingSystem";
            this.OperatingSystem.Size = new System.Drawing.Size(72, 13);
            this.OperatingSystem.TabIndex = 16;
            this.OperatingSystem.Text = "İşletim Sistemi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ram Boyutu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anakart Üreticisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anakart Serisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ekran Kartı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "İşlemci Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "İşletim Sistemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1289, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ekran Kartı";
            // 
            // monitor
            // 
            this.monitor.AutoSize = true;
            this.monitor.Location = new System.Drawing.Point(376, 53);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(77, 13);
            this.monitor.TabIndex = 19;
            this.monitor.Text = "Monitör Bilgileri";
            // 
            // monitorinf
            // 
            this.monitorinf.AutoSize = true;
            this.monitorinf.Location = new System.Drawing.Point(809, 64);
            this.monitorinf.Name = "monitorinf";
            this.monitorinf.Size = new System.Drawing.Size(72, 13);
            this.monitorinf.TabIndex = 20;
            this.monitorinf.Text = "Monitör Sayısı";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 455);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1289, 195);
            this.dataGridView2.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(479, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(809, 121);
            this.listBox1.TabIndex = 22;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(479, 180);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(809, 121);
            this.listBox2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 662);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.monitorinf);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OperatingSystem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GpuName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MotherboardSerial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MotherboardMaker);
            this.Controls.Add(this.HddSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RamSizeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Donanım Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RamSizeLabel;
        private System.Windows.Forms.Label HddSize;
        private System.Windows.Forms.Label MotherboardMaker;
        private System.Windows.Forms.Label MotherboardSerial;
        private System.Windows.Forms.Label GpuName;
        private System.Windows.Forms.Label Cpu;
        private System.Windows.Forms.Label OperatingSystem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label monitor;
        private System.Windows.Forms.Label monitorinf;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

