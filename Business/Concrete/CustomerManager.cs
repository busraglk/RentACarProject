using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
          
            _customerDal.Add(customer);
            return new SuccessResult(Messages.AddedCustomer);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.DeletedCustomer);
        }

        [CacheAspect]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>> (_customerDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<List<Customer>> GetByCustomerId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Id == id), Messages.CustomersListed);
        }

        public IDataResult<CustomerDetailDto> GetByEmail(string email)
        {
            var getByEmail = _customerDal.GetByEmail(u => u.Email == email);
            return new SuccessDataResult<CustomerDetailDto>(getByEmail);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails(), Messages.CustomersListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.UpdatedCustomer);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerUserId(int userId)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(
            _customerDal.GetCustomerUserId(u => u.UserId == userId));
        }
    }
}
