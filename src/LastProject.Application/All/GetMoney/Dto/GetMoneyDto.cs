﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.All.GetMoney.Dto
{
    [AutoMapFrom(typeof(Entitys.GetMoney))]
    public class GetMoneyDto:EntityDto<int>
    {
        public string Code { get; set; }
        public int GetMoneyTypeId { get; set; }
        public int RegInfoId { get; set; }
        public int OfficeInfoId { get; set; }
        public DateTime CreateTime { get; set; }
        public int GetQian { get; set; }
        public int GetTypeId { get; set; }
    }
}
