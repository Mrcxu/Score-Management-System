namespace Score_Management_System
{
    partial class TeaMainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeaMainform));
            this.tselect = new System.Windows.Forms.Button();
            this.tupdateanddelete = new System.Windows.Forms.Button();
            this.tinsert = new System.Windows.Forms.Button();
            this.tchangepwd = new System.Windows.Forms.Button();
            this.TgroupBox = new System.Windows.Forms.GroupBox();
            this.tExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tselect
            // 
            this.tselect.BackColor = System.Drawing.Color.Transparent;
            this.tselect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tselect.BackgroundImage")));
            this.tselect.FlatAppearance.BorderSize = 0;
            this.tselect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tselect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.tselect.Location = new System.Drawing.Point(-2, -1);
            this.tselect.Name = "tselect";
            this.tselect.Size = new System.Drawing.Size(220, 100);
            this.tselect.TabIndex = 0;
            this.tselect.UseVisualStyleBackColor = false;
            this.tselect.Click += new System.EventHandler(this.tselect_Click);
            // 
            // tupdateanddelete
            // 
            this.tupdateanddelete.BackColor = System.Drawing.Color.Transparent;
            this.tupdateanddelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tupdateanddelete.BackgroundImage")));
            this.tupdateanddelete.FlatAppearance.BorderSize = 0;
            this.tupdateanddelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tupdateanddelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.tupdateanddelete.Location = new System.Drawing.Point(214, -1);
            this.tupdateanddelete.Name = "tupdateanddelete";
            this.tupdateanddelete.Size = new System.Drawing.Size(220, 100);
            this.tupdateanddelete.TabIndex = 1;
            this.tupdateanddelete.UseVisualStyleBackColor = false;
            this.tupdateanddelete.Click += new System.EventHandler(this.tupdateanddelete_Click);
            // 
            // tinsert
            // 
            this.tinsert.BackColor = System.Drawing.Color.Transparent;
            this.tinsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinsert.BackgroundImage")));
            this.tinsert.FlatAppearance.BorderSize = 0;
            this.tinsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tinsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.tinsert.Location = new System.Drawing.Point(431, -1);
            this.tinsert.Name = "tinsert";
            this.tinsert.Size = new System.Drawing.Size(220, 100);
            this.tinsert.TabIndex = 2;
            this.tinsert.Text = "                                             ";
            this.tinsert.UseVisualStyleBackColor = false;
            // 
            // tchangepwd
            // 
            this.tchangepwd.BackColor = System.Drawing.Color.Transparent;
            this.tchangepwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tchangepwd.BackgroundImage")));
            this.tchangepwd.FlatAppearance.BorderSize = 0;
            this.tchangepwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tchangepwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.tchangepwd.Location = new System.Drawing.Point(646, -1);
            this.tchangepwd.Name = "tchangepwd";
            this.tchangepwd.Size = new System.Drawing.Size(220, 100);
            this.tchangepwd.TabIndex = 3;
            this.tchangepwd.UseVisualStyleBackColor = false;
            this.tchangepwd.Click += new System.EventHandler(this.tchangepwd_Click);
            // 
            // TgroupBox
            // 
            this.TgroupBox.Location = new System.Drawing.Point(0, 99);
            this.TgroupBox.Name = "TgroupBox";
            this.TgroupBox.Size = new System.Drawing.Size(900, 488);
            this.TgroupBox.TabIndex = 4;
            this.TgroupBox.TabStop = false;
            // 
            // tExit
            // 
            this.tExit.BackColor = System.Drawing.Color.Transparent;
            this.tExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tExit.BackgroundImage")));
            this.tExit.FlatAppearance.BorderSize = 0;
            this.tExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.tExit.Location = new System.Drawing.Point(863, 0);
            this.tExit.Name = "tExit";
            this.tExit.Size = new System.Drawing.Size(35, 100);
            this.tExit.TabIndex = 5;
            this.tExit.UseVisualStyleBackColor = false;
            this.tExit.Click += new System.EventHandler(this.tExit_Click);
            // 
            // TeaMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 585);
            this.Controls.Add(this.tExit);
            this.Controls.Add(this.TgroupBox);
            this.Controls.Add(this.tchangepwd);
            this.Controls.Add(this.tinsert);
            this.Controls.Add(this.tupdateanddelete);
            this.Controls.Add(this.tselect);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeaMainform";
            this.Text = "TeaMainform";
            this.Load += new System.EventHandler(this.TeaMainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tselect;
        private System.Windows.Forms.Button tupdateanddelete;
        private System.Windows.Forms.Button tinsert;
        private System.Windows.Forms.Button tchangepwd;
        private System.Windows.Forms.GroupBox TgroupBox;
        private System.Windows.Forms.Button tExit;
    }
}