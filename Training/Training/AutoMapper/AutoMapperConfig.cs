using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Training.DataAccess.Model;
using Training.Model;

namespace Training.AutoMapper
{
    public class AutoMapperConfig
    {
      public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<TrainingModel, TrainingDetails>()
                    .ForMember(m => m.Id, map => map.Ignore())
                    .ForMember(m => m.StartDate, opt => opt.MapFrom(src => src.TrainingStartDate))
                    .ForMember(m => m.EndDate, opt => opt.MapFrom(src => src.TrainingEndDate));
            });
        }
    }
}