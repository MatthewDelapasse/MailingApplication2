
namespace TheMailingListApplication
{
    partial class frmMailingList
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
            this.grpMail = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.timSeconds = new System.Windows.Forms.Timer(this.components);
            this.grpMail.SuspendLayout();
            this.grpTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMail
            // 
            this.grpMail.Controls.Add(this.btnClear);
            this.grpMail.Controls.Add(this.btnAccept);
            this.grpMail.Controls.Add(this.txtZip);
            this.grpMail.Controls.Add(this.txtState);
            this.grpMail.Controls.Add(this.txtCity);
            this.grpMail.Controls.Add(this.txtAddress);
            this.grpMail.Controls.Add(this.txtName);
            this.grpMail.Controls.Add(this.label5);
            this.grpMail.Controls.Add(this.label4);
            this.grpMail.Controls.Add(this.label3);
            this.grpMail.Controls.Add(this.label2);
            this.grpMail.Controls.Add(this.label1);
            this.grpMail.Enabled = false;
            this.grpMail.Location = new System.Drawing.Point(12, 25);
            this.grpMail.Name = "grpMail";
            this.grpMail.Size = new System.Drawing.Size(565, 300);
            this.grpMail.TabIndex = 0;
            this.grpMail.TabStop = false;
            this.grpMail.Text = "Address Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(168, 244);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 38);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(362, 203);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(169, 26);
            this.txtZip.TabIndex = 5;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(123, 203);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(184, 26);
            this.txtState.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(123, 149);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(408, 26);
            this.txtCity.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(408, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(408, 26);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.btnExit);
            this.grpTime.Controls.Add(this.btnPause);
            this.grpTime.Controls.Add(this.btnStart);
            this.grpTime.Controls.Add(this.txtElapsedTime);
            this.grpTime.Location = new System.Drawing.Point(596, 25);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(209, 300);
            this.grpTime.TabIndex = 1;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Elapsed Time";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(49, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(49, 167);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(107, 49);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(49, 98);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 49);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Enabled = false;
            this.txtElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElapsedTime.Location = new System.Drawing.Point(31, 35);
            this.txtElapsedTime.Multiline = true;
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.Size = new System.Drawing.Size(142, 47);
            this.txtElapsedTime.TabIndex = 0;
            this.txtElapsedTime.Text = "00:00:00";
            this.txtElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timSeconds
            // 
            this.timSeconds.Interval = 1000;
            // 
            // frmMailingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 375);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMailingList";
            this.Text = "Mailing List Application";
            this.grpMail.ResumeLayout(false);
            this.grpMail.PerformLayout();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMail;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtElapsedTime;
        private System.Windows.Forms.Timer timSeconds;
    }
}

