using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QGEP.Web.Models
{
    public class Person
    {
        /// <summary>
        /// 小区
        /// </summary>
        public string community { get; set; }
        /// <summary>
        /// 房号
        /// </summary>
        public string roomNumber { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// 服务时间
        /// </summary>
        public string dghb_time { get; set; }
    }
}