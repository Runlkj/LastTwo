using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.Entitys
{
    public class PriceInfo: AuditedAggregateRoot<int>
    {
        public string HName { get; set; }
    }
}
