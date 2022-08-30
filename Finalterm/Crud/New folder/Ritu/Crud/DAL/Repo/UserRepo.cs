using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    internal class UserRepo : IRepo<User, string, bool>, IAuth<User>
    {
        fund_dbEntities db;
        public UserRepo(fund_dbEntities db)
        {
            this.db = db;
        }

        public User Authenticate(string username, string password)
        {
            return db.Users.FirstOrDefault(u => u.Username.Equals(username)
            && u.Password.Equals(password));

        }

        public bool Create(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }

    }
}
