namespace Elevator_System
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnElevatorRequestToGFloor = new System.Windows.Forms.Button();
            this.btnElevatorRequestToFFloor = new System.Windows.Forms.Button();
            this.lblDisplayFloorNumberInsideElevator = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRequestLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRequestToFFloor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRequestToGFloor = new System.Windows.Forms.Button();
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.lblDisplayFloorNumber = new System.Windows.Forms.Label();
            this.tmrTimeDurartion = new System.Windows.Forms.Timer(this.components);
            this.txtBoxRequestLog = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox0.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnElevatorRequestToGFloor);
            this.groupBox3.Controls.Add(this.btnElevatorRequestToFFloor);
            this.groupBox3.Controls.Add(this.lblDisplayFloorNumberInsideElevator);
            this.groupBox3.Location = new System.Drawing.Point(301, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 209);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inside Elevator";
            // 
            // btnElevatorRequestToGFloor
            // 
            this.btnElevatorRequestToGFloor.Location = new System.Drawing.Point(48, 123);
            this.btnElevatorRequestToGFloor.Name = "btnElevatorRequestToGFloor";
            this.btnElevatorRequestToGFloor.Size = new System.Drawing.Size(75, 23);
            this.btnElevatorRequestToGFloor.TabIndex = 2;
            this.btnElevatorRequestToGFloor.Text = "0";
            this.btnElevatorRequestToGFloor.UseVisualStyleBackColor = true;
            this.btnElevatorRequestToGFloor.Click += new System.EventHandler(this.btnElevatorRequestToGFloor_Click);
            // 
            // btnElevatorRequestToFFloor
            // 
            this.btnElevatorRequestToFFloor.Location = new System.Drawing.Point(48, 74);
            this.btnElevatorRequestToFFloor.Name = "btnElevatorRequestToFFloor";
            this.btnElevatorRequestToFFloor.Size = new System.Drawing.Size(75, 23);
            this.btnElevatorRequestToFFloor.TabIndex = 3;
            this.btnElevatorRequestToFFloor.Text = "1";
            this.btnElevatorRequestToFFloor.UseVisualStyleBackColor = true;
            this.btnElevatorRequestToFFloor.Click += new System.EventHandler(this.btnElevatorRequestToFFloor_Click);
            // 
            // lblDisplayFloorNumberInsideElevator
            // 
            this.lblDisplayFloorNumberInsideElevator.AutoSize = true;
            this.lblDisplayFloorNumberInsideElevator.Location = new System.Drawing.Point(20, 33);
            this.lblDisplayFloorNumberInsideElevator.Name = "lblDisplayFloorNumberInsideElevator";
            this.lblDisplayFloorNumberInsideElevator.Size = new System.Drawing.Size(13, 13);
            this.lblDisplayFloorNumberInsideElevator.TabIndex = 3;
            this.lblDisplayFloorNumberInsideElevator.Text = "--";
            this.lblDisplayFloorNumberInsideElevator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxRequestLog);
            this.groupBox4.Controls.Add(this.btnRequestLog);
            this.groupBox4.Location = new System.Drawing.Point(508, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 206);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log Information";
            // 
            // btnRequestLog
            // 
            this.btnRequestLog.Location = new System.Drawing.Point(7, 20);
            this.btnRequestLog.Name = "btnRequestLog";
            this.btnRequestLog.Size = new System.Drawing.Size(150, 23);
            this.btnRequestLog.TabIndex = 4;
            this.btnRequestLog.Text = "Request Log";
            this.btnRequestLog.UseVisualStyleBackColor = true;
            this.btnRequestLog.Click += new System.EventHandler(this.btnRequestLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequestToFFloor);
            this.groupBox1.Location = new System.Drawing.Point(113, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Floor 0";
            // 
            // btnRequestToFFloor
            // 
            this.btnRequestToFFloor.Location = new System.Drawing.Point(38, 36);
            this.btnRequestToFFloor.Name = "btnRequestToFFloor";
            this.btnRequestToFFloor.Size = new System.Drawing.Size(75, 23);
            this.btnRequestToFFloor.TabIndex = 1;
            this.btnRequestToFFloor.Text = "1";
            this.btnRequestToFFloor.UseVisualStyleBackColor = true;
            this.btnRequestToFFloor.Click += new System.EventHandler(this.btnRequestToFFloor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRequestToGFloor);
            this.groupBox2.Location = new System.Drawing.Point(113, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Floor 1";
            // 
            // btnRequestToGFloor
            // 
            this.btnRequestToGFloor.Location = new System.Drawing.Point(38, 34);
            this.btnRequestToGFloor.Name = "btnRequestToGFloor";
            this.btnRequestToGFloor.Size = new System.Drawing.Size(75, 23);
            this.btnRequestToGFloor.TabIndex = 0;
            this.btnRequestToGFloor.Text = "0";
            this.btnRequestToGFloor.UseVisualStyleBackColor = true;
            this.btnRequestToGFloor.Click += new System.EventHandler(this.btnRequestToGFloor_Click);
            // 
            // groupBox0
            // 
            this.groupBox0.Controls.Add(this.lblDisplayFloorNumber);
            this.groupBox0.Location = new System.Drawing.Point(113, 65);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.Size = new System.Drawing.Size(150, 43);
            this.groupBox0.TabIndex = 2;
            this.groupBox0.TabStop = false;
            this.groupBox0.Text = "Floor Number Display";
            // 
            // lblDisplayFloorNumber
            // 
            this.lblDisplayFloorNumber.AutoSize = true;
            this.lblDisplayFloorNumber.Location = new System.Drawing.Point(55, 16);
            this.lblDisplayFloorNumber.Name = "lblDisplayFloorNumber";
            this.lblDisplayFloorNumber.Size = new System.Drawing.Size(13, 13);
            this.lblDisplayFloorNumber.TabIndex = 0;
            this.lblDisplayFloorNumber.Text = "--";
            this.lblDisplayFloorNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTimeDurartion
            // 
            this.tmrTimeDurartion.Interval = 1000;
            this.tmrTimeDurartion.Tick += new System.EventHandler(this.tmrTimeDurartion_Tick);
            // 
            // txtBoxRequestLog
            // 
            this.txtBoxRequestLog.Location = new System.Drawing.Point(7, 49);
            this.txtBoxRequestLog.Name = "txtBoxRequestLog";
            this.txtBoxRequestLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtBoxRequestLog.Size = new System.Drawing.Size(150, 151);
            this.txtBoxRequestLog.TabIndex = 5;
            this.txtBoxRequestLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 362);
            this.Controls.Add(this.groupBox0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox0.ResumeLayout(false);
            this.groupBox0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnElevatorRequestToGFloor;
        private System.Windows.Forms.Button btnElevatorRequestToFFloor;
        private System.Windows.Forms.Label lblDisplayFloorNumberInsideElevator;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRequestToFFloor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRequestToGFloor;
        private System.Windows.Forms.Button btnRequestLog;
        private System.Windows.Forms.GroupBox groupBox0;
        private System.Windows.Forms.Label lblDisplayFloorNumber;
        private System.Windows.Forms.Timer tmrTimeDurartion;
        private System.Windows.Forms.RichTextBox txtBoxRequestLog;
    }
}

