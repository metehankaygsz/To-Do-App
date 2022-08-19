namespace To_Do_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addtask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addtask
            // 
            this.addtask.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addtask.Dock = System.Windows.Forms.DockStyle.Top;
            this.addtask.Font = new System.Drawing.Font("Arial Black", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addtask.ForeColor = System.Drawing.Color.IndianRed;
            this.addtask.Location = new System.Drawing.Point(0, 0);
            this.addtask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addtask.Name = "addtask";
            this.addtask.Size = new System.Drawing.Size(1046, 56);
            this.addtask.TabIndex = 0;
            this.addtask.Text = "Add Task";
            this.addtask.UseVisualStyleBackColor = false;
            this.addtask.Click += new System.EventHandler(this.addtask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(this.addtask);
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "To-Do App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button addtask;
    }
}