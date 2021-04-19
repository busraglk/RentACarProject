using Core.Utilies.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFakeCreditCardService
    {
        IResult IsCardExist(FakeCreditCard fakeCreditCard);
        IResult Add(FakeCreditCard fakeCreditCard);
        IResult Delete(FakeCreditCard fakeCreditCard);
        IResult Update(FakeCreditCard fakeCreditCard);
        IDataResult<List<FakeCreditCard>> GetByCardNumber(string cardNumber);
        IDataResult<List<FakeCreditCard>> GetAll();
        IDataResult<List<FakeCreditCard>> GetCardsByCustomerId(int customerId);
        IDataResult<FakeCreditCard> GetById(int cardId);
       
    }
}
