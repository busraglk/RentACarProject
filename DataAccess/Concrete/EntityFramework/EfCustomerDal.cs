using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = c.Id,
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = c.CompanyName,
                                 Status = u.Status,
                                 FindexPoint =c.FindexPoint,
                                 Claims = (from uoc in context.UserOperationClaims.Where(ct => c.UserId == u.Id)
                                           join claim in context.OperationClaims on uoc.OperationClaimId equals claim.Id
                                           select claim.Name).ToList()
                             };

                return result.ToList();

            }
        }
        public CustomerDetailDto GetByEmail(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from cu in context.Customers
                             join u in context.Users
                             on cu.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 CustomerId = cu.Id,
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = cu.CompanyName,
                                 FindexPoint = cu.FindexPoint
                             };

                return result.SingleOrDefault(filter);
            }

        }
        public List<CustomerDetailDto> GetCustomerUserId(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                                 on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = c.Id,
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = c.CompanyName,
                                 FindexPoint = c.FindexPoint


                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
  }