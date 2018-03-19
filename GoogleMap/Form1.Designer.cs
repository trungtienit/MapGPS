namespace GoogleMap
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RbMyIP = new System.Windows.Forms.RadioButton();
            this.RbCoordinateToAddress = new System.Windows.Forms.RadioButton();
            this.RbAddressToCoordinate = new System.Windows.Forms.RadioButton();
            this.gbCoordinate = new System.Windows.Forms.GroupBox();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCoordinate = new System.Windows.Forms.RadioButton();
            this.rbAddress = new System.Windows.Forms.RadioButton();
            this.BtnSearchByAddress = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCoordinate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1914, 995);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnGet);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.gbCoordinate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnSearchByAddress);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 983);
            this.panel1.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.Location = new System.Drawing.Point(158, 801);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(181, 49);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btn_Click_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RbMyIP);
            this.groupBox3.Controls.Add(this.RbCoordinateToAddress);
            this.groupBox3.Controls.Add(this.RbAddressToCoordinate);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(30, 554);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 207);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get  Info";
            // 
            // RbMyIP
            // 
            this.RbMyIP.AutoSize = true;
            this.RbMyIP.Location = new System.Drawing.Point(31, 141);
            this.RbMyIP.Name = "RbMyIP";
            this.RbMyIP.Size = new System.Drawing.Size(278, 29);
            this.RbMyIP.TabIndex = 3;
            this.RbMyIP.Text = "From My ip to Coodinate";
            this.RbMyIP.UseVisualStyleBackColor = true;
            // 
            // RbCoordinateToAddress
            // 
            this.RbCoordinateToAddress.AutoSize = true;
            this.RbCoordinateToAddress.Location = new System.Drawing.Point(31, 88);
            this.RbCoordinateToAddress.Name = "RbCoordinateToAddress";
            this.RbCoordinateToAddress.Size = new System.Drawing.Size(312, 29);
            this.RbCoordinateToAddress.TabIndex = 1;
            this.RbCoordinateToAddress.Text = "From Coordinate to Address";
            this.RbCoordinateToAddress.UseVisualStyleBackColor = true;
            // 
            // RbAddressToCoordinate
            // 
            this.RbAddressToCoordinate.AutoSize = true;
            this.RbAddressToCoordinate.Checked = true;
            this.RbAddressToCoordinate.Location = new System.Drawing.Point(31, 40);
            this.RbAddressToCoordinate.Name = "RbAddressToCoordinate";
            this.RbAddressToCoordinate.Size = new System.Drawing.Size(312, 29);
            this.RbAddressToCoordinate.TabIndex = 0;
            this.RbAddressToCoordinate.TabStop = true;
            this.RbAddressToCoordinate.Text = "From Address to Coordinate";
            this.RbAddressToCoordinate.UseVisualStyleBackColor = true;
            this.RbAddressToCoordinate.CheckedChanged += new System.EventHandler(this.RbAddressToCoordinate_CheckedChanged);
            // 
            // gbCoordinate
            // 
            this.gbCoordinate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCoordinate.Controls.Add(this.tbLong);
            this.gbCoordinate.Controls.Add(this.label3);
            this.gbCoordinate.Controls.Add(this.tbLat);
            this.gbCoordinate.Controls.Add(this.label2);
            this.gbCoordinate.Enabled = false;
            this.gbCoordinate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCoordinate.Location = new System.Drawing.Point(30, 298);
            this.gbCoordinate.Name = "gbCoordinate";
            this.gbCoordinate.Size = new System.Drawing.Size(449, 138);
            this.gbCoordinate.TabIndex = 4;
            this.gbCoordinate.TabStop = false;
            this.gbCoordinate.Text = "Coordinate";
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(144, 90);
            this.tbLong.Name = "tbLong";
            this.tbLong.Size = new System.Drawing.Size(225, 31);
            this.tbLong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Long";
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(144, 39);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(225, 31);
            this.tbLat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lat:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbCoordinate);
            this.groupBox1.Controls.Add(this.rbAddress);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // rbCoordinate
            // 
            this.rbCoordinate.AutoSize = true;
            this.rbCoordinate.Location = new System.Drawing.Point(221, 40);
            this.rbCoordinate.Name = "rbCoordinate";
            this.rbCoordinate.Size = new System.Drawing.Size(148, 29);
            this.rbCoordinate.TabIndex = 1;
            this.rbCoordinate.Text = "Coordinate";
            this.rbCoordinate.UseVisualStyleBackColor = true;
            // 
            // rbAddress
            // 
            this.rbAddress.AutoSize = true;
            this.rbAddress.Checked = true;
            this.rbAddress.Location = new System.Drawing.Point(31, 40);
            this.rbAddress.Name = "rbAddress";
            this.rbAddress.Size = new System.Drawing.Size(122, 29);
            this.rbAddress.TabIndex = 0;
            this.rbAddress.TabStop = true;
            this.rbAddress.Text = "Address";
            this.rbAddress.UseVisualStyleBackColor = true;
            this.rbAddress.CheckedChanged += new System.EventHandler(this.rbAddress_CheckedChanged);
            // 
            // BtnSearchByAddress
            // 
            this.BtnSearchByAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchByAddress.Location = new System.Drawing.Point(207, 462);
            this.BtnSearchByAddress.Name = "BtnSearchByAddress";
            this.BtnSearchByAddress.Size = new System.Drawing.Size(181, 49);
            this.BtnSearchByAddress.TabIndex = 2;
            this.BtnSearchByAddress.Text = "OK";
            this.BtnSearchByAddress.UseVisualStyleBackColor = true;
            this.BtnSearchByAddress.Click += new System.EventHandler(this.BtnSearchByAddress_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(24, 222);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(375, 31);
            this.tbAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 989);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1914, 995);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.BtnSearchByAddress_Click);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbCoordinate.ResumeLayout(false);
            this.gbCoordinate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearchByAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCoordinate;
        private System.Windows.Forms.RadioButton rbAddress;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RbCoordinateToAddress;
        private System.Windows.Forms.RadioButton RbAddressToCoordinate;
        private System.Windows.Forms.GroupBox gbCoordinate;
        private System.Windows.Forms.TextBox tbLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbMyIP;
    }
}

