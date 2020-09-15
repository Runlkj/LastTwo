using LastProject.All.GetMoney.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastProject.Web.Models.GetMoney
{
    public class GetMoneyListViewModel
    {
        public IReadOnlyList<GetMoneyDto> GetMoneys { get; set; }
    }
}
