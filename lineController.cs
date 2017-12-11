using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class lineController : ApiController
    {

        public class LineChatController : ApiController
        {
            [HttpPost]
            public IHttpActionResult POST()
            {
                string ChannelAccessToken = "vY9P9KU7UftcYE8aH8cvwNOl2c2d + MUAbwGeRsHI7 / 7hzX8 + JgL7y4oK9hulsBN2IfNhCbMq1KPDpCYeW85CSfAcJmhiFufW / 4Y2zB9slNFcj1TMwY++4 / LsJOeX + w3ma1R3Wt34U / 68NRm3zxUL6gdB04t89 / 1O / w1cDnyilFU =";

                try
                {
                    //取得 http Post RawData(should be JSON)
                    string postData = Request.Content.ReadAsStringAsync().Result;
                    //剖析JSON
                    var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                    //回覆訊息
                    string Message;
                    Message = "你說了:" + ReceivedMessage.events[0].message.text;
                    //回覆用戶
                    isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Message, ChannelAccessToken);
                    //回覆API OK
                    return Ok();
                }
                catch (Exception ex)
                {
                    return Ok();
                }
            }
        }
    }
}

