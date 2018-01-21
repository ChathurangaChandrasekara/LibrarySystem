namespace LibrarySystem
{
    partial class User
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
            this.btn_find_user = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_find_user
            // 
            this.btn_find_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_user.Location = new System.Drawing.Point(137, 273);
            this.btn_find_user.Name = "btn_find_user";
            this.btn_find_user.Size = new System.Drawing.Size(227, 110);
            this.btn_find_user.TabIndex = 4;
            this.btn_find_user.Text = "Find User";
            this.btn_find_user.UseVisualStyleBackColor = true;
            this.btn_find_user.Click += new System.EventHandler(this.btn_find_user_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_user.Location = new System.Drawing.Point(137, 101);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(227, 110);
            this.btn_add_user.TabIndex = 3;
            this.btn_add_user.Text = "Add User";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(1037, 450);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(133, 49);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.gold_and_black_smoke_wallpaper_13_widescreen_wallpaper;
            this.ClientSize = new System.Drawing.Size(1312, 530);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_find_user);
            this.Controls.Add(this.btn_add_user);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_find_user;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button btn_back;
    }
}