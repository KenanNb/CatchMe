
namespace CatchMe
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
            this.catchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchBtn
            // 
            this.catchBtn.AutoSize = true;
            this.catchBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.catchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchBtn.Location = new System.Drawing.Point(374, 151);
            this.catchBtn.Name = "catchBtn";
            this.catchBtn.Size = new System.Drawing.Size(122, 35);
            this.catchBtn.TabIndex = 0;
            this.catchBtn.Text = "Catch Me";
            this.catchBtn.UseVisualStyleBackColor = false;
            this.catchBtn.MouseEnter += new System.EventHandler(this.catchBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catchBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button catchBtn;
    }
}

