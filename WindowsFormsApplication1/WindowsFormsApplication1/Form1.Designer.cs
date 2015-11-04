namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.resultText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelSat = new System.Windows.Forms.Label();
            this.LabelIncX = new System.Windows.Forms.Label();
            this.LabelIncY = new System.Windows.Forms.Label();
            this.LabelCap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(46, 99);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(106, 41);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopButton.Location = new System.Drawing.Point(179, 99);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(106, 41);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saveButton.Location = new System.Drawing.Point(313, 99);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 41);
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
            this.serialPortComBox.Location = new System.Drawing.Point(179, 38);
            this.serialPortComBox.Name = "serialPortComBox";
            this.serialPortComBox.Size = new System.Drawing.Size(240, 32);
            this.serialPortComBox.TabIndex = 3;
            this.serialPortComBox.TabStop = false;
            this.serialPortComBox.Tag = "";
            this.serialPortComBox.SelectedIndexChanged += new System.EventHandler(this.serialPortComBox_SelectedIndexChanged);
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.Window;
            this.resultText.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultText.Location = new System.Drawing.Point(406, 164);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(239, 435);
            this.resultText.TabIndex = 4;
            this.resultText.TextChanged += new System.EventHandler(this.resultText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F);
            this.label2.Location = new System.Drawing.Point(45, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Degree of Saturation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(45, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inclination - X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F);
            this.label4.Location = new System.Drawing.Point(45, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inclination - Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16F);
            this.label5.Location = new System.Drawing.Point(45, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Capacitance";
            // 
            // LabelSat
            // 
            this.LabelSat.Font = new System.Drawing.Font("新細明體", 16F);
            this.LabelSat.Location = new System.Drawing.Point(45, 225);
            this.LabelSat.Name = "LabelSat";
            this.LabelSat.Size = new System.Drawing.Size(100, 25);
            this.LabelSat.TabIndex = 10;
            this.LabelSat.Text = "Sat";
            this.LabelSat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelIncX
            // 
            this.LabelIncX.Font = new System.Drawing.Font("新細明體", 16F);
            this.LabelIncX.Location = new System.Drawing.Point(45, 319);
            this.LabelIncX.Name = "LabelIncX";
            this.LabelIncX.Size = new System.Drawing.Size(100, 25);
            this.LabelIncX.TabIndex = 11;
            this.LabelIncX.Text = "IncX";
            this.LabelIncX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelIncY
            // 
            this.LabelIncY.Font = new System.Drawing.Font("新細明體", 16F);
            this.LabelIncY.Location = new System.Drawing.Point(45, 422);
            this.LabelIncY.Name = "LabelIncY";
            this.LabelIncY.Size = new System.Drawing.Size(100, 25);
            this.LabelIncY.TabIndex = 12;
            this.LabelIncY.Text = "IncY";
            this.LabelIncY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCap
            // 
            this.LabelCap.Font = new System.Drawing.Font("新細明體", 16F);
            this.LabelCap.Location = new System.Drawing.Point(45, 525);
            this.LabelCap.Name = "LabelCap";
            this.LabelCap.Size = new System.Drawing.Size(100, 25);
            this.LabelCap.TabIndex = 13;
            this.LabelCap.Text = "Cap";
            this.LabelCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelCap.Click += new System.EventHandler(this.LabelCap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 611);
            this.Controls.Add(this.LabelCap);
            this.Controls.Add(this.LabelIncY);
            this.Controls.Add(this.LabelIncX);
            this.Controls.Add(this.LabelSat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.serialPortComBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox serialPortComBox;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelSat;
        private System.Windows.Forms.Label LabelIncX;
        private System.Windows.Forms.Label LabelIncY;
        private System.Windows.Forms.Label LabelCap;
    }
}

