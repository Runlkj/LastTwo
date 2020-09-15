using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.Entitys
{
    public  class JobInfo : AuditedAggregateRoot<int>
    {
        public string JobName { get; set; }
    }
}
