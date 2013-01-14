using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReadDoubanAPI
{
    public partial class ReadDoubanAPI : Form
    {
        public ReadDoubanAPI()
        {
            InitializeComponent();
            this.HideShowMessageBox();
        }
        /// <summary>
        ///将控件都设置为隐藏状态
        /// </summary>
        public void HideShowMessageBox()
        {
            BookName.Visible = false;
            BookAuthor.Visible = false;
            BookID.Visible = false;
            BookPublisher.Visible = false;
            BookPublishDate.Visible = false;
            BookPrice.Visible = false;
            BookBinding.Visible = false;
            BookPages.Visible = false;
            richTextBoxSummery.Visible = false;
            pictureBoxBookImag.Visible = false;
            labelBookName.Visible = false;
            labelAuthor.Visible = false;
            labelBookID.Visible = false;
            labelPublisher.Visible = false;
            labelPublishDate.Visible = false;
            labelPrice.Visible = false;
            labelBinding.Visible = false;
            labelPages.Visible = false;
            labelSummary.Visible = false;
        }

        /// <summary>
        /// 将空间都显示出来
        /// </summary>
        public void ChangeShowMessageBox()
        {
            BookName.Visible = true;
            BookAuthor.Visible = true;
            BookID.Visible = true;
            BookPublisher.Visible = true;
            BookPublishDate.Visible = true;
            BookPrice.Visible = true;
            BookBinding.Visible = true;
            BookPages.Visible = true;
            richTextBoxSummery.Visible = true;
            pictureBoxBookImag.Visible = true;
            labelBookName.Visible = true;
            labelAuthor.Visible = true;
            labelBookID.Visible = true;
            labelPublisher.Visible = true;
            labelPublishDate.Visible = true;
            labelPrice.Visible = true;
            labelBinding.Visible = true;
            labelPages.Visible = true;
            labelSummary.Visible = true;
        }

        /// <summary>
        /// 通过具体API获取图书信息
        /// </summary>
        /// <param name="sender">事件发起者</param>
        /// <param name="e">接收者</param>
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.ChangeShowMessageBox();
                GetDataSource getsource = new GetDataSource();
                string apiUrl = this.textBoxDoubanAPI.Text.ToString().Trim();
                string dateSource = getsource.GetJsonFile(apiUrl);
                JObject readAPI = JObject.Parse(dateSource);
                this.BookName.Text = readAPI["title"].ToString().Trim();
                this.BookAuthor.Text = readAPI["author"][0].ToString().Trim();
                this.BookID.Text = readAPI["id"].ToString().Trim();
                this.BookPublisher.Text = readAPI["publisher"].ToString().Trim();
                this.BookPublishDate.Text = readAPI["pubdate"].ToString().Trim();
                this.BookPrice.Text = readAPI["price"].ToString().Trim();
                this.BookBinding.Text = readAPI["binding"].ToString().Trim();
                this.BookPages.Text = readAPI["pages"].ToString().Trim();
                this.richTextBoxSummery.Text = readAPI["summary"].ToString().Trim();
                this.pictureBoxBookImag.ImageLocation = readAPI["images"]["large"].ToString().Trim();
            }
            catch (Exception)
            {
                this.HideShowMessageBox();
                MessageBox.Show("出现异常，未找到该书或者请检查输入是否正确！");
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                List<Book> list = new List<Book>();
                GetDataSource getdata = new GetDataSource();
                JObject file = JObject.Parse(getdata.GetBookTag(this.textBoxTags.Text));
                var temp = from tags in file["books"].Children()
                           select tags;
                foreach (var tempFile in temp)
                {
                    Book book = new Book();
                    book.Index = list.Count + 1;
                    book.Title = tempFile["title"].ToString().Trim();
                    book.API = tempFile["url"].ToString().Trim();
                    list.Add(book);
                }
                this.dataGridView1.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show("请正确填写信息！");
            }
        }
    }
}

