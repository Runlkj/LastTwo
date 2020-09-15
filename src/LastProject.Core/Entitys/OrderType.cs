using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.Entitys
{
    public class OrderType:AuditedAggregateRoot<int>
    {
        public string Name { get; set; }

    }
}
