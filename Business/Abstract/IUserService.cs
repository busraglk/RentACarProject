using Core.Entities.Concrete;
using Core.Utilies.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    { 
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<User> GetById(int id);
        List<OperationClaim> GetClaims(User user);
        IDataResult<List<User>> GetAll();
        User GetByMail(string email);
        IDataResult<User> GetUserByMail(string email);
        IDataResult<User> GetLastUser();
    }
}
