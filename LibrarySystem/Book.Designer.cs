namespace LibrarySystem
{
    partial class Book
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
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_find_book = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_book
            // 
            this.btn_add_book.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_book.Location = new System.Drawing.Point(157, 131);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(218, 100);
            this.btn_add_book.TabIndex = 0;
            this.btn_add_book.Text = "Add Book";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_find_book
            // 
            this.btn_find_book.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_book.Location = new System.Drawing.Point(157, 320);
            this.btn_find_book.Name = "btn_find_book";
            this.btn_find_book.Size = new System.Drawing.Size(218, 100);
            this.btn_find_book.TabIndex = 1;
            this.btn_find_book.Text = "Find Book";
            this.btn_find_book.UseVisualStyleBackColor = true;
            this.btn_find_book.Click += new System.EventHandler(this.btn_find_book_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1047, 452);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(133, 49);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.gold_and_black_smoke_wallpaper_13_widescreen_wallpaper;
            this.ClientSize = new System.Drawing.Size(1334, 538);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_find_book);
            this.Controls.Add(this.btn_add_book);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_find_book;
        private System.Windows.Forms.Button btn_back;
    }
}