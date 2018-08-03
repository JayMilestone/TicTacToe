namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A1Text = new System.Windows.Forms.Label();
            this.A2Text = new System.Windows.Forms.Label();
            this.A3Text = new System.Windows.Forms.Label();
            this.B1Text = new System.Windows.Forms.Label();
            this.B2Text = new System.Windows.Forms.Label();
            this.B3Text = new System.Windows.Forms.Label();
            this.C3Text = new System.Windows.Forms.Label();
            this.C2Text = new System.Windows.Forms.Label();
            this.C1Text = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "New Game";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 37);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(102, 98);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(129, 37);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(102, 98);
            this.B1.TabIndex = 2;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(252, 37);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(102, 98);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(254, 176);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(102, 98);
            this.C2.TabIndex = 6;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(131, 176);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(102, 98);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(14, 176);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(102, 98);
            this.A2.TabIndex = 4;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(252, 317);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(102, 98);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(129, 317);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(102, 98);
            this.B3.TabIndex = 8;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(12, 317);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(102, 98);
            this.A3.TabIndex = 7;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // A1Text
            // 
            this.A1Text.AutoSize = true;
            this.A1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1Text.Location = new System.Drawing.Point(12, 37);
            this.A1Text.Name = "A1Text";
            this.A1Text.Size = new System.Drawing.Size(0, 108);
            this.A1Text.TabIndex = 10;
            // 
            // A2Text
            // 
            this.A2Text.AutoSize = true;
            this.A2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2Text.Location = new System.Drawing.Point(127, 37);
            this.A2Text.Name = "A2Text";
            this.A2Text.Size = new System.Drawing.Size(0, 108);
            this.A2Text.TabIndex = 11;
            // 
            // A3Text
            // 
            this.A3Text.AutoSize = true;
            this.A3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3Text.Location = new System.Drawing.Point(250, 37);
            this.A3Text.Name = "A3Text";
            this.A3Text.Size = new System.Drawing.Size(0, 108);
            this.A3Text.TabIndex = 12;
            // 
            // B1Text
            // 
            this.B1Text.AutoSize = true;
            this.B1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1Text.Location = new System.Drawing.Point(13, 173);
            this.B1Text.Name = "B1Text";
            this.B1Text.Size = new System.Drawing.Size(0, 108);
            this.B1Text.TabIndex = 13;
            // 
            // B2Text
            // 
            this.B2Text.AutoSize = true;
            this.B2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2Text.Location = new System.Drawing.Point(130, 173);
            this.B2Text.Name = "B2Text";
            this.B2Text.Size = new System.Drawing.Size(0, 108);
            this.B2Text.TabIndex = 14;
            // 
            // B3Text
            // 
            this.B3Text.AutoSize = true;
            this.B3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3Text.Location = new System.Drawing.Point(253, 172);
            this.B3Text.Name = "B3Text";
            this.B3Text.Size = new System.Drawing.Size(0, 108);
            this.B3Text.TabIndex = 15;
            // 
            // C3Text
            // 
            this.C3Text.AutoSize = true;
            this.C3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3Text.Location = new System.Drawing.Point(251, 313);
            this.C3Text.Name = "C3Text";
            this.C3Text.Size = new System.Drawing.Size(0, 108);
            this.C3Text.TabIndex = 16;
            // 
            // C2Text
            // 
            this.C2Text.AutoSize = true;
            this.C2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2Text.Location = new System.Drawing.Point(128, 315);
            this.C2Text.Name = "C2Text";
            this.C2Text.Size = new System.Drawing.Size(0, 108);
            this.C2Text.TabIndex = 17;
            // 
            // C1Text
            // 
            this.C1Text.AutoSize = true;
            this.C1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1Text.Location = new System.Drawing.Point(11, 314);
            this.C1Text.Name = "C1Text";
            this.C1Text.Size = new System.Drawing.Size(0, 108);
            this.C1Text.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 435);
            this.Controls.Add(this.C1Text);
            this.Controls.Add(this.C2Text);
            this.Controls.Add(this.C3Text);
            this.Controls.Add(this.B3Text);
            this.Controls.Add(this.B2Text);
            this.Controls.Add(this.B1Text);
            this.Controls.Add(this.A3Text);
            this.Controls.Add(this.A2Text);
            this.Controls.Add(this.A1Text);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label A1Text;
        private System.Windows.Forms.Label A2Text;
        private System.Windows.Forms.Label A3Text;
        private System.Windows.Forms.Label B1Text;
        private System.Windows.Forms.Label B2Text;
        private System.Windows.Forms.Label B3Text;
        private System.Windows.Forms.Label C3Text;
        private System.Windows.Forms.Label C2Text;
        private System.Windows.Forms.Label C1Text;
    }
}

