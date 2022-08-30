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
    public  class EmployeeService
    {
        public static List<EmployeeModel> Get()
        {
            var data = DataAccessFactory.GetEmployeeDataAccess().Get();
            var d = new List<EmployeeModel>();
            foreach (var item in data)
            {
                d.Add(new EmployeeModel()
                {
                    eId = item.eId,
                    eName = item.eName,
                    eUserName = item.eUserName,
                    eEmail = item.eEmail,
                    eGender = item.eGender,
                    ePassword = item.ePassword
                   
                });
            }
            return d;
        }

        public static EmployeeModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetEmployeeDataAccess().Get(id);
            var d = new EmployeeModel()
            {
                eId = item.eId,
                eName = item.eName,
                eUserName = item.eUserName,
                eEmail = item.eEmail,
                eGender = item.eGender,
                ePassword = item.ePassword
            };
            return d;

        }

        public static bool Create(EmployeeModel item)
        {
            var user = new employee()
            {
                eId = item.eId,
                eName = item.eName,
                eUserName = item.eUserName,
                eEmail = item.eEmail,
                eGender = item.eGender,
                ePassword = item.ePassword
            };
            return DataAccessFactory.GetEmployeeDataAccess().Create(user);
        }

        //public static object Update(EUser2Model st)
        //{
        //    throw new NotImplementedException();
        //}

        public static bool Update(EmployeeModel user)
        {
            //var users = new employee()
            //{
            //    eId = user.eId,
            //    eName = user.eName,
            //    eUserName = user.eUserName,
            //    eEmail = user.eEmail,
            //    eGender = user.eGender,
            //    ePassword = user.ePassword
            //};
            //return DataAccessFactory.GetEmployeeDataAccess().Update(users);


            var config = new MapperConfiguration(c =>c.CreateMap<EmployeeModel, employee>());
            var mapper = new Mapper(config);
            var data = mapper.Map<employee>(user);
            return DataAccessFactory.GetEmployeeDataAccess().Update(data);


            //var data = Mapper.Map<employee,EmployeeModel>(user);
            //return DataAccessFactory.GetEmployeeDataAccess().Update(data);
        }

        public static bool Delete(int id)
        {
            // throw new NotImplementedException();
            return DataAccessFactory.GetEmployeeDataAccess().Delete(id);
            //return item;

            //var d1 = new EUser2Model() { dnId = item.dnId };
            // return d1;
        }
    }
}
