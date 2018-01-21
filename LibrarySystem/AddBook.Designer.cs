namespace LibrarySystem
{
    partial class Add_Book
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
            this.lbl_book_id = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_published_date = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txtbx_book_id = new System.Windows.Forms.TextBox();
            this.txtbx_book_name = new System.Windows.Forms.TextBox();
            this.txtbx_author = new System.Windows.Forms.TextBox();
            this.txtbx_published_date = new System.Windows.Forms.TextBox();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.txtbx_category = new System.Windows.Forms.TextBox();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_book_id
            // 
            this.lbl_book_id.AutoSize = true;
            this.lbl_book_id.Location = new System.Drawing.Point(163, 64);
            this.lbl_book_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_book_id.Name = "lbl_book_id";
            this.lbl_book_id.Size = new System.Drawing.Size(76, 20);
            this.lbl_book_id.TabIndex = 0;
            this.lbl_book_id.Text = "Book ID";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Location = new System.Drawing.Point(163, 131);
            this.lbl_book_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(105, 20);
            this.lbl_book_name.TabIndex = 1;
            this.lbl_book_name.Text = "Book Name";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(163, 194);
            this.lbl_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(64, 20);
            this.lbl_author.TabIndex = 2;
            this.lbl_author.Text = "Author";
            this.lbl_author.Click += new System.EventHandler(this.lbl_author_Click);
            // 
            // lbl_published_date
            // 
            this.lbl_published_date.AutoSize = true;
            this.lbl_published_date.Location = new System.Drawing.Point(163, 258);
            this.lbl_published_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_published_date.Name = "lbl_published_date";
            this.lbl_published_date.Size = new System.Drawing.Size(137, 20);
            this.lbl_published_date.TabIndex = 3;
            this.lbl_published_date.Text = "Published Date";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(163, 321);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(53, 20);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(163, 384);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(84, 20);
            this.lbl_category.TabIndex = 5;
            this.lbl_category.Text = "Category";
            // 
            // txtbx_book_id
            // 
            this.txtbx_book_id.Location = new System.Drawing.Point(382, 61);
            this.txtbx_book_id.Name = "txtbx_book_id";
            this.txtbx_book_id.Size = new System.Drawing.Size(185, 27);
            this.txtbx_book_id.TabIndex = 6;
            // 
            // txtbx_book_name
            // 
            this.txtbx_book_name.Location = new System.Drawing.Point(382, 124);
            this.txtbx_book_name.Name = "txtbx_book_name";
            this.txtbx_book_name.Size = new System.Drawing.Size(494, 27);
            this.txtbx_book_name.TabIndex = 7;
            // 
            // txtbx_author
            // 
            this.txtbx_author.Location = new System.Drawing.Point(382, 187);
            this.txtbx_author.Name = "txtbx_author";
            this.txtbx_author.Size = new System.Drawing.Size(494, 27);
            this.txtbx_author.TabIndex = 8;
            // 
            // txtbx_published_date
            // 
            this.txtbx_published_date.Location = new System.Drawing.Point(382, 251);
            this.txtbx_published_date.Name = "txtbx_published_date";
            this.txtbx_published_date.Size = new System.Drawing.Size(185, 27);
            this.txtbx_published_date.TabIndex = 9;
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(382, 307);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.Size = new System.Drawing.Size(185, 27);
            this.txtbx_price.TabIndex = 10;
            // 
            // txtbx_category
            // 
            this.txtbx_category.Location = new System.Drawing.Point(382, 377);
            this.txtbx_category.Name = "txtbx_category";
            this.txtbx_category.Size = new System.Drawing.Size(494, 27);
            this.txtbx_category.TabIndex = 11;
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(698, 447);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(130, 45);
            this.btn_add_book.TabIndex = 12;
            this.btn_add_book.Text = "Add Book";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(875, 448);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 43);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.gold_and_black_smoke_wallpaper_13_widescreen_wallpaper;
            this.ClientSize = new System.Drawing.Size(1306, 544);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add_book);
            this.Controls.Add(this.txtbx_category);
            this.Controls.Add(this.txtbx_price);
            this.Controls.Add(this.txtbx_published_date);
            this.Controls.Add(this.txtbx_author);
            this.Controls.Add(this.txtbx_book_name);
            this.Controls.Add(this.txtbx_book_id);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_published_date);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_book_name);
            this.Controls.Add(this.lbl_book_id);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Book";
            this.Text = "Add Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_book_id;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_published_date;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txtbx_book_id;
        private System.Windows.Forms.TextBox txtbx_book_name;
        private System.Windows.Forms.TextBox txtbx_author;
        private System.Windows.Forms.TextBox txtbx_published_date;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.TextBox txtbx_category;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.Button btn_back;
    }
}