using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Security.Claims;
using AssentManagementBusinessObject;


namespace AssentManagementRepository
{
    public class UserRepository
    {
        private User_DataEntities _dataEntities1;
        public UserRepository()
        {
            _dataEntities1 = new User_DataEntities();
        }

        /// <summary>
        /// login
        /// </summary>
        /// <param name="userRequest"></param>
        /// <param name="decodedPassword"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public UserResponse login(LoginRequest loginRequest, string decodedPassword)
        {
            try
            {
                UserResponse userResponse = new UserResponse();

                var usernamelist = GetAllUser();
                var existingUsers = usernamelist.Where(stringToCheck => stringToCheck.username.Contains(loginRequest.Username));
                var matchingUsers = existingUsers.Select(x => x.username).ToList();
                string matchUsername = string.Join(",", matchingUsers);
                if (matchUsername == loginRequest.Username && decodedPassword == loginRequest.Password)
                {
                    userResponse.UserResponseMessage = Constants.LOGIN_SUCCESSFUL;
                }
                else
                {
                    userResponse.UserResponseMessage = Constants.LOGIN_UNSUCCESSFUL;
                }
                return userResponse;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// GetAllUser
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserLoginData> GetAllUser()
        {
            List<UserLoginData> users = _dataEntities1.UserLoginDatas.Where(a => a.isDeleted == Constants.DEFAULT_ISDELETED_VALUE).ToList();
            return users;

        }
    }
}
