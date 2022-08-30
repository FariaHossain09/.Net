using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BOs;
using DAL;
using DAL.Repo;
using DAL.EF;
using AutoMapper;
namespace BLL.Services
{
    public class EUser1Service
    {
        public static List<EUser1Model> Get()
        {
            var data = DataAccessFactory.GetUsers1DataAccess().Get();
            var d = new List<EUser1Model>();
            foreach (var item in data)
            {
                d.Add(new EUser1Model() { uId = item.uId, uName = item.uName,uEmail = item.uEmail,
                    uGender = item.uGender,uPassword = item.uPassword,uUserName = item.uUserName
               });
            }
            return d;
        }

        public static EUser1Model GetOnly(int id)
        {
            var item = DataAccessFactory.GetUsers1DataAccess().Get(id);
            var d = new EUser1Model() {
                uId = item.uId,
                uName = item.uName,
                uEmail = item.uEmail,
                uGender = item.uGender,
                uPassword = item.uPassword,
                uUserName = item.uUserName
            };
            return d;

        }

        public static bool Create(EUser1Model item)
        {
            var user = new users1()
            {
                uId = item.uId,
                uName = item.uName,
                uEmail = item.uEmail,
                uGender = item.uGender,
                uPassword = item.uPassword,
                uUserName = item.uUserName,
            };
            return DataAccessFactory.GetUsers1DataAccess().Create(user);
        }

        //public static object Update(EUser2Model st)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool Update(EUser1Model users)
        {
            //return DataAccessFactory.GetUsers1DataAccess().Update(users);
            var config = new MapperConfiguration(c => c.CreateMap<EUser1Model, users1>());
            var mapper = new Mapper(config);
            var data = mapper.Map<users1>(users);
            return DataAccessFactory.GetUsers1DataAccess().Update(data);
        }

        public static bool Delete(int id)
        {
            // throw new NotImplementedException();
            return DataAccessFactory.GetUsers1DataAccess().Delete(id);
            //return item;

            //var d1 = new EUser2Model() { dnId = item.dnId };
            // return d1;
        }
    }
}
