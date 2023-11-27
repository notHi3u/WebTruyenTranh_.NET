using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class AutoMapperProfile : Profile
    {
        //dùng để map dto-bll và bll-ui
        public AutoMapperProfile()
        {
            //CreateMap<SourceType, DestinationType>();
        }
    }
}
