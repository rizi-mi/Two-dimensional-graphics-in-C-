
namespace Graphics_with_C
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборКривойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаЭкранаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однаКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Упругость сплайна";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборКривойToolStripMenuItem,
            this.очисткаЭкранаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборКривойToolStripMenuItem
            // 
            this.выборКривойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.незамкнутаяЛоманаяToolStripMenuItem,
            this.замкнутаяЛоманаяToolStripMenuItem,
            this.незамкнутыйСплайнToolStripMenuItem,
            this.замкнутыйСплайнToolStripMenuItem,
            this.однаКриваяБезьеToolStripMenuItem,
            this.незамкнутаяКриваяБезьеToolStripMenuItem,
            this.замкнутаяКриваяБезьеToolStripMenuItem});
            this.выборКривойToolStripMenuItem.Name = "выборКривойToolStripMenuItem";
            this.выборКривойToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.выборКривойToolStripMenuItem.Text = "Выбор Кривой";
            // 
            // очисткаЭкранаToolStripMenuItem
            // 
            this.очисткаЭкранаToolStripMenuItem.Name = "очисткаЭкранаToolStripMenuItem";
            this.очисткаЭкранаToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.очисткаЭкранаToolStripMenuItem.Text = "Очистка экрана";
            this.очисткаЭкранаToolStripMenuItem.Click += new System.EventHandler(this.очисткаЭкранаToolStripMenuItem_Click);
            // 
            // незамкнутаяЛоманаяToolStripMenuItem
            // 
            this.незамкнутаяЛоманаяToolStripMenuItem.Name = "незамкнутаяЛоманаяToolStripMenuItem";
            this.незамкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.незамкнутаяЛоманаяToolStripMenuItem.Text = "1) Незамкнутая ломаная";
            this.незамкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.незамкнутаяЛоманаяToolStripMenuItem_Click);
            // 
            // замкнутаяЛоманаяToolStripMenuItem
            // 
            this.замкнутаяЛоманаяToolStripMenuItem.Name = "замкнутаяЛоманаяToolStripMenuItem";
            this.замкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.замкнутаяЛоманаяToolStripMenuItem.Text = "2) Замкнутая ломаная";
            this.замкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.замкнутаяЛоманаяToolStripMenuItem_Click);
            // 
            // незамкнутыйСплайнToolStripMenuItem
            // 
            this.незамкнутыйСплайнToolStripMenuItem.Name = "незамкнутыйСплайнToolStripMenuItem";
            this.незамкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.незамкнутыйСплайнToolStripMenuItem.Text = "3) Незамкнутый сплайн";
            this.незамкнутыйСплайнToolStripMenuItem.Click += new System.EventHandler(this.незамкнутыйСплайнToolStripMenuItem_Click);
            // 
            // замкнутыйСплайнToolStripMenuItem
            // 
            this.замкнутыйСплайнToolStripMenuItem.Name = "замкнутыйСплайнToolStripMenuItem";
            this.замкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.замкнутыйСплайнToolStripMenuItem.Text = "4) Замкнутый сплайн";
            this.замкнутыйСплайнToolStripMenuItem.Click += new System.EventHandler(this.замкнутыйСплайнToolStripMenuItem_Click);
            // 
            // однаКриваяБезьеToolStripMenuItem
            // 
            this.однаКриваяБезьеToolStripMenuItem.Name = "однаКриваяБезьеToolStripMenuItem";
            this.однаКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.однаКриваяБезьеToolStripMenuItem.Text = "5) Одна кривая Безье";
            this.однаКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.однаКриваяБезьеToolStripMenuItem_Click);
            // 
            // незамкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Name = "незамкнутаяКриваяБезьеToolStripMenuItem";
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Text = "6) Незамкнутая кривая Безье";
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.незамкнутаяКриваяБезьеToolStripMenuItem_Click);
            // 
            // замкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.замкнутаяКриваяБезьеToolStripMenuItem.Name = "замкнутаяКриваяБезьеToolStripMenuItem";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.замкнутаяКриваяБезьеToolStripMenuItem.Text = "7) Замкнутая кривая Безье";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.замкнутаяКриваяБезьеToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборКривойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаЭкранаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутаяЛоманаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутаяЛоманаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутыйСплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутыйСплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однаКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутаяКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутаяКриваяБезьеToolStripMenuItem;
    }
}