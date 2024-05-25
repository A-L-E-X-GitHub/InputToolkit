namespace MouseHelper
{
    partial class ActionEventComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionEventComponent));
            this.labelText1 = new System.Windows.Forms.Label();
            this.panelHandle1 = new System.Windows.Forms.Panel();
            this.panelButton2 = new System.Windows.Forms.Panel();
            this.buttonRemove1 = new System.Windows.Forms.Button();
            this.panelButton1 = new System.Windows.Forms.Panel();
            this.buttonSettings1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl1 = new System.Windows.Forms.Panel();
            this.panelButton2.SuspendLayout();
            this.panelButton1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelText1
            // 
            this.labelText1.AutoEllipsis = true;
            this.labelText1.AutoSize = true;
            this.labelText1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelText1.Location = new System.Drawing.Point(40, 0);
            this.labelText1.MaximumSize = new System.Drawing.Size(250, 22);
            this.labelText1.MinimumSize = new System.Drawing.Size(22, 22);
            this.labelText1.Name = "labelText1";
            this.labelText1.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.labelText1.Size = new System.Drawing.Size(73, 22);
            this.labelText1.TabIndex = 1;
            this.labelText1.Text = "New Event";
            this.labelText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelText1.UseMnemonic = false;
            // 
            // panelHandle1
            // 
            this.panelHandle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.panelHandle1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHandle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHandle1.Location = new System.Drawing.Point(1, 0);
            this.panelHandle1.Name = "panelHandle1";
            this.panelHandle1.Size = new System.Drawing.Size(11, 27);
            this.panelHandle1.TabIndex = 0;
            // 
            // panelButton2
            // 
            this.panelButton2.Controls.Add(this.buttonRemove1);
            this.panelButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton2.Location = new System.Drawing.Point(319, 0);
            this.panelButton2.Margin = new System.Windows.Forms.Padding(0);
            this.panelButton2.Name = "panelButton2";
            this.panelButton2.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.panelButton2.Size = new System.Drawing.Size(27, 27);
            this.panelButton2.TabIndex = 3;
            // 
            // buttonRemove1
            // 
            this.buttonRemove1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.buttonRemove1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove1.BackgroundImage")));
            this.buttonRemove1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRemove1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonRemove1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonRemove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.buttonRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove1.Location = new System.Drawing.Point(2, 2);
            this.buttonRemove1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove1.Name = "buttonRemove1";
            this.buttonRemove1.Size = new System.Drawing.Size(24, 24);
            this.buttonRemove1.TabIndex = 1;
            this.buttonRemove1.UseVisualStyleBackColor = false;
            this.buttonRemove1.Click += new System.EventHandler(this.OnButtonPressed_RemoveComponent);
            // 
            // panelButton1
            // 
            this.panelButton1.Controls.Add(this.buttonSettings1);
            this.panelButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton1.Location = new System.Drawing.Point(292, 0);
            this.panelButton1.Margin = new System.Windows.Forms.Padding(0);
            this.panelButton1.Name = "panelButton1";
            this.panelButton1.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.panelButton1.Size = new System.Drawing.Size(27, 27);
            this.panelButton1.TabIndex = 2;
            // 
            // buttonSettings1
            // 
            this.buttonSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.buttonSettings1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSettings1.BackgroundImage")));
            this.buttonSettings1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSettings1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonSettings1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonSettings1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.buttonSettings1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings1.Location = new System.Drawing.Point(2, 2);
            this.buttonSettings1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings1.Name = "buttonSettings1";
            this.buttonSettings1.Size = new System.Drawing.Size(24, 24);
            this.buttonSettings1.TabIndex = 1;
            this.buttonSettings1.UseVisualStyleBackColor = false;
            this.buttonSettings1.Click += new System.EventHandler(this.OnButtonPressed_OpenSettings);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panelControl1.Controls.Add(this.labelText1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.panelHandle1);
            this.panelControl1.Controls.Add(this.panelButton1);
            this.panelControl1.Controls.Add(this.panelButton2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(1, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.panelControl1.Size = new System.Drawing.Size(347, 28);
            this.panelControl1.TabIndex = 0;
            // 
            // ActionEventComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "ActionEventComponent";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(349, 30);
            this.panelButton2.ResumeLayout(false);
            this.panelButton1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Panel panelHandle1;
        private System.Windows.Forms.Panel panelButton2;
        private System.Windows.Forms.Button buttonRemove1;
        private System.Windows.Forms.Panel panelButton1;
        private System.Windows.Forms.Button buttonSettings1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelControl1;
    }
}
