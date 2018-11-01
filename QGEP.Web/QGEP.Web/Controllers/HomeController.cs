using QGEP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace QGEP.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string token = "apolo666";
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Submit(Person person)
        {
            return Json(new { Code = "200", Msg = "测试，错误" });

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //微信验证端口
        public ActionResult WeiXin()
        {
            string echoStr = Request.QueryString["echoStr"];
            string signature = Request.QueryString["signature"];
            string timestamp = Request.QueryString["timestamp"];
            string nonce = Request.QueryString["nonce"];
            if (CheckSignature(token, signature, timestamp, nonce) && !string.IsNullOrEmpty(echoStr))
            {
                Response.Write(echoStr);
                Response.End();
            }
            return View();

        }

        //微信密码验证
        private static bool CheckSignature(string Token, string signature, string timestamp, string nonce)
        {
            string[] arrTmp = { Token, timestamp, nonce };
            Array.Sort(arrTmp);
            string tmpStr = string.Join("", arrTmp);
            var sha1 = SHA1.Create();
            string truePwd = BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(tmpStr)));
            if (tmpStr != null)
            {
                tmpStr = tmpStr.ToLower();
                return tmpStr == signature;
            }
            return false;
        }
    }
}