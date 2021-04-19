using Business.Abstract;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FakeCreditCardManager : IFakeCreditCardService
    {
        private IFakeCreditCardDal _fakeCreditCardDal;

        public FakeCreditCardManager(IFakeCreditCardDal fakeCreditCardDal)
        {
            _fakeCreditCardDal = fakeCreditCardDal;
        }

        public IResult Add(FakeCreditCard fakeCreditCard)
        {
            var card = _fakeCreditCardDal.Get(f => f.CreditCardNumber == fakeCreditCard.CreditCardNumber && f.CustomerId == fakeCreditCard.CustomerId);
            if (card != null)
            {
                return new SuccessResult();
            }

            _fakeCreditCardDal.Add(fakeCreditCard);
            return new SuccessResult();
        }

        public IResult Delete(FakeCreditCard fakeCreditCard)
        {
            _fakeCreditCardDal.Delete(fakeCreditCard);
            return new SuccessResult();
        }
            public IDataResult<List<FakeCreditCard>> GetAll()
        {
            return new SuccessDataResult<List<FakeCreditCard>>(_fakeCreditCardDal.GetAll());
        }

        public IDataResult<List<FakeCreditCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<FakeCreditCard>>(_fakeCreditCardDal.GetAll(c => c.CreditCardNumber == cardNumber));
        }

        public IDataResult<FakeCreditCard> GetById(int cardId)
        {
            return new SuccessDataResult<FakeCreditCard>(_fakeCreditCardDal.Get(c => c.Id == cardId));
        }

        public IDataResult<List<FakeCreditCard>> GetCardsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<FakeCreditCard>>(_fakeCreditCardDal.GetAll(c => c.CustomerId == customerId));
        }

        public IResult IsCardExist(FakeCreditCard fakeCreditCard)
        {
            var result = _fakeCreditCardDal.Get(c => c.NameOnTheCard == fakeCreditCard.NameOnTheCard && c.CreditCardNumber == fakeCreditCard.CreditCardNumber);
            if (result == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IResult Update(FakeCreditCard fakeCreditCard)
        {
            _fakeCreditCardDal.Update(fakeCreditCard);
            return new SuccessResult();
        }
    }
}
