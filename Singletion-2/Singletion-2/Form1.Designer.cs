namespace Singletion_2
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
            this.SingletionTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SingletionTestBtn
            // 
            this.SingletionTestBtn.Location = new System.Drawing.Point(138, 102);
            this.SingletionTestBtn.Name = "SingletionTestBtn";
            this.SingletionTestBtn.Size = new System.Drawing.Size(156, 77);
            this.SingletionTestBtn.TabIndex = 0;
            this.SingletionTestBtn.Text = "Singletion Test";
            this.SingletionTestBtn.UseVisualStyleBackColor = true;
            this.SingletionTestBtn.Click += new System.EventHandler(this.SingletionTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 284);
            this.Controls.Add(this.SingletionTestBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SingletionTestBtn;
    }
}

