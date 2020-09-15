using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LastProject.All.GetMoney.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LastProject.All.GetMoney
{
    public interface IGetMoneyAppService: IAsyncCrudAppService<
        GetMoneyDto,
        int,
        PagedResultRequestDto,
        CreateUpdateGetMoneyDto,
        CreateUpdateGetMoneyDto
        >
    {

    }
}
