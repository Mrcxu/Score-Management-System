namespace Score_Management_System
{
    partial class StuMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuMainform));
            this.stuMark = new System.Windows.Forms.Button();
            this.stuUpdate = new System.Windows.Forms.Button();
            this.stuInsert = new System.Windows.Forms.Button();
            this.stuChangepwd = new System.Windows.Forms.Button();
            this.StugroupBox = new System.Windows.Forms.GroupBox();
            this.stuExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stuMark
            // 
            this.stuMark.BackColor = System.Drawing.Color.Transparent;
            this.stuMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stuMark.BackgroundImage")));
            this.stuMark.FlatAppearance.BorderSize = 0;
            this.stuMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stuMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.stuMark.Location = new System.Drawing.Point(-2, -1);
            this.stuMark.Name = "stuMark";
            this.stuMark.Size = new System.Drawing.Size(220, 100);
            this.stuMark.TabIndex = 0;
            this.stuMark.UseVisualStyleBackColor = false;
            this.stuMark.Click += new System.EventHandler(this.stuMark_Click);
            // 
            // stuUpdate
            // 
            this.stuUpdate.BackColor = System.Drawing.Color.Transparent;
            this.stuUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stuUpdate.BackgroundImage")));
            this.stuUpdate.FlatAppearance.BorderSize = 0;
            this.stuUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stuUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.stuUpdate.Location = new System.Drawing.Point(214, -1);
            this.stuUpdate.Name = "stuUpdate";
            this.stuUpdate.Size = new System.Drawing.Size(220, 100);
            this.stuUpdate.TabIndex = 1;
            this.stuUpdate.UseVisualStyleBackColor = false;
            this.stuUpdate.Click += new System.EventHandler(this.stuUpdate_Click);
            // 
            // stuInsert
            // 
            this.stuInsert.BackColor = System.Drawing.Color.Transparent;
            this.stuInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stuInsert.BackgroundImage")));
            this.stuInsert.FlatAppearance.BorderSize = 0;
            this.stuInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stuInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.stuInsert.Location = new System.Drawing.Point(431, -1);
            this.stuInsert.Name = "stuInsert";
            this.stuInsert.Size = new System.Drawing.Size(220, 100);
            this.stuInsert.TabIndex = 2;
            this.stuInsert.UseVisualStyleBackColor = false;
            this.stuInsert.Click += new System.EventHandler(this.stuInsert_Click);
            // 
            // stuChangepwd
            // 
            this.stuChangepwd.BackColor = System.Drawing.Color.Transparent;
            this.stuChangepwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stuChangepwd.BackgroundImage")));
            this.stuChangepwd.FlatAppearance.BorderSize = 0;
            this.stuChangepwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stuChangepwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.stuChangepwd.Location = new System.Drawing.Point(646, -1);
            this.stuChangepwd.Name = "stuChangepwd";
            this.stuChangepwd.Size = new System.Drawing.Size(220, 100);
            this.stuChangepwd.TabIndex = 3;
            this.stuChangepwd.UseVisualStyleBackColor = false;
            this.stuChangepwd.Click += new System.EventHandler(this.stuChangepwd_Click);
            // 
            // StugroupBox
            // 
            this.StugroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.StugroupBox.Location = new System.Drawing.Point(-2, 97);
            this.StugroupBox.Name = "StugroupBox";
            this.StugroupBox.Size = new System.Drawing.Size(900, 488);
            this.StugroupBox.TabIndex = 4;
            this.StugroupBox.TabStop = false;
            // 
            // stuExit
            // 
            this.stuExit.BackColor = System.Drawing.Color.Transparent;
            this.stuExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stuExit.BackgroundImage")));
            this.stuExit.FlatAppearance.BorderSize = 0;
            this.stuExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stuExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.stuExit.Location = new System.Drawing.Point(863, -1);
            this.stuExit.Name = "stuExit";
            this.stuExit.Size = new System.Drawing.Size(35, 100);
            this.stuExit.TabIndex = 5;
            this.stuExit.UseVisualStyleBackColor = false;
            this.stuExit.Click += new System.EventHandler(this.stuExit_Click);
            // 
            // StuMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 585);
            this.Controls.Add(this.stuExit);
            this.Controls.Add(this.StugroupBox);
            this.Controls.Add(this.stuChangepwd);
            this.Controls.Add(this.stuInsert);
            this.Controls.Add(this.stuUpdate);
            this.Controls.Add(this.stuMark);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StuMainform";
            this.Load += new System.EventHandler(this.StuMainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stuMark;
        private System.Windows.Forms.Button stuUpdate;
        private System.Windows.Forms.Button stuInsert;
        private System.Windows.Forms.Button stuChangepwd;
        private System.Windows.Forms.GroupBox StugroupBox;
        private System.Windows.Forms.Button stuExit;
    }
}