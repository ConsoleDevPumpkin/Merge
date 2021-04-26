
namespace Merge
{
    partial class create_file
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
            this.filename = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.filepath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(49, 96);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(204, 27);
            this.filename.TabIndex = 1;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.path.Location = new System.Drawing.Point(512, 45);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(107, 31);
            this.path.TabIndex = 2;
            this.path.Text = "File path:";
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(512, 96);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(204, 27);
            this.filepath.TabIndex = 3;
            // 
            // create_file
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.path);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label1);
            this.Name = "create_file";
            this.Text = "Create new project";
            this.Load += new System.EventHandler(this.create_file_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox filepath;
    }
}