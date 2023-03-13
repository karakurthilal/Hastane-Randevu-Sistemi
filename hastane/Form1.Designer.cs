namespace hastane
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
            this.btsonuc = new System.Windows.Forms.Button();
            this.btrandevu = new System.Windows.Forms.Button();
            this.bthasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btsonuc
            // 
            this.btsonuc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btsonuc.Location = new System.Drawing.Point(440, 155);
            this.btsonuc.Name = "btsonuc";
            this.btsonuc.Size = new System.Drawing.Size(154, 80);
            this.btsonuc.TabIndex = 7;
            this.btsonuc.Text = "Sonuç Görüntüleme";
            this.btsonuc.UseVisualStyleBackColor = true;
            this.btsonuc.Click += new System.EventHandler(this.btsonuc_Click);
            // 
            // btrandevu
            // 
            this.btrandevu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btrandevu.Location = new System.Drawing.Point(248, 155);
            this.btrandevu.Name = "btrandevu";
            this.btrandevu.Size = new System.Drawing.Size(154, 80);
            this.btrandevu.TabIndex = 6;
            this.btrandevu.Text = "Hastane Randevusu";
            this.btrandevu.UseVisualStyleBackColor = true;
            this.btrandevu.Click += new System.EventHandler(this.btrandevu_Click);
            // 
            // bthasta
            // 
            this.bthasta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bthasta.Location = new System.Drawing.Point(58, 155);
            this.bthasta.Name = "bthasta";
            this.bthasta.Size = new System.Drawing.Size(153, 80);
            this.bthasta.TabIndex = 5;
            this.bthasta.Text = "Hasta Bilgileri\r\n";
            this.bthasta.UseVisualStyleBackColor = true;
            this.bthasta.Click += new System.EventHandler(this.bthasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = " HASTANE RANDEVU SİSTEMİ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(572, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "KAPAT X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btsonuc);
            this.Controls.Add(this.btrandevu);
            this.Controls.Add(this.bthasta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hastane Randevu Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsonuc;
        private System.Windows.Forms.Button btrandevu;
        private System.Windows.Forms.Button bthasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

