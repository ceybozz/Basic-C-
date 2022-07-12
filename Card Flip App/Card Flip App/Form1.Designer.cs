namespace Card_Flip_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxFront = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFrontButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(91, 34);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(52, 72);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Visible = false;
            // 
            // pictureBoxFront
            // 
            this.pictureBoxFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFront.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFront.Image")));
            this.pictureBoxFront.Location = new System.Drawing.Point(265, 34);
            this.pictureBoxFront.Name = "pictureBoxFront";
            this.pictureBoxFront.Size = new System.Drawing.Size(52, 72);
            this.pictureBoxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFront.TabIndex = 1;
            this.pictureBoxFront.TabStop = false;
            this.pictureBoxFront.Visible = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(28, 175);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(171, 48);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "Show back";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFrontButton
            // 
            this.showFrontButton.Location = new System.Drawing.Point(205, 175);
            this.showFrontButton.Name = "showFrontButton";
            this.showFrontButton.Size = new System.Drawing.Size(171, 48);
            this.showFrontButton.TabIndex = 3;
            this.showFrontButton.Text = "Show Front";
            this.showFrontButton.UseVisualStyleBackColor = true;
            this.showFrontButton.Click += new System.EventHandler(this.showFrontButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.showFrontButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.pictureBoxFront);
            this.Controls.Add(this.pictureBoxBack);
            this.Name = "Form1";
            this.Text = "Flip Card";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxFront;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFrontButton;
    }
}

