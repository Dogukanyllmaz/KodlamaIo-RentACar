using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVehicleTypeService 
    {
        IResult Add(VehicleType vehicleType);
        IResult Delete(VehicleType vehicleType);
        IResult Update(VehicleType vehicleType);
        IDataResult<List<VehicleType>> GetVehicleTypes();
        IDataResult<VehicleType> GetByVehicleTypeId(int vehicleTypeId);
    }
}
