using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.Interfaces;

namespace DAL.Repo
{
    public  class EmployeeRepo : IRepo<employee, int, bool>
    {
        fund_dbEntities db;
        public EmployeeRepo(fund_dbEntities db)
        {
            this.db = db;
        }

        public bool Create(employee obj)
        {
            db.employees.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.employees.Remove(Get(id));
            db.SaveChanges();
            // return true;

            return true;
        }

        public List<employee> Get()
        {
            return db.employees.ToList();
        }

        public employee Get(int id)
        {
            return db.employees.Find(id);
        }

        public bool Update(employee obj)
        {
            var exst = db.employees.FirstOrDefault(x => x.eId == obj.eId);
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
