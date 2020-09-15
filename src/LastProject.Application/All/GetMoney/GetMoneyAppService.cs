using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LastProject.All.GetMoney.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LastProject.All.GetMoney
{
    public class GetMoneyAppService : AsyncCrudAppService<Entitys.GetMoney, GetMoneyDto, int,
        PagedResultRequestDto, CreateUpdateGetMoneyDto, CreateUpdateGetMoneyDto>, IGetMoneyAppService
    {
        public GetMoneyAppService(IRepository<Entitys.GetMoney, int> repository)
             : base(repository)
         {
 
         }
        public override Task<GetMoneyDto> CreateAsync(CreateUpdateGetMoneyDto input)
        {
            return base.CreateAsync(input);
        }
        public override Task<PagedResultDto<GetMoneyDto>> GetAllAsync(PagedResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }
        public override Task<GetMoneyDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }
        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }
        protected override Task<Entitys.GetMoney> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }
        public override Task<GetMoneyDto> UpdateAsync(CreateUpdateGetMoneyDto input)
        {
            return base.UpdateAsync(input);
        }
        
    }
}
