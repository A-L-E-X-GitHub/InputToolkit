namespace MouseHelper
{
    partial class FormMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRunScript = new MouseHelper.StylizedButton();
            this.buttonTrackCursor = new MouseHelper.StylizedButton();
            this.actionEventPanel1 = new MouseHelper.ActionEventPanel();
            this.buttonSetRunKey = new MouseHelper.StylizedButton();
            this.buttonSettings = new MouseHelper.StylizedButton();
            this.panelHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(375, 30);
            this.panelHeader.TabIndex = 50;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDrag_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnDrag_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnDrag_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(345, 0);
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
            this.buttonRemove.Click += new System.EventHandler(this.OnButtonPressed_CloseApplication);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Input Toolkit";
            // 
            // timer
            // 
            this.timer.Interval = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRunScript);
            this.panel2.Controls.Add(this.buttonTrackCursor);
            this.panel2.Controls.Add(this.actionEventPanel1);
            this.panel2.Controls.Add(this.buttonSetRunKey);
            this.panel2.Controls.Add(this.buttonSettings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(375, 387);
            this.panel2.TabIndex = 52;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Red;
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
            this.buttonRunScript.Location = new System.Drawing.Point(282, 346);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(86, 30);
            this.buttonRunScript.TabIndex = 6;
            this.buttonRunScript.Text = "Run ( F1 )";
            this.buttonRunScript.UseMnemonic = false;
            this.buttonRunScript.UseVisualStyleBackColor = false;
            this.buttonRunScript.Click += new System.EventHandler(this.OnButtonPressed_RunScript);
            // 
            // buttonTrackCursor
            // 
            this.buttonTrackCursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.buttonTrackCursor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonTrackCursor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.buttonTrackCursor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonTrackCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrackCursor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrackCursor.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTrackCursor.Location = new System.Drawing.Point(99, 346);
            this.buttonTrackCursor.Name = "buttonTrackCursor";
            this.buttonTrackCursor.Size = new System.Drawing.Size(86, 30);
            this.buttonTrackCursor.TabIndex = 5;
            this.buttonTrackCursor.Text = "Track Cursor";
            this.buttonTrackCursor.UseVisualStyleBackColor = false;
            this.buttonTrackCursor.Click += new System.EventHandler(this.OnButtonPressed_TrackCursor);
            // 
            // actionEventPanel1
            // 
            this.actionEventPanel1.AutoScroll = true;
            this.actionEventPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.actionEventPanel1.BlockInput = false;
            this.actionEventPanel1.Location = new System.Drawing.Point(7, 7);
            this.actionEventPanel1.MinimumSize = new System.Drawing.Size(250, 333);
            this.actionEventPanel1.Name = "actionEventPanel1";
            this.actionEventPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.actionEventPanel1.Size = new System.Drawing.Size(361, 333);
            this.actionEventPanel1.TabIndex = 4;
            // 
            // buttonSetRunKey
            // 
            this.buttonSetRunKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.buttonSetRunKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonSetRunKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.buttonSetRunKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonSetRunKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetRunKey.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetRunKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSetRunKey.Location = new System.Drawing.Point(191, 346);
            this.buttonSetRunKey.Name = "buttonSetRunKey";
            this.buttonSetRunKey.Size = new System.Drawing.Size(86, 30);
            this.buttonSetRunKey.TabIndex = 3;
            this.buttonSetRunKey.Text = "Set Run Key";
            this.toolTip.SetToolTip(this.buttonSetRunKey, "Currently does not contain safety checks,\r\nensure key entered is a valid key.\r\n\r\n" +
        "Suggested keys:\r\n - F1 -> F12\r\n - A -> Z\r\n - 0 -> 9\r\n");
            this.buttonSetRunKey.UseVisualStyleBackColor = false;
            this.buttonSetRunKey.Click += new System.EventHandler(this.OnButtonPressed_SetScriptKey);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Location = new System.Drawing.Point(7, 346);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(86, 30);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.OnButtonPressed_OpenSettings);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(385, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panel2;
        private StylizedButton buttonSetRunKey;
        private StylizedButton buttonSettings;
        private ActionEventPanel actionEventPanel1;
        private StylizedButton buttonRunScript;
        private StylizedButton buttonTrackCursor;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

