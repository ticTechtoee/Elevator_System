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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnElevatorRequestToGFloor = new System.Windows.Forms.Button();
            this.btnElevatorRequestToFFloor = new System.Windows.Forms.Button();
            this.lblDisplayFloorNumberInsideElevator = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRequestToFFloor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRequestToGFloor = new System.Windows.Forms.Button();
            this.btnRequestLog = new System.Windows.Forms.Button();
            this.groupBox0 = new System.Windows.Forms.GroupBox();
            this.lblDisplayFloorNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inside Elevator";
            // 
            // btnElevatorRequestToGFloor
            // 
            this.btnElevatorRequestToGFloor.Location = new System.Drawing.Point(48, 123);
            this.btnElevatorRequestToGFloor.Name = "btnElevatorRequestToGFloor";
            this.btnElevatorRequestToGFloor.Size = new System.Drawing.Size(75, 23);
            this.btnElevatorRequestToGFloor.TabIndex = 5;
            this.btnElevatorRequestToGFloor.Text = "0";
            this.btnElevatorRequestToGFloor.UseVisualStyleBackColor = true;
            // 
            // btnElevatorRequestToFFloor
            // 
            this.btnElevatorRequestToFFloor.Location = new System.Drawing.Point(48, 74);
            this.btnElevatorRequestToFFloor.Name = "btnElevatorRequestToFFloor";
            this.btnElevatorRequestToFFloor.Size = new System.Drawing.Size(75, 23);
            this.btnElevatorRequestToFFloor.TabIndex = 4;
            this.btnElevatorRequestToFFloor.Text = "1";
            this.btnElevatorRequestToFFloor.UseVisualStyleBackColor = true;
            // 
            // lblDisplayFloorNumberInsideElevator
            // 
            this.lblDisplayFloorNumberInsideElevator.AutoSize = true;
            this.lblDisplayFloorNumberInsideElevator.Location = new System.Drawing.Point(64, 33);
            this.lblDisplayFloorNumberInsideElevator.Name = "lblDisplayFloorNumberInsideElevator";
            this.lblDisplayFloorNumberInsideElevator.Size = new System.Drawing.Size(13, 13);
            this.lblDisplayFloorNumberInsideElevator.TabIndex = 3;
            this.lblDisplayFloorNumberInsideElevator.Text = "--";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnRequestLog);
            this.groupBox4.Location = new System.Drawing.Point(508, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 206);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRequestToFFloor);
            this.groupBox1.Location = new System.Drawing.Point(113, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Floor 0";
            // 
            // btnRequestToFFloor
            // 
            this.btnRequestToFFloor.Location = new System.Drawing.Point(38, 36);
            this.btnRequestToFFloor.Name = "btnRequestToFFloor";
            this.btnRequestToFFloor.Size = new System.Drawing.Size(75, 23);
            this.btnRequestToFFloor.TabIndex = 5;
            this.btnRequestToFFloor.Text = "1";
            this.btnRequestToFFloor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRequestToGFloor);
            this.groupBox2.Location = new System.Drawing.Point(113, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Floor 1";
            // 
            // btnRequestToGFloor
            // 
            this.btnRequestToGFloor.Location = new System.Drawing.Point(38, 34);
            this.btnRequestToGFloor.Name = "btnRequestToGFloor";
            this.btnRequestToGFloor.Size = new System.Drawing.Size(75, 23);
            this.btnRequestToGFloor.TabIndex = 9;
            this.btnRequestToGFloor.Text = "0";
            this.btnRequestToGFloor.UseVisualStyleBackColor = true;
            // 
            // btnRequestLog
            // 
            this.btnRequestLog.Location = new System.Drawing.Point(7, 20);
            this.btnRequestLog.Name = "btnRequestLog";
            this.btnRequestLog.Size = new System.Drawing.Size(150, 23);
            this.btnRequestLog.TabIndex = 0;
            this.btnRequestLog.Text = "Request Log";
            this.btnRequestLog.UseVisualStyleBackColor = true;
            // 
            // groupBox0
            // 
            this.groupBox0.Controls.Add(this.lblDisplayFloorNumber);
            this.groupBox0.Location = new System.Drawing.Point(113, 65);
            this.groupBox0.Name = "groupBox0";
            this.groupBox0.Size = new System.Drawing.Size(150, 43);
            this.groupBox0.TabIndex = 9;
            this.groupBox0.TabStop = false;
            this.groupBox0.Text = "Floor Number Display";
            // 
            // lblDisplayFloorNumber
            // 
            this.lblDisplayFloorNumber.AutoSize = true;
            this.lblDisplayFloorNumber.Location = new System.Drawing.Point(62, 16);
            this.lblDisplayFloorNumber.Name = "lblDisplayFloorNumber";
            this.lblDisplayFloorNumber.Size = new System.Drawing.Size(13, 13);
            this.lblDisplayFloorNumber.TabIndex = 0;
            this.lblDisplayFloorNumber.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label1;
    }
}

