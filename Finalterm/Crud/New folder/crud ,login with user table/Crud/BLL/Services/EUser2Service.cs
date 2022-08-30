using BLL.BOs;
using DAL;
using DAL.Repo;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services
{
    public class EUser2Service
    {
        public static List<EUser2Model> Get()
        {
            var data = DataAccessFactory.GetUsers2DataAccess().Get();
            var d = new List<EUser2Model>();
            foreach (var item in data)
            {
                d.Add(new EUser2Model() {
                    dnId = item.dnId,
                    dnName = item.dnName,
                    dnEmail = item.dnEmail,
                    dnGender = item.dnGender,
                    dnPassword = item.dnPassword,
                    dnUserName = item.dnUserName,
                
               });
            }
            return d;
        }

        public static EUser2Model GetOnly(int id)
        {
            var item = DataAccessFactory.GetUsers2DataAccess().Get(id);
            var d = new EUser2Model() { 
                dnId = item.dnId, 
                dnName = item.dnName,
                dnEmail = item.dnEmail,
                dnGender = item.dnGender,
                dnPassword = item.dnPassword,
                dnUserName = item.dnUserName,
            };
            return d;

        }

        public static bool Create(EUser2Model item)
        {
            var user = new users2()
            {
                dnId = item.dnId,
               dnName = item.dnName,
               dnEmail = item.dnEmail,
               dnGender=item.dnGender,
               dnPassword=item.dnPassword,
               dnUserName   = item.dnUserName,
            };
            return DataAccessFactory.GetUsers2DataAccess().Create(user);
        }

        //public static object Update(EUser2Model st)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool Update(EUser2Model users)
        {
            // return DataAccessFactory.GetUsers2DataAccess().Update(users);
            var config = new MapperConfiguration(c => c.CreateMap<EUser2Model, users2>());
            var mapper = new Mapper(config);
            var data = mapper.Map<users2>(users);
            return DataAccessFactory.GetUsers2DataAccess().Update(data);
        }

        public static bool Delete(int id)
        {
            // throw new NotImplementedException();
           return DataAccessFactory.GetUsers2DataAccess().Delete(id);
            //return item;
            
            //var d1 = new EUser2Model() { dnId = item.dnId };
           // return d1;
        }
    }
}
