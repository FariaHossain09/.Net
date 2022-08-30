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
    public class EDonationService
    {
        public static List<EDonationModel> Get()
        {
            var data = DataAccessFactory.GetDonationDataAccess().Get();
            var d = new List<EDonationModel>();
            foreach (var item in data)
            {
                d.Add(new EDonationModel()
                {
                    UserId = item.UserId,
                    UserName = item.UserName,
                    Ammount = item.Ammount
                });
            }
            return d;
        }

        public static EDonationModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetDonationDataAccess().Get(id);
            var d = new EDonationModel()
            {
                UserId = item.UserId,
                UserName = item.UserName,
                Ammount = item.Ammount
            };
            return d;

        }

        public static bool Create(EDonationModel item)
        {
            var user = new tbl_donation()
            {
                UserId = item.UserId,
                UserName = item.UserName,
                Ammount = item.Ammount
            };
            return DataAccessFactory.GetDonationDataAccess().Create(user);
        }

        //public static object Update(EUser2Model st)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool Update(EDonationModel users)
        {
            //return DataAccessFactory.GetDonationDataAccess().Update(users);
            var config = new MapperConfiguration(c => c.CreateMap<EDonationModel, tbl_donation>());
            var mapper = new Mapper(config);
            var data = mapper.Map<tbl_donation>(users);
            return DataAccessFactory.GetDonationDataAccess().Update(data);
        }

        public static bool Delete(int id)
        {
            // throw new NotImplementedException();
            return DataAccessFactory.GetDonationDataAccess().Delete(id);
            //return item;

            //var d1 = new EUser2Model() { dnId = item.dnId };
            // return d1;
        }
    }
}
