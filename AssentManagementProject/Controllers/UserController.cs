using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AssentManagementBusinessLogic;
using AssentManagementBusinessObject;
using AssentManagementRepository;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace AssentManagementProject.Controllers
{

    public class UserController : ApiController
    {
        /// <summary>
        /// login
        /// </summary>
        /// <param name="userRequest"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [Route("login")]
        [HttpPost]
        public UserResponse login(LoginRequest loginRequest)
        {
            try
            {
                if (loginRequest.Username != string.Empty && loginRequest.Password != string.Empty)
                {
                    return new UserBusiness().login(loginRequest);

                }
                else
                {
                    return new UserResponse
                    {
                        UserResponseMessage = Constants.LOGIN_FIELD
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}