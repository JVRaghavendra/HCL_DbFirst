using HCL_DbFirst.BusinessEntities.ModelsDTO;
using HCL_DbFirst.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace HCL_DbFirst.ServiceLayer.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void InitializeMap(IServiceCollection services)
        {
            //Initialize all AutoMapper profiles
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile<AutoMapperProfile>();


            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
