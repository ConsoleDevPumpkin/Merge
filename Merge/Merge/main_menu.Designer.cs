
namespace Merge
{
    partial class main_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadproject = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.newproject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadproject
            // 
            this.loadproject.Location = new System.Drawing.Point(289, 100);
            this.loadproject.Name = "loadproject";
            this.loadproject.Size = new System.Drawing.Size(106, 29);
            this.loadproject.TabIndex = 1;
            this.loadproject.Text = "Load project";
            this.loadproject.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(489, 100);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // newproject
            // 
            this.newproject.Location = new System.Drawing.Point(105, 100);
            this.newproject.Name = "newproject";
            this.newproject.Size = new System.Drawing.Size(98, 29);
            this.newproject.TabIndex = 3;
            this.newproject.Text = "New project";
            this.newproject.UseVisualStyleBackColor = true;
            this.newproject.Click += new System.EventHandler(this.newproject_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newproject);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.loadproject);
            this.Name = "main_menu";
            this.Text = "Merge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadproject;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button newproject;
    }
}

