using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<VehicleMakeEntity, VehicleDto>();

            CreateMap<VehicleModelEntity, VehicleDto>();
        }
    }
}
