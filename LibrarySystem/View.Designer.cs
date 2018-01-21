using System;

namespace LibrarySystem
{
    partial class View
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
            this.btn_book_details = new System.Windows.Forms.Button();
            this.btn_user_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_book_details
            // 
            this.btn_book_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_details.Location = new System.Drawing.Point(197, 101);
            this.btn_book_details.Name = "btn_book_details";
            this.btn_book_details.Size = new System.Drawing.Size(227, 110);
            this.btn_book_details.TabIndex = 0;
            this.btn_book_details.Text = "Book Details";
            this.btn_book_details.UseVisualStyleBackColor = true;
            this.btn_book_details.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_user_details
            // 
            this.btn_user_details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_details.Location = new System.Drawing.Point(197, 273);
            this.btn_user_details.Name = "btn_user_details";
            this.btn_user_details.Size = new System.Drawing.Size(227, 110);
            this.btn_user_details.TabIndex = 2;
            this.btn_user_details.Text = "Users Details";
            this.btn_user_details.UseVisualStyleBackColor = true;
            this.btn_user_details.Click += new System.EventHandler(this.button3_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.gold_and_black_smoke_wallpaper_13_widescreen_wallpaper;
            this.ClientSize = new System.Drawing.Size(1337, 533);
            this.Controls.Add(this.btn_user_details);
            this.Controls.Add(this.btn_book_details);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book book = new Book();
            book.Show();
        }

        #endregion

        private System.Windows.Forms.Button btn_book_details;
        private System.Windows.Forms.Button btn_user_details;
    }
}