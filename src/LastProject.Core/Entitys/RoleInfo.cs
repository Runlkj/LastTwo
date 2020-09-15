using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.Entitys
{
    public class RoleInfo: AuditedAggregateRoot<int>
    {
        public string Rname { get; set; }
    }
}
