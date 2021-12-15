
namespace Döviz_Ofisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnDolarAlis = new System.Windows.Forms.Button();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtToplam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.BtnDolarSatis = new System.Windows.Forms.Button();
            this.BtnEuroAlis = new System.Windows.Forms.Button();
            this.BtnEuroSatis = new System.Windows.Forms.Button();
            this.BtnSatisYap2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarAlis.ForeColor = System.Drawing.Color.White;
            this.LblDolarAlis.Location = new System.Drawing.Point(140, 28);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(22, 24);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dolar Satış:";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSatis.ForeColor = System.Drawing.Color.White;
            this.LblDolarSatis.Location = new System.Drawing.Point(140, 75);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(22, 24);
            this.LblDolarSatis.TabIndex = 3;
            this.LblDolarSatis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Alış:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Euro Satış:";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroAlis.ForeColor = System.Drawing.Color.White;
            this.LblEuroAlis.Location = new System.Drawing.Point(134, 125);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(22, 24);
            this.LblEuroAlis.TabIndex = 6;
            this.LblEuroAlis.Text = "0";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSatis.ForeColor = System.Drawing.Color.White;
            this.LblEuroSatis.Location = new System.Drawing.Point(140, 175);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(22, 24);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kur:";
            // 
            // BtnDolarAlis
            // 
            this.BtnDolarAlis.Location = new System.Drawing.Point(187, 24);
            this.BtnDolarAlis.Name = "BtnDolarAlis";
            this.BtnDolarAlis.Size = new System.Drawing.Size(34, 33);
            this.BtnDolarAlis.TabIndex = 9;
            this.BtnDolarAlis.Text = "...";
            this.BtnDolarAlis.UseVisualStyleBackColor = true;
            this.BtnDolarAlis.Click += new System.EventHandler(this.BtnDolarAlis_Click);
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(73, 20);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(213, 30);
            this.TxtKur.TabIndex = 10;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnSatisYap2);
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtToplam);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(417, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 276);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.ForeColor = System.Drawing.Color.Black;
            this.BtnSatisYap.Location = new System.Drawing.Point(100, 227);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(113, 33);
            this.BtnSatisYap.TabIndex = 17;
            this.BtnSatisYap.Text = "İşlem 1";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kalan:";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(100, 178);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(211, 30);
            this.TxtKalan.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Toplam:";
            // 
            // TxtToplam
            // 
            this.TxtToplam.Location = new System.Drawing.Point(100, 126);
            this.TxtToplam.Name = "TxtToplam";
            this.TxtToplam.Size = new System.Drawing.Size(211, 30);
            this.TxtToplam.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Miktar:";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(100, 72);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(211, 30);
            this.TxtMiktar.TabIndex = 12;
            // 
            // BtnDolarSatis
            // 
            this.BtnDolarSatis.Location = new System.Drawing.Point(187, 71);
            this.BtnDolarSatis.Name = "BtnDolarSatis";
            this.BtnDolarSatis.Size = new System.Drawing.Size(34, 33);
            this.BtnDolarSatis.TabIndex = 13;
            this.BtnDolarSatis.Text = "...";
            this.BtnDolarSatis.UseVisualStyleBackColor = true;
            this.BtnDolarSatis.Click += new System.EventHandler(this.BtnDolarSatis_Click);
            // 
            // BtnEuroAlis
            // 
            this.BtnEuroAlis.Location = new System.Drawing.Point(187, 121);
            this.BtnEuroAlis.Name = "BtnEuroAlis";
            this.BtnEuroAlis.Size = new System.Drawing.Size(34, 33);
            this.BtnEuroAlis.TabIndex = 14;
            this.BtnEuroAlis.Text = "...";
            this.BtnEuroAlis.UseVisualStyleBackColor = true;
            this.BtnEuroAlis.Click += new System.EventHandler(this.BtnEuroAlis_Click);
            // 
            // BtnEuroSatis
            // 
            this.BtnEuroSatis.Location = new System.Drawing.Point(187, 171);
            this.BtnEuroSatis.Name = "BtnEuroSatis";
            this.BtnEuroSatis.Size = new System.Drawing.Size(34, 33);
            this.BtnEuroSatis.TabIndex = 15;
            this.BtnEuroSatis.Text = "...";
            this.BtnEuroSatis.UseVisualStyleBackColor = true;
            this.BtnEuroSatis.Click += new System.EventHandler(this.BtnEuroSatis_Click);
            // 
            // BtnSatisYap2
            // 
            this.BtnSatisYap2.ForeColor = System.Drawing.Color.Black;
            this.BtnSatisYap2.Location = new System.Drawing.Point(229, 227);
            this.BtnSatisYap2.Name = "BtnSatisYap2";
            this.BtnSatisYap2.Size = new System.Drawing.Size(113, 33);
            this.BtnSatisYap2.TabIndex = 18;
            this.BtnSatisYap2.Text = "İşlem 2";
            this.BtnSatisYap2.UseVisualStyleBackColor = true;
            this.BtnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Döviz_Ofisi.Properties.Resources.wp2300372;
            this.ClientSize = new System.Drawing.Size(1134, 485);
            this.Controls.Add(this.BtnEuroSatis);
            this.Controls.Add(this.BtnEuroAlis);
            this.Controls.Add(this.BtnDolarSatis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDolarAlis);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Döviz 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnDolarAlis;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Button BtnDolarSatis;
        private System.Windows.Forms.Button BtnEuroAlis;
        private System.Windows.Forms.Button BtnEuroSatis;
        private System.Windows.Forms.Button BtnSatisYap2;
    }
}

