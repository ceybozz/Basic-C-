namespace My_First_Project
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
            this.buttonDisplayMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDisplayMessage
            // 
            this.buttonDisplayMessage.Location = new System.Drawing.Point(295, 189);
            this.buttonDisplayMessage.Name = "buttonDisplayMessage";
            this.buttonDisplayMessage.Size = new System.Drawing.Size(154, 73);
            this.buttonDisplayMessage.TabIndex = 0;
            this.buttonDisplayMessage.Text = "Display Message";
            this.buttonDisplayMessage.UseVisualStyleBackColor = true;
            this.buttonDisplayMessage.Click += new System.EventHandler(this.buttonDisplayMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDisplayMessage);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplayMessage;
    }
}

