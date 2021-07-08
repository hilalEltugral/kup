namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.OpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OpenGlControl1
            // 
            this.OpenGlControl1.AccumBits = ((byte)(0));
            this.OpenGlControl1.AutoCheckErrors = false;
            this.OpenGlControl1.AutoFinish = false;
            this.OpenGlControl1.AutoMakeCurrent = true;
            this.OpenGlControl1.AutoSwapBuffers = true;
            this.OpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl1.ColorBits = ((byte)(32));
            this.OpenGlControl1.DepthBits = ((byte)(16));
            this.OpenGlControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenGlControl1.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenGlControl1.Name = "OpenGlControl1";
            this.OpenGlControl1.Size = new System.Drawing.Size(310, 373);
            this.OpenGlControl1.StencilBits = ((byte)(0));
            this.OpenGlControl1.TabIndex = 0;
            this.OpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGlControl1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simülasyonu Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpenGlControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenGlControl1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

