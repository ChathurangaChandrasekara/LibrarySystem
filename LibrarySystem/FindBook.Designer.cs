namespace LibrarySystem
{
    partial class FindBook
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
            this.txtbx_category = new System.Windows.Forms.TextBox();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.txtbx_published_date = new System.Windows.Forms.TextBox();
            this.txtbx_author = new System.Windows.Forms.TextBox();
            this.txtbx_book_name = new System.Windows.Forms.TextBox();
            this.txtbx_book_id = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_published_date = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_book_id = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_existing_state = new System.Windows.Forms.Label();
            this.txtbx_existing_state = new System.Windows.Forms.TextBox();
            this.lbl_borrowed_person = new System.Windows.Forms.Label();
            this.txtbx_NIC = new System.Windows.Forms.TextBox();
            this.lbl_nic = new System.Windows.Forms.Label();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.lbl_tp_no = new System.Windows.Forms.Label();
            this.txtbx_first_name = new System.Windows.Forms.TextBox();
            this.txtbx_tp_no = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_category
            // 
            this.txtbx_category.Location = new System.Drawing.Point(280, 370);
            this.txtbx_category.Multiline = true;
            this.txtbx_category.Name = "txtbx_category";
            this.txtbx_category.Size = new System.Drawing.Size(494, 27);
            this.txtbx_category.TabIndex = 23;
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(280, 300);
            this.txtbx_price.Multiline = true;
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.Size = new System.Drawing.Size(185, 27);
            this.txtbx_price.TabIndex = 22;
            // 
            // txtbx_published_date
            // 
            this.txtbx_published_date.Location = new System.Drawing.Point(280, 244);
            this.txtbx_published_date.Multiline = true;
            this.txtbx_published_date.Name = "txtbx_published_date";
            this.txtbx_published_date.Size = new System.Drawing.Size(185, 27);
            this.txtbx_published_date.TabIndex = 21;
            // 
            // txtbx_author
            // 
            this.txtbx_author.Location = new System.Drawing.Point(280, 180);
            this.txtbx_author.Multiline = true;
            this.txtbx_author.Name = "txtbx_author";
            this.txtbx_author.Size = new System.Drawing.Size(494, 27);
            this.txtbx_author.TabIndex = 20;
            // 
            // txtbx_book_name
            // 
            this.txtbx_book_name.Location = new System.Drawing.Point(280, 117);
            this.txtbx_book_name.Multiline = true;
            this.txtbx_book_name.Name = "txtbx_book_name";
            this.txtbx_book_name.Size = new System.Drawing.Size(494, 27);
            this.txtbx_book_name.TabIndex = 19;
            // 
            // txtbx_book_id
            // 
            this.txtbx_book_id.Location = new System.Drawing.Point(280, 54);
            this.txtbx_book_id.Multiline = true;
            this.txtbx_book_id.Name = "txtbx_book_id";
            this.txtbx_book_id.Size = new System.Drawing.Size(185, 27);
            this.txtbx_book_id.TabIndex = 18;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(61, 377);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(84, 20);
            this.lbl_category.TabIndex = 17;
            this.lbl_category.Text = "Category";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(61, 314);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(53, 20);
            this.lbl_price.TabIndex = 16;
            this.lbl_price.Text = "Price";
            // 
            // lbl_published_date
            // 
            this.lbl_published_date.AutoSize = true;
            this.lbl_published_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_published_date.Location = new System.Drawing.Point(61, 251);
            this.lbl_published_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_published_date.Name = "lbl_published_date";
            this.lbl_published_date.Size = new System.Drawing.Size(137, 20);
            this.lbl_published_date.TabIndex = 15;
            this.lbl_published_date.Text = "Published Date";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(61, 187);
            this.lbl_author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(64, 20);
            this.lbl_author.TabIndex = 14;
            this.lbl_author.Text = "Author";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.Location = new System.Drawing.Point(61, 124);
            this.lbl_book_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(105, 20);
            this.lbl_book_name.TabIndex = 13;
            this.lbl_book_name.Text = "Book Name";
            // 
            // lbl_book_id
            // 
            this.lbl_book_id.AutoSize = true;
            this.lbl_book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id.Location = new System.Drawing.Point(61, 57);
            this.lbl_book_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_book_id.Name = "lbl_book_id";
            this.lbl_book_id.Size = new System.Drawing.Size(76, 20);
            this.lbl_book_id.TabIndex = 12;
            this.lbl_book_id.Text = "Book ID";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1006, 480);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 35);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_existing_state
            // 
            this.lbl_existing_state.AutoSize = true;
            this.lbl_existing_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_existing_state.Location = new System.Drawing.Point(916, 57);
            this.lbl_existing_state.Name = "lbl_existing_state";
            this.lbl_existing_state.Size = new System.Drawing.Size(126, 20);
            this.lbl_existing_state.TabIndex = 25;
            this.lbl_existing_state.Text = "Existing State";
            // 
            // txtbx_existing_state
            // 
            this.txtbx_existing_state.Location = new System.Drawing.Point(1072, 54);
            this.txtbx_existing_state.Multiline = true;
            this.txtbx_existing_state.Name = "txtbx_existing_state";
            this.txtbx_existing_state.Size = new System.Drawing.Size(160, 27);
            this.txtbx_existing_state.TabIndex = 26;
            // 
            // lbl_borrowed_person
            // 
            this.lbl_borrowed_person.AutoSize = true;
            this.lbl_borrowed_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borrowed_person.Location = new System.Drawing.Point(916, 160);
            this.lbl_borrowed_person.Name = "lbl_borrowed_person";
            this.lbl_borrowed_person.Size = new System.Drawing.Size(214, 20);
            this.lbl_borrowed_person.TabIndex = 27;
            this.lbl_borrowed_person.Text = "Borrowed person details";
            // 
            // txtbx_NIC
            // 
            this.txtbx_NIC.Location = new System.Drawing.Point(1072, 207);
            this.txtbx_NIC.Multiline = true;
            this.txtbx_NIC.Name = "txtbx_NIC";
            this.txtbx_NIC.Size = new System.Drawing.Size(160, 27);
            this.txtbx_NIC.TabIndex = 28;
            // 
            // lbl_nic
            // 
            this.lbl_nic.AutoSize = true;
            this.lbl_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nic.Location = new System.Drawing.Point(942, 216);
            this.lbl_nic.Name = "lbl_nic";
            this.lbl_nic.Size = new System.Drawing.Size(40, 20);
            this.lbl_nic.TabIndex = 29;
            this.lbl_nic.Text = "NIC";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.Location = new System.Drawing.Point(942, 285);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(102, 20);
            this.lbl_first_name.TabIndex = 30;
            this.lbl_first_name.Text = "First Name";
            // 
            // lbl_tp_no
            // 
            this.lbl_tp_no.AutoSize = true;
            this.lbl_tp_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tp_no.Location = new System.Drawing.Point(942, 352);
            this.lbl_tp_no.Name = "lbl_tp_no";
            this.lbl_tp_no.Size = new System.Drawing.Size(66, 20);
            this.lbl_tp_no.TabIndex = 31;
            this.lbl_tp_no.Text = "T.P No";
            // 
            // txtbx_first_name
            // 
            this.txtbx_first_name.Location = new System.Drawing.Point(1072, 278);
            this.txtbx_first_name.Multiline = true;
            this.txtbx_first_name.Name = "txtbx_first_name";
            this.txtbx_first_name.Size = new System.Drawing.Size(217, 27);
            this.txtbx_first_name.TabIndex = 32;
            // 
            // txtbx_tp_no
            // 
            this.txtbx_tp_no.Location = new System.Drawing.Point(1072, 345);
            this.txtbx_tp_no.Multiline = true;
            this.txtbx_tp_no.Name = "txtbx_tp_no";
            this.txtbx_tp_no.Size = new System.Drawing.Size(160, 27);
            this.txtbx_tp_no.TabIndex = 33;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1143, 480);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 35);
            this.btn_back.TabIndex = 34;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // FindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.gold_and_black_smoke_wallpaper_13_widescreen_wallpaper;
            this.ClientSize = new System.Drawing.Size(1326, 538);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtbx_tp_no);
            this.Controls.Add(this.txtbx_first_name);
            this.Controls.Add(this.lbl_tp_no);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.lbl_nic);
            this.Controls.Add(this.txtbx_NIC);
            this.Controls.Add(this.lbl_borrowed_person);
            this.Controls.Add(this.txtbx_existing_state);
            this.Controls.Add(this.lbl_existing_state);
            this.Controls.Add(this.btn_search);
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
            this.Name = "FindBook";
            this.Text = "Find Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_category;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.TextBox txtbx_published_date;
        private System.Windows.Forms.TextBox txtbx_author;
        private System.Windows.Forms.TextBox txtbx_book_name;
        private System.Windows.Forms.TextBox txtbx_book_id;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_published_date;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_book_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_existing_state;
        private System.Windows.Forms.TextBox txtbx_existing_state;
        private System.Windows.Forms.Label lbl_borrowed_person;
        private System.Windows.Forms.TextBox txtbx_NIC;
        private System.Windows.Forms.Label lbl_nic;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.Label lbl_tp_no;
        private System.Windows.Forms.TextBox txtbx_first_name;
        private System.Windows.Forms.TextBox txtbx_tp_no;
        private System.Windows.Forms.Button btn_back;
    }
}