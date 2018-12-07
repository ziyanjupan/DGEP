using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QGEP.Web.Models.Customer
{
    public class Customer
    {
        /// <summary>
        /// 小区
        /// </summary>
        public string Community { get; set; }
        /// <summary>
        /// 房号
        /// </summary>
        public string RoomNumber { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 服务时间
        /// </summary>
        public string Dghb_time { get; set; }
    }
}