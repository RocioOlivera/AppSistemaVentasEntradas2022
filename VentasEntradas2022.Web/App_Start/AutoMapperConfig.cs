using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VentasEntradas2022.Web.Mapping;

namespace VentasEntradas2022.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            Mapper = config.CreateMapper();
        }
    }
}