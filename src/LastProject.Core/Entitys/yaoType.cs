﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace LastProject.Entitys
{
   public class yaoType: AuditedAggregateRoot<int>
    {
        [StringLength(30)]
        public string TypeName { get; set; }
    }
}
