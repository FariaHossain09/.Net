using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
//using DAL.Interfaces;
//using DAL.Repo;

namespace DAL
{
       public class DataAccessFactory
       {
            static fund_dbEntities db = new fund_dbEntities();
            public static IRepo<users2, int, bool> GetUsers2DataAccess()
            {
                return new EUser2Repo(db);
            }


            public static IRepo<users1, int, bool> GetUsers1DataAccess()
            {
                return new EUser1Repo(db);
            }

            public static IRepo<tbl_donation, int, bool> GetDonationDataAccess()
            {
                return new EDonationRepo(db);
            }

            public static IRepo<employee, int, bool> GetEmployeeDataAccess()
            {
                return new EmployeeRepo(db);
            }


            public static IRepo<User, string, bool> GetUserDataAccess()
            {
                return new UserRepo(db);
            }
        //public static IAuth<User> GetAuthDataAccess()
        //{
        //    return new UserRepo(db);
        //}

            public static IAuth<employee> GetAuthDataAccess()
            {
                return new EmployeeRepo(db);
            }
        public static IRepo<Token, string, Token> GetTokenDataAccess()
            {
                return new TokenRepo(db);
            }


    }
    
}
