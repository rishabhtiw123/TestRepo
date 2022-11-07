using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssentManagementBusinessObject
{
    public class Constants
    {
        public const bool DEFAULT_ISDELETED_VALUE = false;

        public const string REGISTRATION_SUCCESSFULL = "Registered Successfully.";
        public const string REGISTRATION_UNSUCCESSFUL = "There is some error regitrating.";
        public const string ALREADY_REGISTARED = "You have already registered with this Username. Please provide another Username.";

        public const string ENCRYPTION_ERROR = "Error While Encrypting Password.";
        public const string DECRYPTION_ERROR = "Error While Decrypting Password.";

        public const string LOGIN_SUCCESSFUL = "Login Successful.";
        public const string LOGIN_UNSUCCESSFUL = "Invalid Username and Password.";
        public const string LOGIN_FIELD = "Please enter the Username and Password to login.";

        public const string MOBILE_VALIDATION = @"^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[456789]\d{9}|(\d[ -]?){10}\d$";
        public const string EMAIL_VALIDATION = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const string VALID_NUMBER = "Mobile number is valid";
        public const string INVALID_NUMBER = "Mobile number is invalid";
        public const string EMPTY_NUMBER = "Mobile number is empty";

        public const string EMPTY_FIELD = "Please fill the required given field.";

        public const string EMPLOYEE_ADDED = "Employee added Successfully.";
        public const string EMPLOYEE_NOT_ADDED = "There is some error while adding Employee.";

        public const string EMPLOYEE_UPDATED = "Employee updated Successfully.";
        public const string EMPLOYEE_NOT_UPDATED = "There is some error while updating Employee.";

        public const string EMPLOYEE_DELETED = "Employee deleted Successfully.";
        public const string EMPLOYEE_NOT_DELETED = "There is some error while deleting Employee.";

        public const string STUDENT_ADDED = "Student added Successfully.";
        public const string STUDENT_NOT_ADDED = "There is some error while adding student.";

        public const string STUDENT_UPDATED = "Student updated Successfully.";
        public const string STUDENT_NOT_UPDATED = "There is some error while updating student.";

        public const string STUDENT_DELETED = "Student deleted Successfully.";
        public const string STUDENT_NOT_DELETED = "There is some error while deleting student.";

        public const string EXCEPTION_ERROR = "There is some exception error.";

        public const string DELETED_EMPLOYEE = "This employee is already deleted.";
        public const string NO_EMPLOYEE = "There are no employee to diaplay.";

        public const string NO_DATA = "\"Data not available.";
        public const string INVALID_ID = "Invalid ID";

        public const string EMAILID_REQUIED = "Please provide an email to send the OTP.";
        public const string EMAIL_SENT_SUCCESSFULY = "Email sent successfuly.";
        public const string EMAIL_NOT_SENT_SUCCESSFULY = "Email not sent successfuly.";
        public const string INVALID_EMAIL = "Invalid email address.";

        public const string MOBILE_NUMBER_REQUIED = "Please provide a mobile number to send the OTP.";
        public const string MESSAGE_SENT_SUCCESSFULY = "Message sent successfuly.";
        public const string MESSAGE_NOT_SENT_SUCCESSFULY = "Message not sent successfuly.";
        public const string INVALID_MOBILE_NUMBER = "Invalid Mobile Number.";
        public const string NUMBER_CODE = "+91";

        public const string TWILIO_NUMBER = "+19704144542";
        public const string TWILIO_ACCOUNT_SID = "AC0f09afd0db01357968da4502d9e71c7a";
        public const string TWILIO_AUTH_TOKEN = "cfbbb34da06a0bebe6a7cbb40eedbc15";

        public const string ADMIN_EMAIL = "rishabh.t@innomick.com";
        public const string ADMIN_PASSWORD = "fjzfgoacbyggmhno";
        public const string SUBJECT = "This is your OTP.";
        public const string OTP_MESSAGE = " is your One-Time Password, valid for 10 minutes only, Please do not share your OTP with anyone.";
        public const string SMTP_CLIENT = "smtp.gmail.com";

        public const string OTP_DIGITS = "1234567890";
        public const int OTP_length = 5;


    }
}
