using Core.Entities.Concrete;
using Core.Utilies.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int id);
        IResult Update(User user);

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
