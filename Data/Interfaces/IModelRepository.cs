using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IModelRepository : IDisposable
    {
        void Insert(VehicleModelEntity entity);

        void Update(VehicleModelEntity entity);

        void Delete(VehicleModelEntity entity);
    }
}
