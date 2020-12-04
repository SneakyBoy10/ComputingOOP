namespace OOP
{
    partial class MainForm
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
            this.btnAddBookMenu = new System.Windows.Forms.Button();
            this.btnViewBookMenu = new System.Windows.Forms.Button();
            this.btnAddBorrowerMenu = new System.Windows.Forms.Button();
            this.btnViewBorrowerMenu = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBookMenu
            // 
            this.btnAddBookMenu.Location = new System.Drawing.Point(13, 13);
            this.btnAddBookMenu.Name = "btnAddBookMenu";
            this.btnAddBookMenu.Size = new System.Drawing.Size(100, 23);
            this.btnAddBookMenu.TabIndex = 0;
            this.btnAddBookMenu.Text = "Add Books";
            this.btnAddBookMenu.UseVisualStyleBackColor = true;
            this.btnAddBookMenu.Click += new System.EventHandler(this.btnAddBookMenu_Click);
            // 
            // btnViewBookMenu
            // 
            this.btnViewBookMenu.Location = new System.Drawing.Point(13, 42);
            this.btnViewBookMenu.Name = "btnViewBookMenu";
            this.btnViewBookMenu.Size = new System.Drawing.Size(100, 23);
            this.btnViewBookMenu.TabIndex = 1;
            this.btnViewBookMenu.Text = "View Books";
            this.btnViewBookMenu.UseVisualStyleBackColor = true;
            this.btnViewBookMenu.Click += new System.EventHandler(this.btnViewBookMenu_Click);
            // 
            // btnAddBorrowerMenu
            // 
            this.btnAddBorrowerMenu.Location = new System.Drawing.Point(13, 71);
            this.btnAddBorrowerMenu.Name = "btnAddBorrowerMenu";
            this.btnAddBorrowerMenu.Size = new System.Drawing.Size(100, 23);
            this.btnAddBorrowerMenu.TabIndex = 2;
            this.btnAddBorrowerMenu.Text = "Add Borrower";
            this.btnAddBorrowerMenu.UseVisualStyleBackColor = true;
            // 
            // btnViewBorrowerMenu
            // 
            this.btnViewBorrowerMenu.Location = new System.Drawing.Point(13, 100);
            this.btnViewBorrowerMenu.Name = "btnViewBorrowerMenu";
            this.btnViewBorrowerMenu.Size = new System.Drawing.Size(100, 23);
            this.btnViewBorrowerMenu.TabIndex = 3;
            this.btnViewBorrowerMenu.Text = "View Borrower";
            this.btnViewBorrowerMenu.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(13, 129);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnViewBorrowerMenu);
            this.Controls.Add(this.btnAddBorrowerMenu);
            this.Controls.Add(this.btnViewBookMenu);
            this.Controls.Add(this.btnAddBookMenu);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBookMenu;
        private System.Windows.Forms.Button btnViewBookMenu;
        private System.Windows.Forms.Button btnAddBorrowerMenu;
        private System.Windows.Forms.Button btnViewBorrowerMenu;
        private System.Windows.Forms.Button btnQuit;
    }
}