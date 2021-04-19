﻿using Core.Utilies.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetByCustomerId(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomerUserId(int userId);
        IDataResult<CustomerDetailDto> GetByEmail(string email);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    }
}
