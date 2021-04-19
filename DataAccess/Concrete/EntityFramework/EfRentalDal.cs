using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.BrandId equals co.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CarId = c.Id,
                                 CarName = c.Description,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 CarModelYear = c.ModelYear,
                                 CarDailyPrice = c.DailyPrice,
                                 CarDescription = c.Description,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate


                             };
                return result.ToList();


            }
        }

    }
 }

