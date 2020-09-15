using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.Entitys
{
    public class OfficeInfo:AuditedAggregateRoot<int>
    {
        public string KName { get; set; }
    }
}
