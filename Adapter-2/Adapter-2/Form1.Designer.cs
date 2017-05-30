namespace Adapter_2
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
            this.adapterTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adapterTestBtn
            // 
            this.adapterTestBtn.Location = new System.Drawing.Point(195, 163);
            this.adapterTestBtn.Name = "adapterTestBtn";
            this.adapterTestBtn.Size = new System.Drawing.Size(122, 58);
            this.adapterTestBtn.TabIndex = 0;
            this.adapterTestBtn.Text = "Adapter Test! ";
            this.adapterTestBtn.UseVisualStyleBackColor = true;
            this.adapterTestBtn.Click += new System.EventHandler(this.adapterTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 357);
            this.Controls.Add(this.adapterTestBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adapterTestBtn;
    }
}

