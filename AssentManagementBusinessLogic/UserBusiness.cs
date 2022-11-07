using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AssentManagementBusinessObject;
using AssentManagementRepository;

namespace AssentManagementBusinessLogic
{
    public class UserBusiness
    {
        private User_DataEntities _dataEntities1;
        public UserBusiness()
        {
            _dataEntities1 = new User_DataEntities();
        }

        /// <summary>
        /// login
        /// </summary>
        /// <param name="userRequest"></param>
        /// <returns></returns>
        public UserResponse login(LoginRequest loginRequest)
        {
            UserResponse userResponse = new UserResponse();
            var userlist = GetAllUser();
            var existingUsername = userlist.Where(stringToCheck => stringToCheck.username.Contains(loginRequest.Username));
            var dbPassword = existingUsername.Select(x => x.password).ToList();
            string matchPassword = string.Join(",", dbPassword);
            var validatePassword = IsBase64String(matchPassword);
            if (validatePassword == true)
            {
                string decodedPassword = GenerateDecryptedPassword(matchPassword);
                if (decodedPassword != string.Empty)
                {
                    userResponse = new UserRepository().login(loginRequest, decodedPassword);
                }
                else
                {
                    userResponse.UserResponseMessage = Constants.LOGIN_UNSUCCESSFUL;
                }
            }
            else
            {
                userResponse.UserResponseMessage = Constants.LOGIN_UNSUCCESSFUL;
            }
            return userResponse;
        }

        /// <summary>
        /// IsBase64String
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsBase64String(string password)
        {
            password = password.Replace(' ', '+').Trim();
            return (password.Length % 4 == 0) && Regex.IsMatch(password, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
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

        /// <summary>
        /// GenerateEncryptedPassword
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GenerateEncryptedPassword(string password)
        {
            try
            {
                byte[] encryptByte = new byte[password.Length];
                encryptByte = System.Text.Encoding.UTF8.GetBytes(password);
                string EncryptPassword = Convert.ToBase64String(encryptByte);
                return EncryptPassword;
            }
            catch (Exception ex)
            {
                throw new Exception(Constants.ENCRYPTION_ERROR + ex.Message);
            }
        }

        /// <summary>
        /// GenerateDecryptedPassword
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string GenerateDecryptedPassword(string password)
        {
            try
            {
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                System.Text.Decoder UTF8Decrypter = encoding.GetDecoder();
                byte[] UTF8DecrypteByte = Convert.FromBase64String(password.ToString());
                int Count = UTF8Decrypter.GetCharCount(UTF8DecrypteByte, 0, UTF8DecrypteByte.Length);
                char[] DecrypterChar = new char[Count];
                UTF8Decrypter.GetChars(UTF8DecrypteByte, 0, UTF8DecrypteByte.Length, DecrypterChar, 0);
                string DecodedPassword = new string(DecrypterChar);
                return DecodedPassword;
            }
            catch (Exception ex)
            {
                throw new Exception(Constants.DECRYPTION_ERROR + ex.Message);
            }
        }

        /// <summary>
        /// ValidateMobile
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public static bool ValidateMobile(string mobileNumber)
        {
            if (mobileNumber != null)
            {
                return Regex.IsMatch(mobileNumber, Constants.MOBILE_VALIDATION);
            }
            else
            {
                return false;
            }
        }
    }

    
}
