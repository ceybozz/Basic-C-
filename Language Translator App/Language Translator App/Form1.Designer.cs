namespace Language_Translator_App
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.buttonItalian = new System.Windows.Forms.Button();
            this.buttonSpanish = new System.Windows.Forms.Button();
            this.buttonGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(258, 161);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(462, 25);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a language and i will say Good Morning.";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(263, 209);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(457, 43);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonItalian
            // 
            this.buttonItalian.Location = new System.Drawing.Point(263, 302);
            this.buttonItalian.Name = "buttonItalian";
            this.buttonItalian.Size = new System.Drawing.Size(152, 36);
            this.buttonItalian.TabIndex = 2;
            this.buttonItalian.Text = "Italian";
            this.buttonItalian.UseVisualStyleBackColor = true;
            this.buttonItalian.Click += new System.EventHandler(this.buttonItalian_Click);
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.Location = new System.Drawing.Point(421, 302);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(152, 36);
            this.buttonSpanish.TabIndex = 3;
            this.buttonSpanish.Text = "Spanish";
            this.buttonSpanish.UseVisualStyleBackColor = true;
            this.buttonSpanish.Click += new System.EventHandler(this.buttonSpanish_Click);
            // 
            // buttonGerman
            // 
            this.buttonGerman.Location = new System.Drawing.Point(579, 302);
            this.buttonGerman.Name = "buttonGerman";
            this.buttonGerman.Size = new System.Drawing.Size(152, 36);
            this.buttonGerman.TabIndex = 4;
            this.buttonGerman.Text = "German";
            this.buttonGerman.UseVisualStyleBackColor = true;
            this.buttonGerman.Click += new System.EventHandler(this.buttonGerman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 652);
            this.Controls.Add(this.buttonGerman);
            this.Controls.Add(this.buttonSpanish);
            this.Controls.Add(this.buttonItalian);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button buttonItalian;
        private System.Windows.Forms.Button buttonSpanish;
        private System.Windows.Forms.Button buttonGerman;
    }
}

