using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ReadDoubanAPI
{
    public class GetDataSource
    {
        /// <summary>
        /// 通过HTTP协议，读取API内容
        /// </summary>
        /// <param name="geturl">API地址</param>
        /// <returns>将json内容以string返回</returns>
        public string GetJsonFile(string geturl)
        {
            try
            {
                HttpWebRequest myRequest = null;
                HttpWebResponse myHttpResponse = null;
                myRequest = (HttpWebRequest)WebRequest.Create(geturl);
                myHttpResponse = (HttpWebResponse)myRequest.GetResponse();
                StreamReader reader = new StreamReader(myHttpResponse.GetResponseStream());
                string jsonFile = reader.ReadToEnd();
                reader.Close();
                myHttpResponse.Close();
                return jsonFile;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// 根据书名查找相关类型的书籍
        /// </summary>
        /// <param name="tags">书名或类型</param>
        /// <returns>将json内容以string返回</returns>
        public string GetBookTag(string tags)
        {
            try
            {
                string temp = "https://api.douban.com/v2/book/search?q=" + tags + "&start=0&count=20" ;
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(temp);
                HttpWebResponse myHttpResponse = (HttpWebResponse)myRequest.GetResponse();
                StreamReader reader = new StreamReader(myHttpResponse.GetResponseStream(), Encoding.UTF8);
                string tagsFile = reader.ReadToEnd();
                reader.Close();
                myHttpResponse.Close();
                return tagsFile;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
