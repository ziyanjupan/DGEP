using Senparc.Weixin.MP;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MvcExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace QGEP.Web.Controllers
{
    public class WeChatController : Controller
    {
        // GET: WeChat
        public static readonly string Token = "apolo666";//与微信公众账号后台的Token设置保持一致，区分大小写。
        public static readonly string EncodingAESKey = "Zd9pSoR1Cw4xGF4ZNVkFjRl6xdMTigLfSJqXtZcEsj0";//与微信公众账号后台的EncodingAESKey设置保持一致，区分大小写。
        public static readonly string AppId = "wx64e930247e026e0f";//与微信公众账号后台的AppId设置保持一致，区分大小写。

        // GET: WC/WeChat
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Index")]
        public Task<ActionResult> Get(string signature, string timestamp, string nonce, string echostr)
        {
            return Task.Factory.StartNew(() =>
            {
                if (CheckSignature.Check(signature, timestamp, nonce, Token))
                {
                    return echostr; //返回随机字符串则表示验证通过
                }
                else
                {
                    return "failed:" + signature + "," + CheckSignature.GetSignature(timestamp, nonce, Token) + "。" +
                        "如果你在浏览器中看到这句话，说明此地址可以被作为微信公众账号后台的Url，请注意保持Token一致。";
                }
            }).ContinueWith<ActionResult>(task => Content(task.Result));
        }


        /// <summary>
        /// 最简化的处理流程
        /// </summary>
        [HttpPost]
        [ActionName("Index")]
        public Task<ActionResult> Post(PostModel postModel)
        {
            return Task.Factory.StartNew<ActionResult>(() =>
            {
                if (!CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, Token))
                {
                    return new WeixinResult("参数错误！");
                }

                postModel.Token = Token;
                postModel.EncodingAESKey = EncodingAESKey; //根据自己后台的设置保持一致
                postModel.AppId = AppId; //根据自己后台的设置保持一致

                var messageHandler = new CustomMessageHandler(Request.InputStream, postModel, 10);

                messageHandler.Execute(); //执行微信处理过程

                return new FixWeixinBugWeixinResult(messageHandler);

            }).ContinueWith<ActionResult>(task => task.Result);
        }

        //微信密码验证
        //private static bool CheckSignature(string Token, string signature, string timestamp, string nonce)
        //{
        //    string[] arrTmp = { Token, timestamp, nonce };
        //    Array.Sort(arrTmp);
        //    string tmpStr = string.Join("", arrTmp);
        //    var sha1 = SHA1.Create();
        //    string truePwd = BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(tmpStr)));
        //    if (tmpStr != null)
        //    {
        //        tmpStr = tmpStr.ToLower();
        //        return tmpStr == signature;
        //    }
        //    return false;
        //}
    }
}