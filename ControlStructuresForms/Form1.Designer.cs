namespace ControlStructuresForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserNumberText = new System.Windows.Forms.TextBox();
            this.AddNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // UserNumberText
            // 
            this.UserNumberText.Location = new System.Drawing.Point(181, 74);
            this.UserNumberText.Name = "UserNumberText";
            this.UserNumberText.Size = new System.Drawing.Size(100, 20);
            this.UserNumberText.TabIndex = 1;
            // 
            // AddNumberButton
            // 
            this.AddNumberButton.Location = new System.Drawing.Point(136, 140);
            this.AddNumberButton.Name = "AddNumberButton";
            this.AddNumberButton.Size = new System.Drawing.Size(127, 71);
            this.AddNumberButton.TabIndex = 2;
            this.AddNumberButton.Text = "Add Number";
            this.AddNumberButton.UseVisualStyleBackColor = true;
            this.AddNumberButton.Click += new System.EventHandler(this.AddNumberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 310);
            this.Controls.Add(this.AddNumberButton);
            this.Controls.Add(this.UserNumberText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNumberText;
        private System.Windows.Forms.Button AddNumberButton;
    }
}

