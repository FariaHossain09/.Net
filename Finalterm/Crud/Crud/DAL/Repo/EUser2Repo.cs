using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{


    public class EUser2Repo : IRepo<users2, int, bool>
    {
        fund_dbEntities db;
        public EUser2Repo(fund_dbEntities db)
        {
            this.db = db;
        }

        public bool Create(users2 obj)
        {
            db.users2.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        //public bool Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public List<users2> Get()
        {
            return db.users2.ToList();
        }

        
        public users2 Get(int id)
        {
            return db.users2.Find(id);
        }

        public bool Update(users2 obj)
        {
            var exst = db.users2.FirstOrDefault(x => x.dnId == obj.dnId);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.users2.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

    }
}
