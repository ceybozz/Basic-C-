namespace Books_and_Authors_App
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
            this.goneWindLabel = new System.Windows.Forms.Label();
            this.rootsLabel = new System.Windows.Forms.Label();
            this.atlasLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goneWindLabel
            // 
            this.goneWindLabel.AutoSize = true;
            this.goneWindLabel.Location = new System.Drawing.Point(12, 53);
            this.goneWindLabel.Name = "goneWindLabel";
            this.goneWindLabel.Size = new System.Drawing.Size(199, 25);
            this.goneWindLabel.TabIndex = 0;
            this.goneWindLabel.Text = "Gone with the Wind";
            // 
            // rootsLabel
            // 
            this.rootsLabel.AutoSize = true;
            this.rootsLabel.Location = new System.Drawing.Point(277, 53);
            this.rootsLabel.Name = "rootsLabel";
            this.rootsLabel.Size = new System.Drawing.Size(68, 25);
            this.rootsLabel.TabIndex = 1;
            this.rootsLabel.Text = "Roots";
            // 
            // atlasLabel
            // 
            this.atlasLabel.AutoSize = true;
            this.atlasLabel.Location = new System.Drawing.Point(412, 53);
            this.atlasLabel.Name = "atlasLabel";
            this.atlasLabel.Size = new System.Drawing.Size(159, 25);
            this.atlasLabel.TabIndex = 2;
            this.atlasLabel.Text = "Atlas Shrugged";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(17, 138);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(300, 43);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display Author";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // displayLabel1
            // 
            this.displayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel1.Location = new System.Drawing.Point(17, 88);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.Size = new System.Drawing.Size(194, 47);
            this.displayLabel1.TabIndex = 4;
            this.displayLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel2
            // 
            this.displayLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel2.Location = new System.Drawing.Point(217, 88);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(194, 47);
            this.displayLabel2.TabIndex = 5;
            this.displayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel3
            // 
            this.displayLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel3.Location = new System.Drawing.Point(417, 88);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(194, 47);
            this.displayLabel3.TabIndex = 6;
            this.displayLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click to see the athor for each bok";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(323, 138);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(300, 43);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 287);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayLabel3);
            this.Controls.Add(this.displayLabel2);
            this.Controls.Add(this.displayLabel1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.atlasLabel);
            this.Controls.Add(this.rootsLabel);
            this.Controls.Add(this.goneWindLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goneWindLabel;
        private System.Windows.Forms.Label rootsLabel;
        private System.Windows.Forms.Label atlasLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label displayLabel1;
        private System.Windows.Forms.Label displayLabel2;
        private System.Windows.Forms.Label displayLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
    }
}

