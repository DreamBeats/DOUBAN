namespace ReadDoubanAPI
{
    partial class ReadDoubanAPI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.textBoxDoubanAPI = new System.Windows.Forms.TextBox();
            this.labelDouban = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.API = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.labelTags = new System.Windows.Forms.Label();
            this.richTextBoxSummery = new System.Windows.Forms.RichTextBox();
            this.BookPages = new System.Windows.Forms.Label();
            this.BookBinding = new System.Windows.Forms.Label();
            this.BookPrice = new System.Windows.Forms.Label();
            this.BookPublishDate = new System.Windows.Forms.Label();
            this.BookPublisher = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelBinding = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPublishDate = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.pictureBoxBookImag = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGetInfo);
            this.panel1.Controls.Add(this.textBoxDoubanAPI);
            this.panel1.Controls.Add(this.labelDouban);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(355, 8);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(87, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "获取图书信息";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // textBoxDoubanAPI
            // 
            this.textBoxDoubanAPI.Location = new System.Drawing.Point(90, 10);
            this.textBoxDoubanAPI.Name = "textBoxDoubanAPI";
            this.textBoxDoubanAPI.Size = new System.Drawing.Size(259, 21);
            this.textBoxDoubanAPI.TabIndex = 1;
            // 
            // labelDouban
            // 
            this.labelDouban.AutoSize = true;
            this.labelDouban.Location = new System.Drawing.Point(4, 13);
            this.labelDouban.Name = "labelDouban";
            this.labelDouban.Size = new System.Drawing.Size(89, 12);
            this.labelDouban.TabIndex = 0;
            this.labelDouban.Text = "请输入豆瓣API:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.buttonCheck);
            this.panel2.Controls.Add(this.textBoxTags);
            this.panel2.Controls.Add(this.labelTags);
            this.panel2.Controls.Add(this.richTextBoxSummery);
            this.panel2.Controls.Add(this.BookPages);
            this.panel2.Controls.Add(this.BookBinding);
            this.panel2.Controls.Add(this.BookPrice);
            this.panel2.Controls.Add(this.BookPublishDate);
            this.panel2.Controls.Add(this.BookPublisher);
            this.panel2.Controls.Add(this.BookID);
            this.panel2.Controls.Add(this.BookAuthor);
            this.panel2.Controls.Add(this.labelSummary);
            this.panel2.Controls.Add(this.labelPages);
            this.panel2.Controls.Add(this.labelBinding);
            this.panel2.Controls.Add(this.labelPrice);
            this.panel2.Controls.Add(this.labelPublishDate);
            this.panel2.Controls.Add(this.labelPublisher);
            this.panel2.Controls.Add(this.labelBookID);
            this.panel2.Controls.Add(this.labelAuthor);
            this.panel2.Controls.Add(this.BookName);
            this.panel2.Controls.Add(this.labelBookName);
            this.panel2.Controls.Add(this.pictureBoxBookImag);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 466);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.API});
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(436, 407);
            this.dataGridView1.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Index";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Title";
            this.Column2.FillWeight = 119.7605F;
            this.Column2.HeaderText = "书名";
            this.Column2.Name = "Column2";
            // 
            // API
            // 
            this.API.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.API.DataPropertyName = "API";
            this.API.FillWeight = 80.23952F;
            this.API.HeaderText = "API";
            this.API.Name = "API";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(367, 9);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 21;
            this.buttonCheck.Text = "查找";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(160, 10);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(201, 21);
            this.textBoxTags.TabIndex = 20;
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(4, 15);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(149, 12);
            this.labelTags.TabIndex = 19;
            this.labelTags.Text = "根据关键字查找书籍信息：";
            // 
            // richTextBoxSummery
            // 
            this.richTextBoxSummery.Location = new System.Drawing.Point(468, 243);
            this.richTextBoxSummery.Name = "richTextBoxSummery";
            this.richTextBoxSummery.ReadOnly = true;
            this.richTextBoxSummery.Size = new System.Drawing.Size(480, 172);
            this.richTextBoxSummery.TabIndex = 18;
            this.richTextBoxSummery.Text = "";
            // 
            // BookPages
            // 
            this.BookPages.AutoSize = true;
            this.BookPages.Location = new System.Drawing.Point(710, 199);
            this.BookPages.Name = "BookPages";
            this.BookPages.Size = new System.Drawing.Size(35, 12);
            this.BookPages.TabIndex = 17;
            this.BookPages.Text = "pages";
            // 
            // BookBinding
            // 
            this.BookBinding.AutoSize = true;
            this.BookBinding.Location = new System.Drawing.Point(710, 168);
            this.BookBinding.Name = "BookBinding";
            this.BookBinding.Size = new System.Drawing.Size(47, 12);
            this.BookBinding.TabIndex = 16;
            this.BookBinding.Text = "binding";
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSize = true;
            this.BookPrice.Location = new System.Drawing.Point(710, 141);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(35, 12);
            this.BookPrice.TabIndex = 15;
            this.BookPrice.Text = "price";
            // 
            // BookPublishDate
            // 
            this.BookPublishDate.AutoSize = true;
            this.BookPublishDate.Location = new System.Drawing.Point(734, 117);
            this.BookPublishDate.Name = "BookPublishDate";
            this.BookPublishDate.Size = new System.Drawing.Size(71, 12);
            this.BookPublishDate.TabIndex = 14;
            this.BookPublishDate.Text = "publishdate";
            // 
            // BookPublisher
            // 
            this.BookPublisher.AutoSize = true;
            this.BookPublisher.Location = new System.Drawing.Point(722, 90);
            this.BookPublisher.Name = "BookPublisher";
            this.BookPublisher.Size = new System.Drawing.Size(47, 12);
            this.BookPublisher.TabIndex = 13;
            this.BookPublisher.Text = "publish";
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Location = new System.Drawing.Point(698, 69);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(17, 12);
            this.BookID.TabIndex = 12;
            this.BookID.Text = "id";
            // 
            // BookAuthor
            // 
            this.BookAuthor.AutoSize = true;
            this.BookAuthor.Location = new System.Drawing.Point(710, 42);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(41, 12);
            this.BookAuthor.TabIndex = 11;
            this.BookAuthor.Text = "author";
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(663, 225);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(41, 12);
            this.labelSummary.TabIndex = 10;
            this.labelSummary.Text = "概述：";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(663, 199);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(41, 12);
            this.labelPages.TabIndex = 9;
            this.labelPages.Text = "页数：";
            // 
            // labelBinding
            // 
            this.labelBinding.AutoSize = true;
            this.labelBinding.Location = new System.Drawing.Point(663, 168);
            this.labelBinding.Name = "labelBinding";
            this.labelBinding.Size = new System.Drawing.Size(41, 12);
            this.labelBinding.TabIndex = 8;
            this.labelBinding.Text = "装帧：";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(663, 141);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 12);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "价格：";
            // 
            // labelPublishDate
            // 
            this.labelPublishDate.AutoSize = true;
            this.labelPublishDate.Location = new System.Drawing.Point(663, 117);
            this.labelPublishDate.Name = "labelPublishDate";
            this.labelPublishDate.Size = new System.Drawing.Size(65, 12);
            this.labelPublishDate.TabIndex = 6;
            this.labelPublishDate.Text = "出版时间：";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(663, 90);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(53, 12);
            this.labelPublisher.TabIndex = 5;
            this.labelPublisher.Text = "出版社：";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(663, 69);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(29, 12);
            this.labelBookID.TabIndex = 4;
            this.labelBookID.Text = "ID：";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(663, 42);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 12);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "作者：";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(710, 15);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(53, 12);
            this.BookName.TabIndex = 2;
            this.BookName.Text = "bookname";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(663, 15);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(41, 12);
            this.labelBookName.TabIndex = 1;
            this.labelBookName.Text = "书名：";
            // 
            // pictureBoxBookImag
            // 
            this.pictureBoxBookImag.Location = new System.Drawing.Point(468, 15);
            this.pictureBoxBookImag.MaximumSize = new System.Drawing.Size(185, 222);
            this.pictureBoxBookImag.MinimumSize = new System.Drawing.Size(185, 222);
            this.pictureBoxBookImag.Name = "pictureBoxBookImag";
            this.pictureBoxBookImag.Size = new System.Drawing.Size(185, 222);
            this.pictureBoxBookImag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookImag.TabIndex = 0;
            this.pictureBoxBookImag.TabStop = false;
            this.pictureBoxBookImag.WaitOnLoad = true;
            // 
            // ReadDoubanAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReadDoubanAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "豆瓣API";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookImag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox textBoxDoubanAPI;
        private System.Windows.Forms.Label labelDouban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxBookImag;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelPublishDate;
        private System.Windows.Forms.Label BookPrice;
        private System.Windows.Forms.Label BookPublishDate;
        private System.Windows.Forms.Label BookPublisher;
        private System.Windows.Forms.Label BookID;
        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelBinding;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label BookBinding;
        private System.Windows.Forms.Label BookPages;
        private System.Windows.Forms.RichTextBox richTextBoxSummery;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn API;
    }
}

