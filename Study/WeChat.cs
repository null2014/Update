using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class WeChat
    {
        public void WeChatTest()
        {
            sNews m=new sNews();
            m.FromUserName = ReadXml.ReadModel("FromUserName",model);
            m.ToUserName = ReadXml.ReadModel("ToUserName", model);
            m.CreateTime = long.Parse(ReadXml.ReadModel("CreateTime", model));
            m.MsgType = "news";

            m.ArticleCount = 5;
            List<ArticlesModel> listNews=new List<ArticlesModel>();
            for (int i = 0; i < 6; i++)
            {
                ArticlesModel ma=new ArticlesModel();
                ma.Title = "";

            }

        }

       
    }
}
