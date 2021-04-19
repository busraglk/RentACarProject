using Business.Abstract;
using Business.Constants;
using Core.Utilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {

            if (CheckCreditCard(creditCard))
                return new SuccessResult(Messages.CardAlreadyExists);

            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.AddedCreditCard);
        }


        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.DeletedCreditCard);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(), Messages.ListedCars);
        }

        public IDataResult<CreditCard> GetByCreditCardNumber(string creditCardNumber)
        {
            var result = _creditCardDal.Get(c => c.CreditCardNumber == creditCardNumber);
            return new SuccessDataResult<CreditCard>(result);
        }

        public IDataResult<List<CreditCard>> GetCardsByCustomerId(int customerId)
        {
            var result = _creditCardDal.GetAll(card => card.CustomerId == customerId);
            return new SuccessDataResult<List<CreditCard>>(result);
        }
        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.UpdatedCreditCard);
        }

        private bool CheckCreditCard(CreditCard card)
        {
            var creditCard = _creditCardDal.Get(c => c.CustomerId == card.CustomerId);

            if (card == null)
                return false;

            if (card.CreditCardNumber == card.CreditCardNumber)
                return true;

            return false;
        }
    }
}
