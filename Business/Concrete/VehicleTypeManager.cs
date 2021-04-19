using Business.Abstract;
using Business.BusinessAspects;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class VehicleTypeManager : IVehicleTypeService
    {

        IVehicleTypeDal _vehicleTypeDal;

        public VehicleTypeManager(IVehicleTypeDal vehicleTypeDal)
        {
            _vehicleTypeDal = vehicleTypeDal;
        }

        //[SecuredOperation("user")]
        //[CacheRemoveAspect("IVehicleTypeService.Get")]
        public IResult Add(VehicleType vehicleType)
        {
            _vehicleTypeDal.Add(vehicleType);
            return new SuccessResult(Messages.TypeAdded);
        }

        //[SecuredOperation("user")]
        //[CacheRemoveAspect("IVehicleTypeService.Get")]
        public IResult Delete(VehicleType vehicleType)
        {
            _vehicleTypeDal.Delete(vehicleType);
            return new SuccessResult(Messages.TypeDeleted);
        }

        //[CacheAspect]
        public IDataResult<VehicleType> GetByVehicleTypeId(int vehicleTypeId)
        {
            return new SuccessDataResult<VehicleType>(_vehicleTypeDal.Get(t => t.Id == vehicleTypeId));
        }

        //[CacheAspect]
        public IDataResult<List<VehicleType>> GetVehicleTypes()
        {
            return new SuccessDataResult<List<VehicleType>>(_vehicleTypeDal.GetAll());
        }

        //[CacheRemoveAspect("IVehicleTypeService.Get")]
        //[SecuredOperation("user")]
        public IResult Update(VehicleType vehicleType)
        {
            _vehicleTypeDal.Update(vehicleType);
            return new SuccessResult(Messages.TypeUpdated);
        }
    }
}
