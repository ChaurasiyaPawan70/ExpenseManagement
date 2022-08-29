using AutoMapper;
using ExpenseManagament.DAL.DTO;
using ExpenseManagament.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagament.DAL.Mapping
{
    public class MasterMapper : Profile
    {
        public MasterMapper()
        {
            CreateMap<PurposeMaster, PurposeMasterDTO>();
            CreateMap<CurrencyMaster, CurrencyMasterDTO>();
        }
    }

}