namespace Pulse
{
    partial class frmPulse
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
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdPulse = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstvwOutput = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClearSites = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.BackColor = System.Drawing.Color.IndianRed;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(8, 8);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(728, 49);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Pulse";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdPulse
            // 
            this.cmdPulse.Location = new System.Drawing.Point(6, 141);
            this.cmdPulse.Name = "cmdPulse";
            this.cmdPulse.Size = new System.Drawing.Size(75, 23);
            this.cmdPulse.TabIndex = 3;
            this.cmdPulse.Text = "Pulse Sites";
            this.cmdPulse.UseVisualStyleBackColor = true;
            this.cmdPulse.Click += new System.EventHandler(this.cmdPulse_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(713, 116);
            this.txtInput.TabIndex = 4;
            this.txtInput.Text = "http://www.google.com\r\nhttp://www.yahoo.com";
            // 
            // lstvwOutput
            // 
            this.lstvwOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lstvwOutput.FullRowSelect = true;
            this.lstvwOutput.GridLines = true;
            this.lstvwOutput.Location = new System.Drawing.Point(6, 19);
            this.lstvwOutput.Name = "lstvwOutput";
            this.lstvwOutput.Size = new System.Drawing.Size(713, 199);
            this.lstvwOutput.TabIndex = 5;
            this.lstvwOutput.UseCompatibleStateImageBehavior = false;
            this.lstvwOutput.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Site";
            this.ColumnHeader1.Width = 272;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Connection";
            this.ColumnHeader2.Width = 145;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Additional Information";
            this.ColumnHeader3.Width = 177;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClearSites);
            this.groupBox1.Controls.Add(this.cmdPulse);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(11, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sites to Check";
            // 
            // cmdClearSites
            // 
            this.cmdClearSites.Location = new System.Drawing.Point(87, 141);
            this.cmdClearSites.Name = "cmdClearSites";
            this.cmdClearSites.Size = new System.Drawing.Size(75, 23);
            this.cmdClearSites.TabIndex = 7;
            this.cmdClearSites.Text = "Clear";
            this.cmdClearSites.UseVisualStyleBackColor = true;
            this.cmdClearSites.Click += new System.EventHandler(this.cmdClearSites_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdClear);
            this.groupBox2.Controls.Add(this.lstvwOutput);
            this.groupBox2.Location = new System.Drawing.Point(11, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 253);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // cmdClear
            // 
            this.cmdClear.Enabled = false;
            this.cmdClear.Location = new System.Drawing.Point(7, 224);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 6;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // frmPulse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label1);
            this.Name = "frmPulse";
            this.Text = "Pulse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button cmdPulse;
        private System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.ListView lstvwOutput;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdClearSites;
    }
}

