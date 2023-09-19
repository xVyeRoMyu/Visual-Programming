namespace AboutMe
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            Steam = new PictureBox();
            Github = new PictureBox();
            WA = new PictureBox();
            IG = new PictureBox();
            Title = new TextBox();
            Text = new RichTextBox();
            checkBox1 = new CheckBox();
            GitHubText = new TextBox();
            SteamText = new TextBox();
            WAtext = new TextBox();
            IGtext = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Steam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IG).BeginInit();
            SuspendLayout();
            // 
            // Steam
            // 
            resources.ApplyResources(Steam, "Steam");
            Steam.Name = "Steam";
            Steam.TabStop = false;
            // 
            // Github
            // 
            resources.ApplyResources(Github, "Github");
            Github.Name = "Github";
            Github.TabStop = false;
            // 
            // WA
            // 
            resources.ApplyResources(WA, "WA");
            WA.Name = "WA";
            WA.TabStop = false;
            // 
            // IG
            // 
            IG.BackColor = Color.White;
            resources.ApplyResources(IG, "IG");
            IG.Name = "IG";
            IG.TabStop = false;
            // 
            // Title
            // 
            Title.BackColor = Color.White;
            resources.ApplyResources(Title, "Title");
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.TextChanged += textBox1_TextChanged;
            // 
            // Text
            // 
            resources.ApplyResources(Text, "Text");
            Text.Name = "Text";
            Text.ReadOnly = true;
            Text.TextChanged += richTextBox1_TextChanged;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.ForeColor = Color.White;
            checkBox1.Name = "checkBox1";
            checkBox1.UseCompatibleTextRendering = true;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // GitHubText
            // 
            GitHubText.BackColor = Color.White;
            resources.ApplyResources(GitHubText, "GitHubText");
            GitHubText.Name = "GitHubText";
            GitHubText.ReadOnly = true;
            GitHubText.TextChanged += GitHubText_TextChanged;
            // 
            // SteamText
            // 
            SteamText.BackColor = Color.White;
            resources.ApplyResources(SteamText, "SteamText");
            SteamText.Name = "SteamText";
            SteamText.ReadOnly = true;
            // 
            // WAtext
            // 
            WAtext.BackColor = Color.White;
            resources.ApplyResources(WAtext, "WAtext");
            WAtext.Name = "WAtext";
            WAtext.ReadOnly = true;
            WAtext.TextChanged += textBox1_TextChanged_1;
            // 
            // IGtext
            // 
            IGtext.BackColor = Color.White;
            resources.ApplyResources(IGtext, "IGtext");
            IGtext.Name = "IGtext";
            IGtext.ReadOnly = true;
            // 
            // AboutMe
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(IGtext);
            Controls.Add(WAtext);
            Controls.Add(SteamText);
            Controls.Add(GitHubText);
            Controls.Add(checkBox1);
            Controls.Add(Text);
            Controls.Add(Title);
            Controls.Add(IG);
            Controls.Add(WA);
            Controls.Add(Github);
            Controls.Add(Steam);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AboutMe";
            ((System.ComponentModel.ISupportInitialize)Steam).EndInit();
            ((System.ComponentModel.ISupportInitialize)Github).EndInit();
            ((System.ComponentModel.ISupportInitialize)WA).EndInit();
            ((System.ComponentModel.ISupportInitialize)IG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Steam;
        private PictureBox Github;
        private PictureBox WA;
        private PictureBox IG;
        private TextBox Title;
        private RichTextBox Text;
        private CheckBox checkBox1;
        private TextBox GitHubText;
        private TextBox SteamText;
        private TextBox WAtext;
        private TextBox IGtext;
    }
}