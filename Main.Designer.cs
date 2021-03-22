namespace Focus
{
    partial class Zoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zoom));
            this.ActualZoom = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ActualZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // ActualZoom
            // 
            this.ActualZoom.BackColor = System.Drawing.Color.Transparent;
            this.ActualZoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ActualZoom.BackgroundImage")));
            this.ActualZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ActualZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActualZoom.Location = new System.Drawing.Point(0, 0);
            this.ActualZoom.Name = "ActualZoom";
            this.ActualZoom.Size = new System.Drawing.Size(800, 450);
            this.ActualZoom.TabIndex = 0;
            this.ActualZoom.TabStop = false;
            // 
            // Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActualZoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Zoom";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.Zoom_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Zoom_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ActualZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ActualZoom;
        private System.Windows.Forms.Timer timer1;
    }
}

