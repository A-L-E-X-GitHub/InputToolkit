namespace MouseHelper.forms
{
    partial class FormToolkitSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToolkitSettings));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stylizedButton1 = new MouseHelper.StylizedButton();
            this.buttonRunScript = new MouseHelper.StylizedButton();
            this.checkBoxCursorToOrigin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDefaultDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gray;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Controls.Add(this.panel4);
            this.panelHeader.Controls.Add(this.label6);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(5, 5);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(221, 30);
            this.panelHeader.TabIndex = 51;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDrag_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnDrag_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDrag_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(191, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 53;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Gray;
            this.buttonRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove.BackgroundImage")));
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Location = new System.Drawing.Point(2, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(26, 26);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.OnButtonPressed_Close);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stylizedButton1);
            this.panel1.Controls.Add(this.buttonRunScript);
            this.panel1.Controls.Add(this.checkBoxCursorToOrigin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDefaultDelay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(221, 136);
            this.panel1.TabIndex = 52;
            // 
            // stylizedButton1
            // 
            this.stylizedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.stylizedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.stylizedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.stylizedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.stylizedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stylizedButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylizedButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.stylizedButton1.Location = new System.Drawing.Point(15, 93);
            this.stylizedButton1.Name = "stylizedButton1";
            this.stylizedButton1.Size = new System.Drawing.Size(86, 30);
            this.stylizedButton1.TabIndex = 62;
            this.stylizedButton1.Text = "Reset";
            this.stylizedButton1.UseVisualStyleBackColor = false;
            this.stylizedButton1.Click += new System.EventHandler(this.OnButtonPressed_ResetSettings);
            // 
            // buttonRunScript
            // 
            this.buttonRunScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.buttonRunScript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonRunScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.buttonRunScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonRunScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunScript.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunScript.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRunScript.Location = new System.Drawing.Point(120, 93);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(86, 30);
            this.buttonRunScript.TabIndex = 61;
            this.buttonRunScript.Text = "Save";
            this.buttonRunScript.UseVisualStyleBackColor = false;
            this.buttonRunScript.Click += new System.EventHandler(this.OnButtonPressed_SaveSettings);
            // 
            // checkBoxCursorToOrigin
            // 
            this.checkBoxCursorToOrigin.AutoSize = true;
            this.checkBoxCursorToOrigin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCursorToOrigin.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxCursorToOrigin.Location = new System.Drawing.Point(174, 25);
            this.checkBoxCursorToOrigin.Name = "checkBoxCursorToOrigin";
            this.checkBoxCursorToOrigin.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCursorToOrigin.TabIndex = 60;
            this.checkBoxCursorToOrigin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cursor to origin";
            this.toolTip.SetToolTip(this.label1, "[Default = Unchecked]\r\n\r\nDetermines if the cursor should return to the\r\nposition " +
        "it was initially at when the script begins.\r\n\r\n");
            // 
            // textBoxDefaultDelay
            // 
            this.textBoxDefaultDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.textBoxDefaultDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDefaultDelay.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxDefaultDelay.Location = new System.Drawing.Point(154, 46);
            this.textBoxDefaultDelay.Name = "textBoxDefaultDelay";
            this.textBoxDefaultDelay.Size = new System.Drawing.Size(54, 22);
            this.textBoxDefaultDelay.TabIndex = 57;
            this.textBoxDefaultDelay.Text = "100";
            this.textBoxDefaultDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Default delay";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.toolTip.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // FormToolkitSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(231, 182);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormToolkitSettings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormToolkitSettings";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxCursorToOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDefaultDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private StylizedButton stylizedButton1;
        private StylizedButton buttonRunScript;
    }
}