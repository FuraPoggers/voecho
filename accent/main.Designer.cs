namespace accent
{
    partial class Echo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Echo));
            textBox1 = new TextBox();
            voicesReloadButton = new Button();
            speakButton = new Button();
            outputComboBox = new ComboBox();
            voiceComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mainToolTip = new ToolTip(components);
            devicesReload = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            stayOnTop = new ToolStripMenuItem();
            clearTextBox = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 132);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(472, 145);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // voicesReloadButton
            // 
            voicesReloadButton.BackgroundImage = Properties.Resources.view_refresh;
            voicesReloadButton.BackgroundImageLayout = ImageLayout.Center;
            voicesReloadButton.FlatAppearance.BorderSize = 0;
            voicesReloadButton.FlatStyle = FlatStyle.Flat;
            voicesReloadButton.Location = new Point(465, 44);
            voicesReloadButton.Name = "voicesReloadButton";
            voicesReloadButton.Size = new Size(20, 23);
            voicesReloadButton.TabIndex = 5;
            mainToolTip.SetToolTip(voicesReloadButton, "Refresh voices");
            voicesReloadButton.UseVisualStyleBackColor = true;
            voicesReloadButton.Click += voicesReloadButton_Click;
            // 
            // speakButton
            // 
            speakButton.Location = new Point(12, 283);
            speakButton.Name = "speakButton";
            speakButton.Size = new Size(472, 25);
            speakButton.TabIndex = 4;
            speakButton.Text = "Speak";
            speakButton.UseVisualStyleBackColor = true;
            speakButton.Click += speakButton_Click;
            // 
            // outputComboBox
            // 
            outputComboBox.FormattingEnabled = true;
            outputComboBox.Location = new Point(12, 88);
            outputComboBox.Name = "outputComboBox";
            outputComboBox.Size = new Size(447, 23);
            outputComboBox.TabIndex = 3;
            outputComboBox.SelectedIndexChanged += outputComboBox_SelectedIndexChanged;
            // 
            // voiceComboBox
            // 
            voiceComboBox.FormattingEnabled = true;
            voiceComboBox.Location = new Point(12, 44);
            voiceComboBox.Name = "voiceComboBox";
            voiceComboBox.Size = new Size(447, 23);
            voiceComboBox.TabIndex = 2;
            voiceComboBox.SelectedIndexChanged += voiceComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Voice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "Text";
            // 
            // devicesReload
            // 
            devicesReload.BackgroundImage = Properties.Resources.view_refresh;
            devicesReload.BackgroundImageLayout = ImageLayout.Center;
            devicesReload.FlatAppearance.BorderSize = 0;
            devicesReload.FlatStyle = FlatStyle.Flat;
            devicesReload.Location = new Point(465, 88);
            devicesReload.Name = "devicesReload";
            devicesReload.Size = new Size(20, 23);
            devicesReload.TabIndex = 10;
            mainToolTip.SetToolTip(devicesReload, "Refresh devices");
            devicesReload.UseVisualStyleBackColor = true;
            devicesReload.Click += devicesReload_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(497, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { stayOnTop, clearTextBox });
            toolStripMenuItem1.Image = Properties.Resources.applications_system;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(77, 20);
            toolStripMenuItem1.Text = "Settings";
            // 
            // stayOnTop
            // 
            stayOnTop.CheckOnClick = true;
            stayOnTop.Image = Properties.Resources.go_top;
            stayOnTop.Name = "stayOnTop";
            stayOnTop.Size = new Size(248, 22);
            stayOnTop.Text = "Always on top";
            stayOnTop.Click += stayOnTopToolStripMenuItem_Click;
            // 
            // clearTextBox
            // 
            clearTextBox.CheckOnClick = true;
            clearTextBox.Image = Properties.Resources.edit_clear;
            clearTextBox.Name = "clearTextBox";
            clearTextBox.Size = new Size(248, 22);
            clearTextBox.Text = "Empty the textbox after speaking";
            clearTextBox.Click += clearTextBox_Click;
            // 
            // Echo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 316);
            Controls.Add(devicesReload);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(voicesReloadButton);
            Controls.Add(voiceComboBox);
            Controls.Add(outputComboBox);
            Controls.Add(textBox1);
            Controls.Add(speakButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Echo";
            Text = "VoEcho";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox outputComboBox;
        private ComboBox voiceComboBox;
        private Button speakButton;
        private Button voicesReloadButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolTip mainToolTip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem stayOnTop;
        private ToolStripMenuItem clearTextBox;
        private Button devicesReload;
    }
}
