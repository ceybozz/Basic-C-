namespace Nostalgic_Songs
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.songButton = new System.Windows.Forms.Button();
            this.artistButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(81, 93);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(622, 64);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songButton
            // 
            this.songButton.Location = new System.Drawing.Point(81, 160);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(299, 53);
            this.songButton.TabIndex = 1;
            this.songButton.Text = "Song";
            this.songButton.UseVisualStyleBackColor = true;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // artistButton
            // 
            this.artistButton.Location = new System.Drawing.Point(386, 160);
            this.artistButton.Name = "artistButton";
            this.artistButton.Size = new System.Drawing.Size(317, 53);
            this.artistButton.TabIndex = 2;
            this.artistButton.Text = "Artist";
            this.artistButton.UseVisualStyleBackColor = true;
            this.artistButton.Click += new System.EventHandler(this.artistButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(81, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(622, 53);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.artistButton);
            this.Controls.Add(this.songButton);
            this.Controls.Add(this.displayLabel);
            this.Name = "Form1";
            this.Text = "Nostalgic Songs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button songButton;
        private System.Windows.Forms.Button artistButton;
        private System.Windows.Forms.Button exitButton;
    }
}

