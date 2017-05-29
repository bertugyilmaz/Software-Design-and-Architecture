namespace Observer
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
            this.observerTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // observerTestBtn
            // 
            this.observerTestBtn.Location = new System.Drawing.Point(210, 175);
            this.observerTestBtn.Name = "observerTestBtn";
            this.observerTestBtn.Size = new System.Drawing.Size(92, 56);
            this.observerTestBtn.TabIndex = 0;
            this.observerTestBtn.Text = "Observer Test";
            this.observerTestBtn.UseVisualStyleBackColor = true;
            this.observerTestBtn.Click += new System.EventHandler(this.observerTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 436);
            this.Controls.Add(this.observerTestBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button observerTestBtn;
    }
}

