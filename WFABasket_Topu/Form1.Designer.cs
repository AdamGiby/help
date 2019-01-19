namespace WFABasket_Topu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrTop = new System.Windows.Forms.Timer(this.components);
            this.pbBasketTopu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasketTopu)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTop
            // 
            this.tmrTop.Enabled = true;
            this.tmrTop.Interval = 1000;
            this.tmrTop.Tick += new System.EventHandler(this.tmrTop_Tick);
            // 
            // pbBasketTopu
            // 
            this.pbBasketTopu.Image = ((System.Drawing.Image)(resources.GetObject("pbBasketTopu.Image")));
            this.pbBasketTopu.Location = new System.Drawing.Point(99, 75);
            this.pbBasketTopu.Name = "pbBasketTopu";
            this.pbBasketTopu.Size = new System.Drawing.Size(182, 150);
            this.pbBasketTopu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBasketTopu.TabIndex = 0;
            this.pbBasketTopu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 844);
            this.Controls.Add(this.pbBasketTopu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBasketTopu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTop;
        private System.Windows.Forms.PictureBox pbBasketTopu;
    }
}

