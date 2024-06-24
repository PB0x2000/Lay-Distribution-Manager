namespace Lay_Distribution_Manager
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
            this.panel_MAIN = new System.Windows.Forms.Panel();
            this.panel_CONTENT_INSPECTION = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_INSPECTION_ACR = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_INSPECTION_INFO = new System.Windows.Forms.Panel();
            this.label_INSPECTION_INFO = new System.Windows.Forms.Label();
            this.flowLayoutPanel_INSPECTION_SONGS = new System.Windows.Forms.FlowLayoutPanel();
            this.button_INSPECTION_GETDATA = new System.Windows.Forms.Button();
            this.flowLayoutPanel_INSPECTION_ARTISTS = new System.Windows.Forms.FlowLayoutPanel();
            this.button_INSPECTION_DENY = new System.Windows.Forms.Button();
            this.button_INSPECTION_APPROVE = new System.Windows.Forms.Button();
            this.label_INSPECTION_TITLE = new System.Windows.Forms.Label();
            this.flowLayoutPanel_RELEASES = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_LEFT = new System.Windows.Forms.Panel();
            this.button_EXPORT_BLOCKED = new System.Windows.Forms.Button();
            this.button_INSPECTION = new System.Windows.Forms.Button();
            this.panel_TOP = new System.Windows.Forms.Panel();
            this.label_AUTH = new System.Windows.Forms.Label();
            this.textBox_AUTH = new System.Windows.Forms.TextBox();
            this.panel_MAIN.SuspendLayout();
            this.panel_CONTENT_INSPECTION.SuspendLayout();
            this.panel_INSPECTION_INFO.SuspendLayout();
            this.panel_LEFT.SuspendLayout();
            this.panel_TOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MAIN
            // 
            this.panel_MAIN.Controls.Add(this.panel_CONTENT_INSPECTION);
            this.panel_MAIN.Controls.Add(this.flowLayoutPanel_RELEASES);
            this.panel_MAIN.Controls.Add(this.panel_LEFT);
            this.panel_MAIN.Controls.Add(this.panel_TOP);
            this.panel_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_MAIN.Location = new System.Drawing.Point(0, 0);
            this.panel_MAIN.Name = "panel_MAIN";
            this.panel_MAIN.Size = new System.Drawing.Size(1904, 1041);
            this.panel_MAIN.TabIndex = 0;
            // 
            // panel_CONTENT_INSPECTION
            // 
            this.panel_CONTENT_INSPECTION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CONTENT_INSPECTION.Controls.Add(this.flowLayoutPanel_INSPECTION_ACR);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.panel_INSPECTION_INFO);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.flowLayoutPanel_INSPECTION_SONGS);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.button_INSPECTION_GETDATA);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.flowLayoutPanel_INSPECTION_ARTISTS);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.button_INSPECTION_DENY);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.button_INSPECTION_APPROVE);
            this.panel_CONTENT_INSPECTION.Controls.Add(this.label_INSPECTION_TITLE);
            this.panel_CONTENT_INSPECTION.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_CONTENT_INSPECTION.Enabled = false;
            this.panel_CONTENT_INSPECTION.Location = new System.Drawing.Point(300, 85);
            this.panel_CONTENT_INSPECTION.Name = "panel_CONTENT_INSPECTION";
            this.panel_CONTENT_INSPECTION.Size = new System.Drawing.Size(1304, 956);
            this.panel_CONTENT_INSPECTION.TabIndex = 2;
            // 
            // flowLayoutPanel_INSPECTION_ACR
            // 
            this.flowLayoutPanel_INSPECTION_ACR.Location = new System.Drawing.Point(622, 386);
            this.flowLayoutPanel_INSPECTION_ACR.Name = "flowLayoutPanel_INSPECTION_ACR";
            this.flowLayoutPanel_INSPECTION_ACR.Size = new System.Drawing.Size(675, 565);
            this.flowLayoutPanel_INSPECTION_ACR.TabIndex = 7;
            // 
            // panel_INSPECTION_INFO
            // 
            this.panel_INSPECTION_INFO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_INSPECTION_INFO.Controls.Add(this.label_INSPECTION_INFO);
            this.panel_INSPECTION_INFO.Location = new System.Drawing.Point(5, 67);
            this.panel_INSPECTION_INFO.Name = "panel_INSPECTION_INFO";
            this.panel_INSPECTION_INFO.Size = new System.Drawing.Size(1292, 313);
            this.panel_INSPECTION_INFO.TabIndex = 6;
            // 
            // label_INSPECTION_INFO
            // 
            this.label_INSPECTION_INFO.AutoSize = true;
            this.label_INSPECTION_INFO.Enabled = false;
            this.label_INSPECTION_INFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_INSPECTION_INFO.ForeColor = System.Drawing.Color.Yellow;
            this.label_INSPECTION_INFO.Location = new System.Drawing.Point(13, 16);
            this.label_INSPECTION_INFO.Name = "label_INSPECTION_INFO";
            this.label_INSPECTION_INFO.Size = new System.Drawing.Size(104, 160);
            this.label_INSPECTION_INFO.TabIndex = 0;
            this.label_INSPECTION_INFO.Text = "TITLE\r\nARTIST\r\nUPC\r\nEMAIL\r\nLANGUAGE\r\nGENRE\r\nLABEL\r\nCOPYRIGHT";
            this.label_INSPECTION_INFO.Visible = false;
            // 
            // flowLayoutPanel_INSPECTION_SONGS
            // 
            this.flowLayoutPanel_INSPECTION_SONGS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel_INSPECTION_SONGS.AutoSize = true;
            this.flowLayoutPanel_INSPECTION_SONGS.Location = new System.Drawing.Point(5, 386);
            this.flowLayoutPanel_INSPECTION_SONGS.Name = "flowLayoutPanel_INSPECTION_SONGS";
            this.flowLayoutPanel_INSPECTION_SONGS.Size = new System.Drawing.Size(611, 565);
            this.flowLayoutPanel_INSPECTION_SONGS.TabIndex = 5;
            // 
            // button_INSPECTION_GETDATA
            // 
            this.button_INSPECTION_GETDATA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_INSPECTION_GETDATA.Enabled = false;
            this.button_INSPECTION_GETDATA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_INSPECTION_GETDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_INSPECTION_GETDATA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_INSPECTION_GETDATA.Location = new System.Drawing.Point(1117, 11);
            this.button_INSPECTION_GETDATA.Name = "button_INSPECTION_GETDATA";
            this.button_INSPECTION_GETDATA.Size = new System.Drawing.Size(180, 50);
            this.button_INSPECTION_GETDATA.TabIndex = 4;
            this.button_INSPECTION_GETDATA.Text = "GET DATA";
            this.button_INSPECTION_GETDATA.Visible = false;
            this.button_INSPECTION_GETDATA.Click += new System.EventHandler(this.button_INSPECTION_GETDATA_Click);
            // 
            // flowLayoutPanel_INSPECTION_ARTISTS
            // 
            this.flowLayoutPanel_INSPECTION_ARTISTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_INSPECTION_ARTISTS.AutoSize = true;
            this.flowLayoutPanel_INSPECTION_ARTISTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_INSPECTION_ARTISTS.Enabled = false;
            this.flowLayoutPanel_INSPECTION_ARTISTS.Location = new System.Drawing.Point(620, 11);
            this.flowLayoutPanel_INSPECTION_ARTISTS.Name = "flowLayoutPanel_INSPECTION_ARTISTS";
            this.flowLayoutPanel_INSPECTION_ARTISTS.Size = new System.Drawing.Size(491, 50);
            this.flowLayoutPanel_INSPECTION_ARTISTS.TabIndex = 3;
            this.flowLayoutPanel_INSPECTION_ARTISTS.Visible = false;
            // 
            // button_INSPECTION_DENY
            // 
            this.button_INSPECTION_DENY.Enabled = false;
            this.button_INSPECTION_DENY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_INSPECTION_DENY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_INSPECTION_DENY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_INSPECTION_DENY.Location = new System.Drawing.Point(434, 11);
            this.button_INSPECTION_DENY.Name = "button_INSPECTION_DENY";
            this.button_INSPECTION_DENY.Size = new System.Drawing.Size(180, 50);
            this.button_INSPECTION_DENY.TabIndex = 2;
            this.button_INSPECTION_DENY.Text = "DENY";
            this.button_INSPECTION_DENY.Visible = false;
            this.button_INSPECTION_DENY.Click += new System.EventHandler(this.button_INSPECTION_DENY_Click);
            // 
            // button_INSPECTION_APPROVE
            // 
            this.button_INSPECTION_APPROVE.Enabled = false;
            this.button_INSPECTION_APPROVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_INSPECTION_APPROVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_INSPECTION_APPROVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_INSPECTION_APPROVE.Location = new System.Drawing.Point(248, 11);
            this.button_INSPECTION_APPROVE.Name = "button_INSPECTION_APPROVE";
            this.button_INSPECTION_APPROVE.Size = new System.Drawing.Size(180, 50);
            this.button_INSPECTION_APPROVE.TabIndex = 1;
            this.button_INSPECTION_APPROVE.Text = "APPROVE";
            this.button_INSPECTION_APPROVE.Visible = false;
            this.button_INSPECTION_APPROVE.Click += new System.EventHandler(this.button_INSPECTION_APPROVE_Click);
            // 
            // label_INSPECTION_TITLE
            // 
            this.label_INSPECTION_TITLE.AutoSize = true;
            this.label_INSPECTION_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_INSPECTION_TITLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_INSPECTION_TITLE.Location = new System.Drawing.Point(14, 16);
            this.label_INSPECTION_TITLE.Name = "label_INSPECTION_TITLE";
            this.label_INSPECTION_TITLE.Size = new System.Drawing.Size(228, 39);
            this.label_INSPECTION_TITLE.TabIndex = 0;
            this.label_INSPECTION_TITLE.Text = "INSPECTION";
            // 
            // flowLayoutPanel_RELEASES
            // 
            this.flowLayoutPanel_RELEASES.AutoScroll = true;
            this.flowLayoutPanel_RELEASES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_RELEASES.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_RELEASES.Location = new System.Drawing.Point(1604, 85);
            this.flowLayoutPanel_RELEASES.Name = "flowLayoutPanel_RELEASES";
            this.flowLayoutPanel_RELEASES.Size = new System.Drawing.Size(300, 956);
            this.flowLayoutPanel_RELEASES.TabIndex = 0;
            // 
            // panel_LEFT
            // 
            this.panel_LEFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_LEFT.Controls.Add(this.button_EXPORT_BLOCKED);
            this.panel_LEFT.Controls.Add(this.button_INSPECTION);
            this.panel_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_LEFT.Location = new System.Drawing.Point(0, 85);
            this.panel_LEFT.Name = "panel_LEFT";
            this.panel_LEFT.Size = new System.Drawing.Size(300, 956);
            this.panel_LEFT.TabIndex = 1;
            // 
            // button_EXPORT_BLOCKED
            // 
            this.button_EXPORT_BLOCKED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EXPORT_BLOCKED.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EXPORT_BLOCKED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_EXPORT_BLOCKED.Location = new System.Drawing.Point(3, 893);
            this.button_EXPORT_BLOCKED.Name = "button_EXPORT_BLOCKED";
            this.button_EXPORT_BLOCKED.Size = new System.Drawing.Size(290, 50);
            this.button_EXPORT_BLOCKED.TabIndex = 1;
            this.button_EXPORT_BLOCKED.Text = "Export Blocked";
            this.button_EXPORT_BLOCKED.Click += new System.EventHandler(this.button_EXPORT_BLOCKED_Click);
            // 
            // button_INSPECTION
            // 
            this.button_INSPECTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_INSPECTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_INSPECTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_INSPECTION.Location = new System.Drawing.Point(60, 34);
            this.button_INSPECTION.Name = "button_INSPECTION";
            this.button_INSPECTION.Size = new System.Drawing.Size(180, 50);
            this.button_INSPECTION.TabIndex = 0;
            this.button_INSPECTION.Text = "Inspection";
            this.button_INSPECTION.Click += new System.EventHandler(this.button_INSPECTION_Click);
            // 
            // panel_TOP
            // 
            this.panel_TOP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TOP.Controls.Add(this.label_AUTH);
            this.panel_TOP.Controls.Add(this.textBox_AUTH);
            this.panel_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TOP.Location = new System.Drawing.Point(0, 0);
            this.panel_TOP.Name = "panel_TOP";
            this.panel_TOP.Size = new System.Drawing.Size(1904, 85);
            this.panel_TOP.TabIndex = 0;
            // 
            // label_AUTH
            // 
            this.label_AUTH.AutoSize = true;
            this.label_AUTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AUTH.ForeColor = System.Drawing.Color.Lime;
            this.label_AUTH.Location = new System.Drawing.Point(12, 14);
            this.label_AUTH.Name = "label_AUTH";
            this.label_AUTH.Size = new System.Drawing.Size(91, 20);
            this.label_AUTH.TabIndex = 1;
            this.label_AUTH.Text = "Auth Token";
            // 
            // textBox_AUTH
            // 
            this.textBox_AUTH.BackColor = System.Drawing.Color.Black;
            this.textBox_AUTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_AUTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AUTH.ForeColor = System.Drawing.Color.Lime;
            this.textBox_AUTH.Location = new System.Drawing.Point(109, 12);
            this.textBox_AUTH.Name = "textBox_AUTH";
            this.textBox_AUTH.Size = new System.Drawing.Size(356, 26);
            this.textBox_AUTH.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel_MAIN);
            this.Name = "Form1";
            this.Text = "Lay Distribution Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_MAIN.ResumeLayout(false);
            this.panel_CONTENT_INSPECTION.ResumeLayout(false);
            this.panel_CONTENT_INSPECTION.PerformLayout();
            this.panel_INSPECTION_INFO.ResumeLayout(false);
            this.panel_INSPECTION_INFO.PerformLayout();
            this.panel_LEFT.ResumeLayout(false);
            this.panel_TOP.ResumeLayout(false);
            this.panel_TOP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MAIN;
        private System.Windows.Forms.Panel panel_LEFT;
        private System.Windows.Forms.Panel panel_TOP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_RELEASES;
        private System.Windows.Forms.Panel panel_CONTENT_INSPECTION;
        private System.Windows.Forms.Label label_AUTH;
        private System.Windows.Forms.TextBox textBox_AUTH;
        private System.Windows.Forms.Button button_INSPECTION;
        private System.Windows.Forms.Label label_INSPECTION_TITLE;
        private System.Windows.Forms.Button button_INSPECTION_DENY;
        private System.Windows.Forms.Button button_INSPECTION_APPROVE;
        private System.Windows.Forms.Button button_INSPECTION_GETDATA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_INSPECTION_ARTISTS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_INSPECTION_SONGS;
        private System.Windows.Forms.Panel panel_INSPECTION_INFO;
        private System.Windows.Forms.Label label_INSPECTION_INFO;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_INSPECTION_ACR;
        private System.Windows.Forms.Button button_EXPORT_BLOCKED;
    }
}