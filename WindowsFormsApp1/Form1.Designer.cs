namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.btnFloor0 = new System.Windows.Forms.Button();
            this.btnDoorOpen = new System.Windows.Forms.Button();
            this.btnDoorClose = new System.Windows.Forms.Button();
            this.downRightDoor = new System.Windows.Forms.Panel();
            this.downLeftDoor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.upLeftDoor = new System.Windows.Forms.Panel();
            this.upRightDoor = new System.Windows.Forms.Panel();
            this.btnDownRequest = new System.Windows.Forms.Button();
            this.btnUpRequest = new System.Windows.Forms.Button();
            this.lift = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tmr_upOpen = new System.Windows.Forms.Timer(this.components);
            this.tmr_upClose = new System.Windows.Forms.Timer(this.components);
            this.tmr_downOpen = new System.Windows.Forms.Timer(this.components);
            this.tmr_downClose = new System.Windows.Forms.Timer(this.components);
            this.tmr_liftUp = new System.Windows.Forms.Timer(this.components);
            this.tmr_liftDown = new System.Windows.Forms.Timer(this.components);
            this.liftLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(528, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elevator Control System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.liftLocation);
            this.panel1.Controls.Add(this.btnFloor1);
            this.panel1.Controls.Add(this.btnFloor0);
            this.panel1.Controls.Add(this.btnDoorOpen);
            this.panel1.Controls.Add(this.btnDoorClose);
            this.panel1.Location = new System.Drawing.Point(409, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 303);
            this.panel1.TabIndex = 1;
            // 
            // btnFloor1
            // 
            this.btnFloor1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor1.Location = new System.Drawing.Point(142, 124);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(75, 56);
            this.btnFloor1.TabIndex = 3;
            this.btnFloor1.Text = "1";
            this.btnFloor1.UseVisualStyleBackColor = true;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // btnFloor0
            // 
            this.btnFloor0.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor0.Location = new System.Drawing.Point(27, 124);
            this.btnFloor0.Name = "btnFloor0";
            this.btnFloor0.Size = new System.Drawing.Size(75, 56);
            this.btnFloor0.TabIndex = 2;
            this.btnFloor0.Text = "0";
            this.btnFloor0.UseVisualStyleBackColor = true;
            this.btnFloor0.Click += new System.EventHandler(this.btnFloor0_Click);
            // 
            // btnDoorOpen
            // 
            this.btnDoorOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnDoorOpen.Image")));
            this.btnDoorOpen.Location = new System.Drawing.Point(142, 200);
            this.btnDoorOpen.Name = "btnDoorOpen";
            this.btnDoorOpen.Size = new System.Drawing.Size(75, 56);
            this.btnDoorOpen.TabIndex = 1;
            this.btnDoorOpen.UseVisualStyleBackColor = true;
            this.btnDoorOpen.Click += new System.EventHandler(this.btnDoorOpen_Click);
            // 
            // btnDoorClose
            // 
            this.btnDoorClose.Image = global::WindowsFormsApp1.Properties.Resources.icons8_merge_vertical_48;
            this.btnDoorClose.Location = new System.Drawing.Point(27, 200);
            this.btnDoorClose.Name = "btnDoorClose";
            this.btnDoorClose.Size = new System.Drawing.Size(75, 56);
            this.btnDoorClose.TabIndex = 0;
            this.btnDoorClose.UseVisualStyleBackColor = true;
            this.btnDoorClose.Click += new System.EventHandler(this.btnDoorClose_Click);
            // 
            // downRightDoor
            // 
            this.downRightDoor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.downRightDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downRightDoor.Location = new System.Drawing.Point(120, 304);
            this.downRightDoor.Name = "downRightDoor";
            this.downRightDoor.Size = new System.Drawing.Size(51, 100);
            this.downRightDoor.TabIndex = 6;
            // 
            // downLeftDoor
            // 
            this.downLeftDoor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.downLeftDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downLeftDoor.Location = new System.Drawing.Point(69, 304);
            this.downLeftDoor.Name = "downLeftDoor";
            this.downLeftDoor.Size = new System.Drawing.Size(51, 100);
            this.downLeftDoor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ground Floor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Floor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Red;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.upLeftDoor);
            this.panel8.Controls.Add(this.upRightDoor);
            this.panel8.Controls.Add(this.btnDownRequest);
            this.panel8.Controls.Add(this.btnUpRequest);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.downLeftDoor);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.downRightDoor);
            this.panel8.Controls.Add(this.lift);
            this.panel8.Location = new System.Drawing.Point(24, 154);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(335, 459);
            this.panel8.TabIndex = 10;
            // 
            // upLeftDoor
            // 
            this.upLeftDoor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.upLeftDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upLeftDoor.Location = new System.Drawing.Point(70, 77);
            this.upLeftDoor.Name = "upLeftDoor";
            this.upLeftDoor.Size = new System.Drawing.Size(51, 100);
            this.upLeftDoor.TabIndex = 2;
            // 
            // upRightDoor
            // 
            this.upRightDoor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.upRightDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upRightDoor.Location = new System.Drawing.Point(120, 77);
            this.upRightDoor.Name = "upRightDoor";
            this.upRightDoor.Size = new System.Drawing.Size(51, 100);
            this.upRightDoor.TabIndex = 3;
            // 
            // btnDownRequest
            // 
            this.btnDownRequest.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage;
            this.btnDownRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownRequest.Location = new System.Drawing.Point(224, 335);
            this.btnDownRequest.Name = "btnDownRequest";
            this.btnDownRequest.Size = new System.Drawing.Size(47, 36);
            this.btnDownRequest.TabIndex = 12;
            this.btnDownRequest.UseVisualStyleBackColor = true;
            this.btnDownRequest.Click += new System.EventHandler(this.btnDownRequest_Click);
            // 
            // btnUpRequest
            // 
            this.btnUpRequest.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__1_;
            this.btnUpRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpRequest.Location = new System.Drawing.Point(224, 99);
            this.btnUpRequest.Name = "btnUpRequest";
            this.btnUpRequest.Size = new System.Drawing.Size(47, 36);
            this.btnUpRequest.TabIndex = 11;
            this.btnUpRequest.UseVisualStyleBackColor = true;
            this.btnUpRequest.Click += new System.EventHandler(this.btnUpRequest_Click);
            // 
            // lift
            // 
            this.lift.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lift.BackgroundImage")));
            this.lift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lift.Location = new System.Drawing.Point(70, 305);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(101, 100);
            this.lift.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(787, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 561);
            this.dataGridView1.TabIndex = 11;
            // 
            // tmr_upOpen
            // 
            this.tmr_upOpen.Interval = 10;
            this.tmr_upOpen.Tick += new System.EventHandler(this.tmr_upOpen_Tick);
            // 
            // tmr_upClose
            // 
            this.tmr_upClose.Interval = 10;
            this.tmr_upClose.Tick += new System.EventHandler(this.tmr_upClose_Tick);
            // 
            // tmr_downOpen
            // 
            this.tmr_downOpen.Interval = 10;
            this.tmr_downOpen.Tick += new System.EventHandler(this.tmr_downOpen_Tick);
            // 
            // tmr_downClose
            // 
            this.tmr_downClose.Interval = 10;
            this.tmr_downClose.Tick += new System.EventHandler(this.tmr_downClose_Tick);
            // 
            // tmr_liftUp
            // 
            this.tmr_liftUp.Interval = 10;
            this.tmr_liftUp.Tick += new System.EventHandler(this.tmr_liftUp_Tick);
            // 
            // tmr_liftDown
            // 
            this.tmr_liftDown.Interval = 10;
            this.tmr_liftDown.Tick += new System.EventHandler(this.tmr_liftDown_Tick);
            // 
            // liftLocation
            // 
            this.liftLocation.AutoSize = true;
            this.liftLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.liftLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liftLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.liftLocation.Location = new System.Drawing.Point(95, 55);
            this.liftLocation.Name = "liftLocation";
            this.liftLocation.Size = new System.Drawing.Size(38, 41);
            this.liftLocation.TabIndex = 4;
            this.liftLocation.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.Location = new System.Drawing.Point(97, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label5.Location = new System.Drawing.Point(97, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 41);
            this.label5.TabIndex = 13;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Button btnFloor0;
        private System.Windows.Forms.Button btnDoorOpen;
        private System.Windows.Forms.Button btnDoorClose;
        private System.Windows.Forms.Panel upLeftDoor;
        private System.Windows.Forms.Panel upRightDoor;
        private System.Windows.Forms.Panel lift;
        private System.Windows.Forms.Panel downRightDoor;
        private System.Windows.Forms.Panel downLeftDoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUpRequest;
        private System.Windows.Forms.Button btnDownRequest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer tmr_upOpen;
        private System.Windows.Forms.Timer tmr_upClose;
        private System.Windows.Forms.Timer tmr_downOpen;
        private System.Windows.Forms.Timer tmr_downClose;
        private System.Windows.Forms.Timer tmr_liftUp;
        private System.Windows.Forms.Timer tmr_liftDown;
        private System.Windows.Forms.Label liftLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

