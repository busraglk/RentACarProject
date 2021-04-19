using Core.Utilies.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetByCustomerId(int customerId);
        IDataResult<List<Rental>> GetRentalByCarId(int carId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<Rental>> GetByRentDate(DateTime first, DateTime last);
        IDataResult<Rental> CheckReturnDate(int carId);


    }
}
