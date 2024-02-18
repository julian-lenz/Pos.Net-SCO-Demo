namespace PosDemo
{
    partial class PosDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosDemo));
            this.powerButton = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.printerText = new System.Windows.Forms.TextBox();
            this.printerTextLabel = new System.Windows.Forms.Label();
            this.selectColorLabel = new System.Windows.Forms.Label();
            this.blinkButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blinkButton2 = new System.Windows.Forms.RadioButton();
            this.staticButton = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this.lightModeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.Location = new System.Drawing.Point(78, 67);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(282, 384);
            this.powerButton.TabIndex = 0;
            this.powerButton.Text = "Turn on light";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Red;
            this.color1.Location = new System.Drawing.Point(404, 193);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(214, 132);
            this.color1.TabIndex = 1;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Lime;
            this.color2.Location = new System.Drawing.Point(404, 319);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(214, 132);
            this.color2.TabIndex = 2;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.MediumOrchid;
            this.color3.Location = new System.Drawing.Point(404, 67);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(214, 132);
            this.color3.TabIndex = 3;
            this.color3.UseVisualStyleBackColor = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // printerText
            // 
            this.printerText.Location = new System.Drawing.Point(78, 560);
            this.printerText.Multiline = true;
            this.printerText.Name = "printerText";
            this.printerText.Size = new System.Drawing.Size(382, 274);
            this.printerText.TabIndex = 4;
            this.printerText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printerTextLabel
            // 
            this.printerTextLabel.AutoSize = true;
            this.printerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerTextLabel.Location = new System.Drawing.Point(73, 514);
            this.printerTextLabel.Name = "printerTextLabel";
            this.printerTextLabel.Size = new System.Drawing.Size(146, 25);
            this.printerTextLabel.TabIndex = 5;
            this.printerTextLabel.Text = "Text to print:";
            // 
            // selectColorLabel
            // 
            this.selectColorLabel.AutoSize = true;
            this.selectColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectColorLabel.Location = new System.Drawing.Point(399, 18);
            this.selectColorLabel.Name = "selectColorLabel";
            this.selectColorLabel.Size = new System.Drawing.Size(164, 25);
            this.selectColorLabel.TabIndex = 6;
            this.selectColorLabel.Text = "Select a color:";
            // 
            // blinkButton1
            // 
            this.blinkButton1.AutoSize = true;
            this.blinkButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blinkButton1.Location = new System.Drawing.Point(16, 76);
            this.blinkButton1.Name = "blinkButton1";
            this.blinkButton1.Size = new System.Drawing.Size(82, 29);
            this.blinkButton1.TabIndex = 7;
            this.blinkButton1.Text = "Blink";
            this.blinkButton1.UseVisualStyleBackColor = true;
            this.blinkButton1.Click += new System.EventHandler(this.blinkButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blinkButton2);
            this.panel1.Controls.Add(this.staticButton);
            this.panel1.Controls.Add(this.blinkButton1);
            this.panel1.Location = new System.Drawing.Point(643, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 171);
            this.panel1.TabIndex = 8;
            // 
            // blinkButton2
            // 
            this.blinkButton2.AutoSize = true;
            this.blinkButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blinkButton2.Location = new System.Drawing.Point(16, 111);
            this.blinkButton2.Name = "blinkButton2";
            this.blinkButton2.Size = new System.Drawing.Size(163, 29);
            this.blinkButton2.TabIndex = 9;
            this.blinkButton2.Text = "Blink (FAST)";
            this.blinkButton2.UseVisualStyleBackColor = true;
            this.blinkButton2.Click += new System.EventHandler(this.blinkButton2_Click);
            // 
            // staticButton
            // 
            this.staticButton.AutoSize = true;
            this.staticButton.Checked = true;
            this.staticButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticButton.Location = new System.Drawing.Point(16, 41);
            this.staticButton.Name = "staticButton";
            this.staticButton.Size = new System.Drawing.Size(90, 29);
            this.staticButton.TabIndex = 8;
            this.staticButton.TabStop = true;
            this.staticButton.Text = "Static";
            this.staticButton.UseVisualStyleBackColor = true;
            this.staticButton.Click += new System.EventHandler(this.staticButton_Click);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(502, 560);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(306, 274);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // lightModeLabel
            // 
            this.lightModeLabel.AutoSize = true;
            this.lightModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightModeLabel.Location = new System.Drawing.Point(638, 18);
            this.lightModeLabel.Name = "lightModeLabel";
            this.lightModeLabel.Size = new System.Drawing.Size(221, 25);
            this.lightModeLabel.TabIndex = 10;
            this.lightModeLabel.Text = "Select a light mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 11;
            // 
            // PosDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 957);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightModeLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectColorLabel);
            this.Controls.Add(this.printerTextLabel);
            this.Controls.Add(this.printerText);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.powerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PosDemo";
            this.Text = "PosDemo";
            this.Load += new System.EventHandler(this.PosDemo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button color3;
        private System.Windows.Forms.TextBox printerText;
        private System.Windows.Forms.Label printerTextLabel;
        private System.Windows.Forms.Label selectColorLabel;
        private System.Windows.Forms.RadioButton blinkButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton blinkButton2;
        private System.Windows.Forms.RadioButton staticButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label lightModeLabel;
        private System.Windows.Forms.Label label1;
    }
}