
namespace Timer
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.milisec = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.dk = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // milisec
            // 
            this.milisec.AutoSize = true;
            this.milisec.Location = new System.Drawing.Point(118, 9);
            this.milisec.Name = "milisec";
            this.milisec.Size = new System.Drawing.Size(32, 17);
            this.milisec.TabIndex = 1;
            this.milisec.Text = "000";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Location = new System.Drawing.Point(96, 9);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(16, 17);
            this.sec.TabIndex = 2;
            this.sec.Text = "0";
            // 
            // dk
            // 
            this.dk.AutoSize = true;
            this.dk.Location = new System.Drawing.Point(74, 9);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(16, 17);
            this.dk.TabIndex = 3;
            this.dk.Text = "0";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(52, 9);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(16, 17);
            this.hour.TabIndex = 4;
            this.hour.Text = "0";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(30, 9);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(16, 17);
            this.day.TabIndex = 5;
            this.day.Text = "0";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(8, 9);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(16, 17);
            this.year.TabIndex = 6;
            this.year.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 99);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.year);
            this.Controls.Add(this.day);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.milisec);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label milisec;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label dk;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Button button2;
    }
}

