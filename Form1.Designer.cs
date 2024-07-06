namespace MyPhotos
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GalleryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EffectsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.CenterImg = new System.Windows.Forms.Button();
            this.ZoomSub = new System.Windows.Forms.Button();
            this.ZoomAdd = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.EffectsPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GalleryPanel
            // 
            this.GalleryPanel.AutoScroll = true;
            this.GalleryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GalleryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GalleryPanel.Location = new System.Drawing.Point(911, 0);
            this.GalleryPanel.Name = "GalleryPanel";
            this.GalleryPanel.Size = new System.Drawing.Size(180, 576);
            this.GalleryPanel.TabIndex = 4;
            // 
            // EffectsPanel
            // 
            this.EffectsPanel.AutoScroll = true;
            this.EffectsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EffectsPanel.Controls.Add(this.button1);
            this.EffectsPanel.Controls.Add(this.button2);
            this.EffectsPanel.Controls.Add(this.button3);
            this.EffectsPanel.Controls.Add(this.button4);
            this.EffectsPanel.Controls.Add(this.button5);
            this.EffectsPanel.Controls.Add(this.button6);
            this.EffectsPanel.Controls.Add(this.button7);
            this.EffectsPanel.Controls.Add(this.button8);
            this.EffectsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EffectsPanel.Location = new System.Drawing.Point(0, 0);
            this.EffectsPanel.Name = "EffectsPanel";
            this.EffectsPanel.Size = new System.Drawing.Size(215, 576);
            this.EffectsPanel.TabIndex = 4;
            // 
            // PicturePanel
            // 
            this.PicturePanel.Controls.Add(this.CenterImg);
            this.PicturePanel.Controls.Add(this.ZoomSub);
            this.PicturePanel.Controls.Add(this.ZoomAdd);
            this.PicturePanel.Controls.Add(this.ImageBox);
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturePanel.Location = new System.Drawing.Point(215, 0);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(696, 576);
            this.PicturePanel.TabIndex = 5;
            // 
            // CenterImg
            // 
            this.CenterImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterImg.Location = new System.Drawing.Point(582, 545);
            this.CenterImg.Name = "CenterImg";
            this.CenterImg.Size = new System.Drawing.Size(32, 28);
            this.CenterImg.TabIndex = 3;
            this.CenterImg.Text = "C";
            this.CenterImg.UseVisualStyleBackColor = true;
            this.CenterImg.Click += new System.EventHandler(this.CenterImg_Click);
            // 
            // ZoomSub
            // 
            this.ZoomSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomSub.Location = new System.Drawing.Point(620, 545);
            this.ZoomSub.Name = "ZoomSub";
            this.ZoomSub.Size = new System.Drawing.Size(32, 28);
            this.ZoomSub.TabIndex = 2;
            this.ZoomSub.Text = "-";
            this.ZoomSub.UseVisualStyleBackColor = true;
            this.ZoomSub.Click += new System.EventHandler(this.ZoomSub_Click);
            // 
            // ZoomAdd
            // 
            this.ZoomAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomAdd.Location = new System.Drawing.Point(658, 545);
            this.ZoomAdd.Name = "ZoomAdd";
            this.ZoomAdd.Size = new System.Drawing.Size(32, 28);
            this.ZoomAdd.TabIndex = 0;
            this.ZoomAdd.Text = "+";
            this.ZoomAdd.UseVisualStyleBackColor = true;
            this.ZoomAdd.Click += new System.EventHandler(this.ZoomAdd_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageBox.Location = new System.Drawing.Point(-612, -252);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(2716, 1810);
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            this.ImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseButtonDown);
            this.ImageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoving);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "8bpp Grayscale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(145, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "1bpp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(3, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "4bpp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Location = new System.Drawing.Point(66, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "8bpp";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Location = new System.Drawing.Point(3, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "16bpp + Alpha";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Location = new System.Drawing.Point(134, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "24bpp";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Location = new System.Drawing.Point(3, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "32bpp";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Location = new System.Drawing.Point(74, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "Sepia";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1091, 576);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.GalleryPanel);
            this.Controls.Add(this.EffectsPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MyPhotos";
            this.EffectsPanel.ResumeLayout(false);
            this.EffectsPanel.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GalleryPanel;
        private System.Windows.Forms.FlowLayoutPanel EffectsPanel;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button ZoomSub;
        private System.Windows.Forms.Button ZoomAdd;
        private System.Windows.Forms.Button CenterImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

