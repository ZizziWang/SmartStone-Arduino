namespace WindowsFormsApplication1
{
    partial class StbMon_GUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.serialPortComBox = new System.Windows.Forms.ComboBox();
            this.textBoxSat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIncX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIncY = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.textBoxAY = new System.Windows.Forms.TextBox();
            this.textBoxAZ = new System.Windows.Forms.TextBox();
            this.textBoxGX = new System.Windows.Forms.TextBox();
            this.textBoxGY = new System.Windows.Forms.TextBox();
            this.textBoxGZ = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonOffset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(330, 40);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopButton.Location = new System.Drawing.Point(430, 40);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 40);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveButton.Location = new System.Drawing.Point(530, 40);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 40);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // serialPortComBox
            // 
            this.serialPortComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortComBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serialPortComBox.FormattingEnabled = true;
            this.serialPortComBox.ItemHeight = 24;
            this.serialPortComBox.Location = new System.Drawing.Point(170, 45);
            this.serialPortComBox.Name = "serialPortComBox";
            this.serialPortComBox.Size = new System.Drawing.Size(120, 32);
            this.serialPortComBox.TabIndex = 3;
            this.serialPortComBox.TabStop = false;
            this.serialPortComBox.Tag = "";
            this.serialPortComBox.SelectedIndexChanged += new System.EventHandler(this.serialPortComBox_SelectedIndexChanged);
            // 
            // textBoxSat
            // 
            this.textBoxSat.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSat.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxSat.Location = new System.Drawing.Point(170, 115);
            this.textBoxSat.Name = "textBoxSat";
            this.textBoxSat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSat.Size = new System.Drawing.Size(100, 33);
            this.textBoxSat.TabIndex = 4;
            this.textBoxSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSat.TextChanged += new System.EventHandler(this.resultText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Degree of\r\nSaturation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCap
            // 
            this.textBoxCap.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCap.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCap.Location = new System.Drawing.Point(470, 115);
            this.textBoxCap.Name = "textBoxCap";
            this.textBoxCap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCap.Size = new System.Drawing.Size(100, 33);
            this.textBoxCap.TabIndex = 7;
            this.textBoxCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(330, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Capacitance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(280, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(580, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "pf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(50, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 48);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inclination\r\nX - Direct";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIncX
            // 
            this.textBoxIncX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIncX.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxIncX.Location = new System.Drawing.Point(170, 195);
            this.textBoxIncX.Name = "textBoxIncX";
            this.textBoxIncX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIncX.Size = new System.Drawing.Size(100, 33);
            this.textBoxIncX.TabIndex = 12;
            this.textBoxIncX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(335, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 48);
            this.label7.TabIndex = 13;
            this.label7.Text = "Inclination\r\nY - Direct";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIncY
            // 
            this.textBoxIncY.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIncY.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxIncY.Location = new System.Drawing.Point(470, 195);
            this.textBoxIncY.Name = "textBoxIncY";
            this.textBoxIncY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIncY.Size = new System.Drawing.Size(100, 33);
            this.textBoxIncY.TabIndex = 14;
            this.textBoxIncY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxData.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxData.Location = new System.Drawing.Point(50, 435);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(550, 120);
            this.textBoxData.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(280, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(580, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(40, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 48);
            this.label10.TabIndex = 18;
            this.label10.Text = "Accel X\r\n- Direct";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(230, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 48);
            this.label11.TabIndex = 19;
            this.label11.Text = "Accel Y\r\n- Direct";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(430, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 48);
            this.label12.TabIndex = 20;
            this.label12.Text = "Accel Z\r\n- Direct";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(40, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 48);
            this.label13.TabIndex = 21;
            this.label13.Text = "Gyro X\r\n- Direct";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(230, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 48);
            this.label14.TabIndex = 22;
            this.label14.Text = "Gyro Y\r\n- Direct";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(430, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 48);
            this.label15.TabIndex = 23;
            this.label15.Text = "Gyro Z\r\n- Direct";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAX
            // 
            this.textBoxAX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAX.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAX.Location = new System.Drawing.Point(120, 275);
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAX.Size = new System.Drawing.Size(100, 33);
            this.textBoxAX.TabIndex = 24;
            this.textBoxAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAY
            // 
            this.textBoxAY.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAY.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAY.Location = new System.Drawing.Point(320, 275);
            this.textBoxAY.Name = "textBoxAY";
            this.textBoxAY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAY.Size = new System.Drawing.Size(100, 33);
            this.textBoxAY.TabIndex = 25;
            this.textBoxAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAZ
            // 
            this.textBoxAZ.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAZ.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAZ.Location = new System.Drawing.Point(520, 275);
            this.textBoxAZ.Name = "textBoxAZ";
            this.textBoxAZ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAZ.Size = new System.Drawing.Size(100, 33);
            this.textBoxAZ.TabIndex = 26;
            this.textBoxAZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGX
            // 
            this.textBoxGX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGX.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGX.Location = new System.Drawing.Point(120, 355);
            this.textBoxGX.Name = "textBoxGX";
            this.textBoxGX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGX.Size = new System.Drawing.Size(100, 33);
            this.textBoxGX.TabIndex = 27;
            this.textBoxGX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGY
            // 
            this.textBoxGY.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGY.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGY.Location = new System.Drawing.Point(320, 355);
            this.textBoxGY.Name = "textBoxGY";
            this.textBoxGY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGY.Size = new System.Drawing.Size(100, 33);
            this.textBoxGY.TabIndex = 28;
            this.textBoxGY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGZ
            // 
            this.textBoxGZ.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGZ.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGZ.Location = new System.Drawing.Point(520, 355);
            this.textBoxGZ.Name = "textBoxGZ";
            this.textBoxGZ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGZ.Size = new System.Drawing.Size(100, 33);
            this.textBoxGZ.TabIndex = 29;
            this.textBoxGZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(50, 408);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 24);
            this.label16.TabIndex = 30;
            this.label16.Text = "All Data";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(51, 565);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 24);
            this.label17.TabIndex = 31;
            this.label17.Text = "System Time";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxTime.Location = new System.Drawing.Point(185, 560);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTime.Size = new System.Drawing.Size(406, 33);
            this.textBoxTime.TabIndex = 32;
            // 
            // buttonOffset
            // 
            this.buttonOffset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOffset.Location = new System.Drawing.Point(160, 156);
            this.buttonOffset.Name = "buttonOffset";
            this.buttonOffset.Size = new System.Drawing.Size(419, 29);
            this.buttonOffset.TabIndex = 33;
            this.buttonOffset.Text = "Set Current Value as Offset";
            this.buttonOffset.UseVisualStyleBackColor = true;
            this.buttonOffset.Click += new System.EventHandler(this.buttonOffset_Click);
            // 
            // StbMon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 611);
            this.Controls.Add(this.buttonOffset);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxGZ);
            this.Controls.Add(this.textBoxGY);
            this.Controls.Add(this.textBoxGX);
            this.Controls.Add(this.textBoxAZ);
            this.Controls.Add(this.textBoxAY);
            this.Controls.Add(this.textBoxAX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxIncY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIncX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSat);
            this.Controls.Add(this.serialPortComBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "StbMon_GUI";
            this.Text = "StbMon_GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox serialPortComBox;
        private System.Windows.Forms.TextBox textBoxSat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIncX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIncY;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.TextBox textBoxAY;
        private System.Windows.Forms.TextBox textBoxAZ;
        private System.Windows.Forms.TextBox textBoxGX;
        private System.Windows.Forms.TextBox textBoxGY;
        private System.Windows.Forms.TextBox textBoxGZ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonOffset;
    }
}

