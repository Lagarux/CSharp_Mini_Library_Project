namespace DatabaseCRUD_Sample
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.page = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddData = new System.Windows.Forms.Button();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPage = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.txbUpage = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.txbUpublisher = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txbUauthor = new System.Windows.Forms.TextBox();
            this.lblBN = new System.Windows.Forms.Label();
            this.txbUbookName = new System.Windows.Forms.TextBox();
            this.btnUpdateCurrent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.bookName,
            this.author,
            this.publisher,
            this.page});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 455);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "Sıra No";
            this.id.Width = 100;
            // 
            // bookName
            // 
            this.bookName.Text = "Kitap Adı";
            this.bookName.Width = 110;
            // 
            // author
            // 
            this.author.Text = "Yazar";
            this.author.Width = 100;
            // 
            // publisher
            // 
            this.publisher.DisplayIndex = 4;
            this.publisher.Text = "Yayınevi";
            this.publisher.Width = 110;
            // 
            // page
            // 
            this.page.DisplayIndex = 3;
            this.page.Text = "Sayfa Sayısı";
            this.page.Width = 100;
            // 
            // btnAddData
            // 
            this.btnAddData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddData.FlatAppearance.BorderSize = 0;
            this.btnAddData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddData.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddData.Location = new System.Drawing.Point(1296, 287);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(137, 72);
            this.btnAddData.TabIndex = 2;
            this.btnAddData.Text = "Kitap Ekle";
            this.btnAddData.UseVisualStyleBackColor = false;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // txbBookName
            // 
            this.txbBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBookName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbBookName.Location = new System.Drawing.Point(1214, 25);
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.Size = new System.Drawing.Size(219, 34);
            this.txbBookName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1083, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1085, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yazar";
            // 
            // txbAuthor
            // 
            this.txbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAuthor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbAuthor.Location = new System.Drawing.Point(1214, 86);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(219, 34);
            this.txbAuthor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1083, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yayınevi";
            // 
            // txbPublisher
            // 
            this.txbPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPublisher.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbPublisher.Location = new System.Drawing.Point(1214, 152);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(219, 34);
            this.txbPublisher.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1083, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // txbPage
            // 
            this.txbPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbPage.Location = new System.Drawing.Point(1214, 213);
            this.txbPage.Name = "txbPage";
            this.txbPage.Size = new System.Drawing.Size(219, 34);
            this.txbPage.TabIndex = 9;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(743, 25);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(154, 65);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = "Kitap Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBook.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBook.Location = new System.Drawing.Point(743, 88);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(154, 65);
            this.btnUpdateBook.TabIndex = 12;
            this.btnUpdateBook.Text = "Kitap Güncelle";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPage.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPage.ForeColor = System.Drawing.Color.Cyan;
            this.lblPage.Location = new System.Drawing.Point(738, 446);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(130, 27);
            this.lblPage.TabIndex = 21;
            this.lblPage.Text = "Sayfa Sayısı";
            this.lblPage.Visible = false;
            // 
            // txbUpage
            // 
            this.txbUpage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUpage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbUpage.Location = new System.Drawing.Point(878, 443);
            this.txbUpage.Name = "txbUpage";
            this.txbUpage.Size = new System.Drawing.Size(208, 34);
            this.txbUpage.TabIndex = 20;
            this.txbUpage.Visible = false;
            // 
            // lblP
            // 
            this.lblP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.Transparent;
            this.lblP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblP.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP.ForeColor = System.Drawing.Color.Cyan;
            this.lblP.Location = new System.Drawing.Point(738, 393);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(97, 27);
            this.lblP.TabIndex = 19;
            this.lblP.Text = "Yayınevi";
            this.lblP.Visible = false;
            // 
            // txbUpublisher
            // 
            this.txbUpublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUpublisher.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbUpublisher.Location = new System.Drawing.Point(878, 390);
            this.txbUpublisher.Name = "txbUpublisher";
            this.txbUpublisher.Size = new System.Drawing.Size(208, 34);
            this.txbUpublisher.TabIndex = 18;
            this.txbUpublisher.Visible = false;
            // 
            // lblA
            // 
            this.lblA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA.ForeColor = System.Drawing.Color.Cyan;
            this.lblA.Location = new System.Drawing.Point(740, 340);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(67, 27);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "Yazar";
            this.lblA.Visible = false;
            // 
            // txbUauthor
            // 
            this.txbUauthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUauthor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbUauthor.Location = new System.Drawing.Point(878, 337);
            this.txbUauthor.Name = "txbUauthor";
            this.txbUauthor.Size = new System.Drawing.Size(208, 34);
            this.txbUauthor.TabIndex = 16;
            this.txbUauthor.Visible = false;
            // 
            // lblBN
            // 
            this.lblBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBN.AutoSize = true;
            this.lblBN.BackColor = System.Drawing.Color.Transparent;
            this.lblBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBN.ForeColor = System.Drawing.Color.Cyan;
            this.lblBN.Location = new System.Drawing.Point(738, 287);
            this.lblBN.Name = "lblBN";
            this.lblBN.Size = new System.Drawing.Size(105, 27);
            this.lblBN.TabIndex = 15;
            this.lblBN.Text = "Kitap Adı";
            this.lblBN.Visible = false;
            // 
            // txbUbookName
            // 
            this.txbUbookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUbookName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txbUbookName.Location = new System.Drawing.Point(878, 284);
            this.txbUbookName.Name = "txbUbookName";
            this.txbUbookName.Size = new System.Drawing.Size(208, 34);
            this.txbUbookName.TabIndex = 14;
            this.txbUbookName.Visible = false;
            // 
            // btnUpdateCurrent
            // 
            this.btnUpdateCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCurrent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnUpdateCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCurrent.FlatAppearance.BorderSize = 0;
            this.btnUpdateCurrent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCurrent.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCurrent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCurrent.Location = new System.Drawing.Point(1092, 391);
            this.btnUpdateCurrent.Name = "btnUpdateCurrent";
            this.btnUpdateCurrent.Size = new System.Drawing.Size(137, 88);
            this.btnUpdateCurrent.TabIndex = 13;
            this.btnUpdateCurrent.Text = "Seçili Kitabı Güncelle";
            this.btnUpdateCurrent.UseVisualStyleBackColor = false;
            this.btnUpdateCurrent.Visible = false;
            this.btnUpdateCurrent.Click += new System.EventHandler(this.btnUpdateCurrent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(743, 152);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 65);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DatabaseCRUD_Sample.Properties.Resources.Book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1445, 569);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.txbUpage);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.txbUpublisher);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txbUauthor);
            this.Controls.Add(this.lblBN);
            this.Controls.Add(this.txbUbookName);
            this.Controls.Add(this.btnUpdateCurrent);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPublisher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBookName);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1161, 601);
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Program";
            this.Load += new System.EventHandler(this.Library_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader bookName;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader page;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.TextBox txbBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPage;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox txbUpage;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txbUpublisher;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txbUauthor;
        private System.Windows.Forms.Label lblBN;
        private System.Windows.Forms.TextBox txbUbookName;
        private System.Windows.Forms.Button btnUpdateCurrent;
        private System.Windows.Forms.Button btnRefresh;
    }
}

