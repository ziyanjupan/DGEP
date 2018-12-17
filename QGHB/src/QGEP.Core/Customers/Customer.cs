using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGEP.Customers
{
    [Table("Customer")]
    public class Customer:Entity<long>
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
        public string ServiceTime { get; set; }
        public virtual DateTime CreationTime { get; set; }

        public Customer()
        {
            CreationTime = DateTime.Now;
        }
    }
}
