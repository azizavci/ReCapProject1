using Business.Abstract;
using Business.Constants.ReCapConstants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public IResult Add(Customer customer)
        {
            _customerDAL.Add(customer);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDAL.Delete(customer);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if(DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>(_customerDAL.GetAll(), Messages.UsersListed);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDAL.Get(u => u.Id == customerId));
        }

        public IResult Update(Customer customer)
        {
            _customerDAL.Update(customer);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
