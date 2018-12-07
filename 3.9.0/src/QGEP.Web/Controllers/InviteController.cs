using QGEP.Web.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QGEP.Web.Controllers
{
    public class InviteController : QGEPControllerBase
    {
        private const string token = "apolo666";

        // GET: Invite
        public ActionResult Index()
        {
            return View();
        }
     

        public JsonResult Submit(Customer person)
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

        public string getMessage()
        {
            string text = base.Request.QueryString["echoStr"];
            string text2 = base.Request.QueryString["signature"];
            string text3 = base.Request.QueryString["timestamp"];
            string text4 = base.Request.QueryString["nonce"];
            bool flag = !string.IsNullOrEmpty(text);
            if (flag)
            {
                base.Response.Write(text);
                base.Response.End();
            }
            return text;
        }

        //微信验证端口
        //public ActionResult WeiXin()
        //{
        //    string echoStr = Request.QueryString["echoStr"];
        //    string signature = Request.QueryString["signature"];
        //    string timestamp = Request.QueryString["timestamp"];
        //    string nonce = Request.QueryString["nonce"];
        //    if (CheckSignature(token, signature, timestamp, nonce) && !string.IsNullOrEmpty(echoStr))
        //    {
        //        Response.Write(echoStr);
        //        Response.End();
        //    }
        //    return View();

        //}
    }
}