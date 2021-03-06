﻿using System;
using System.Collections.Generic;
using System.Text;
using UserLoginMVC.Controller;

namespace UserLoginMVC.UserLoginModal
{
    class UserData
    {
        private List<User> userArr = new List<User>();

        public List<User> TestUser
        {
            get
            {
                if (userArr.Count < 1)
                {
                    userArr.Add(new User("pepipepi", "pepipepipepi", "111111111", UserRoles.ADMIN, DateTime.Now, DateTime.MaxValue));
                    userArr.Add(new User("achoacho", "achoachoacho", "222222222", UserRoles.STUDENT, DateTime.Now, DateTime.MaxValue));
                    userArr.Add(new User("ivanivan", "ivanivanivan", "333333333", UserRoles.ADMIN, DateTime.Now, DateTime.MaxValue));
                }
                return userArr;
            }
            set { }
        }
    }
}
