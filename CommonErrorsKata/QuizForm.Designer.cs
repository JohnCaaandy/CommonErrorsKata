namespace CommonErrorsKata
{
    partial class CommonErrorsForm
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 45);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1117, 690);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lstAnswers
            // 
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.Location = new System.Drawing.Point(1136, 45);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.Size = new System.Drawing.Size(120, 654);
            this.lstAnswers.TabIndex = 1;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 16);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1117, 23);
            this.progress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1180, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "98%";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1136, 706);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CommonErrorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 747);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.pbImage);
            this.Name = "CommonErrorsForm";
            this.Text = "Common Errors Kata";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ListBox lstAnswers;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}

