﻿using Business.Abstract;
using Business.Constants.ReCapConstants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDAL.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDAL.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDAL.Get(u => u.EMail == email);
        }
    }
}
