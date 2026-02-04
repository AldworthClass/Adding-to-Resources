namespace Adding_to_Resources
{
    partial class FormAddingResources
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
            this.imgMario = new System.Windows.Forms.PictureBox();
            this.imgSleep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMario
            // 
            this.imgMario.Image = global::Adding_to_Resources.Properties.Resources.MarioSleep;
            this.imgMario.Location = new System.Drawing.Point(12, 12);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(490, 403);
            this.imgMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            this.imgMario.Click += new System.EventHandler(this.imgMario_Click);
            this.imgMario.MouseEnter += new System.EventHandler(this.imgMario_MouseEnter);
            this.imgMario.MouseLeave += new System.EventHandler(this.imgMario_MouseLeave);
            // 
            // imgSleep
            // 
            this.imgSleep.Image = global::Adding_to_Resources.Properties.Resources.SheepSleep;
            this.imgSleep.Location = new System.Drawing.Point(508, 12);
            this.imgSleep.Name = "imgSleep";
            this.imgSleep.Size = new System.Drawing.Size(240, 152);
            this.imgSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSleep.TabIndex = 1;
            this.imgSleep.TabStop = false;
            this.imgSleep.Click += new System.EventHandler(this.imgSleep_Click);
            // 
            // FormAddingResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.imgSleep);
            this.Controls.Add(this.imgMario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormAddingResources";
            this.Text = "Adding Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
        private System.Windows.Forms.PictureBox imgSleep;
    }
}

