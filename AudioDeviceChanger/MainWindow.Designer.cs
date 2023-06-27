namespace AudioDeviceChanger
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.headphonesBox = new System.Windows.Forms.TextBox();
            this.headphonesLabel = new System.Windows.Forms.Label();
            this.speakersLabel = new System.Windows.Forms.Label();
            this.speakersBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.defaultHeadphones = new System.Windows.Forms.RadioButton();
            this.defaultSpeakers = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This tool was created for and by SiVGiV in 2017";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.changeDevice);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.openApp);
            // 
            // headphonesBox
            // 
            this.headphonesBox.Location = new System.Drawing.Point(12, 29);
            this.headphonesBox.Name = "headphonesBox";
            this.headphonesBox.Size = new System.Drawing.Size(279, 20);
            this.headphonesBox.TabIndex = 1;
            // 
            // headphonesLabel
            // 
            this.headphonesLabel.AutoSize = true;
            this.headphonesLabel.Location = new System.Drawing.Point(13, 10);
            this.headphonesLabel.Name = "headphonesLabel";
            this.headphonesLabel.Size = new System.Drawing.Size(100, 13);
            this.headphonesLabel.TabIndex = 2;
            this.headphonesLabel.Text = "Headphones name:";
            // 
            // speakersLabel
            // 
            this.speakersLabel.AutoSize = true;
            this.speakersLabel.Location = new System.Drawing.Point(13, 52);
            this.speakersLabel.Name = "speakersLabel";
            this.speakersLabel.Size = new System.Drawing.Size(84, 13);
            this.speakersLabel.TabIndex = 3;
            this.speakersLabel.Text = "Speakers name:";
            // 
            // speakersBox
            // 
            this.speakersBox.Location = new System.Drawing.Point(12, 69);
            this.speakersBox.Name = "speakersBox";
            this.speakersBox.Size = new System.Drawing.Size(279, 20);
            this.speakersBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start up device:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.defaultSpeakers);
            this.panel1.Controls.Add(this.defaultHeadphones);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 28);
            this.panel1.TabIndex = 6;
            // 
            // defaultHeadphones
            // 
            this.defaultHeadphones.AutoSize = true;
            this.defaultHeadphones.Location = new System.Drawing.Point(4, 3);
            this.defaultHeadphones.Name = "defaultHeadphones";
            this.defaultHeadphones.Size = new System.Drawing.Size(86, 17);
            this.defaultHeadphones.TabIndex = 0;
            this.defaultHeadphones.TabStop = true;
            this.defaultHeadphones.Text = "Headphones";
            this.defaultHeadphones.UseVisualStyleBackColor = true;
            this.defaultHeadphones.CheckedChanged += new System.EventHandler(this.onChangeDefault);
            // 
            // defaultSpeakers
            // 
            this.defaultSpeakers.AutoSize = true;
            this.defaultSpeakers.Location = new System.Drawing.Point(95, 3);
            this.defaultSpeakers.Name = "defaultSpeakers";
            this.defaultSpeakers.Size = new System.Drawing.Size(70, 17);
            this.defaultSpeakers.TabIndex = 1;
            this.defaultSpeakers.TabStop = true;
            this.defaultSpeakers.Text = "Speakers";
            this.defaultSpeakers.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(114, 142);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveSettings);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 187);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.speakersBox);
            this.Controls.Add(this.speakersLabel);
            this.Controls.Add(this.headphonesLabel);
            this.Controls.Add(this.headphonesBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Default Audio Device Changer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox headphonesBox;
        private System.Windows.Forms.Label headphonesLabel;
        private System.Windows.Forms.Label speakersLabel;
        private System.Windows.Forms.TextBox speakersBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton defaultSpeakers;
        private System.Windows.Forms.RadioButton defaultHeadphones;
        private System.Windows.Forms.Button saveButton;
    }
}

