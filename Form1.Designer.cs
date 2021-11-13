
namespace C_sharp_database_class_section_2
{
    partial class frmDataEntry
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
            this.grbDataEntry = new System.Windows.Forms.GroupBox();
            this.grbTimer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbDataEntry.SuspendLayout();
            this.grbTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDataEntry
            // 
            this.grbDataEntry.Controls.Add(this.btnClear);
            this.grbDataEntry.Controls.Add(this.btnAccept);
            this.grbDataEntry.Controls.Add(this.txtZip);
            this.grbDataEntry.Controls.Add(this.txtState);
            this.grbDataEntry.Controls.Add(this.txtCity);
            this.grbDataEntry.Controls.Add(this.txtAddress);
            this.grbDataEntry.Controls.Add(this.txtName);
            this.grbDataEntry.Controls.Add(this.label5);
            this.grbDataEntry.Controls.Add(this.label4);
            this.grbDataEntry.Controls.Add(this.label3);
            this.grbDataEntry.Controls.Add(this.label2);
            this.grbDataEntry.Controls.Add(this.label1);
            this.grbDataEntry.Location = new System.Drawing.Point(12, 37);
            this.grbDataEntry.Name = "grbDataEntry";
            this.grbDataEntry.Size = new System.Drawing.Size(236, 425);
            this.grbDataEntry.TabIndex = 0;
            this.grbDataEntry.TabStop = false;
            this.grbDataEntry.Text = "DataEntry";
            // 
            // grbTimer
            // 
            this.grbTimer.Controls.Add(this.btnExit);
            this.grbTimer.Controls.Add(this.btnPause);
            this.grbTimer.Controls.Add(this.btnStart);
            this.grbTimer.Controls.Add(this.txtTimer);
            this.grbTimer.Location = new System.Drawing.Point(269, 37);
            this.grbTimer.Name = "grbTimer";
            this.grbTimer.Size = new System.Drawing.Size(236, 420);
            this.grbTimer.TabIndex = 0;
            this.grbTimer.TabStop = false;
            this.grbTimer.Text = "Timer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(75, 159);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(145, 26);
            this.txtCity.TabIndex = 7;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(75, 226);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(145, 26);
            this.txtState.TabIndex = 8;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(75, 296);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(145, 26);
            this.txtZip.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(9, 368);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 38);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(19, 26);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(155, 30);
            this.txtTimer.TabIndex = 100;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 101);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 38);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(19, 175);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 38);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 482);
            this.Controls.Add(this.grbTimer);
            this.Controls.Add(this.grbDataEntry);
            this.Name = "frmDataEntry";
            this.Text = "Data Entry Form";
            this.Load += new System.EventHandler(this.frmDataEntry_Load);
            this.grbDataEntry.ResumeLayout(false);
            this.grbDataEntry.PerformLayout();
            this.grbTimer.ResumeLayout(false);
            this.grbTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDataEntry;
        private System.Windows.Forms.GroupBox grbTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTimer;
    }
}

