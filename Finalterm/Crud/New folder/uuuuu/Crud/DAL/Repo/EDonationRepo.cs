using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;
namespace DAL.Repo
{
    public class EDonationRepo : IRepo<tbl_donation, int, bool>
    {
        fund_dbEntities db;
        public EDonationRepo(fund_dbEntities db)
        {
            this.db = db;
        }

        public bool Create(tbl_donation obj)
        {
            db.tbl_donation.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.tbl_donation.Remove(Get(id));
            db.SaveChanges();
            // return true;

            return true;
        }

        public List<tbl_donation> Get()
        {
            return db.tbl_donation.ToList();
        }

        public tbl_donation Get(int id)
        {
            return db.tbl_donation.Find(id);
        }

        public bool Update(tbl_donation obj)
        {
            var exst = db.tbl_donation.FirstOrDefault(x => x.UserId == obj.UserId);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
