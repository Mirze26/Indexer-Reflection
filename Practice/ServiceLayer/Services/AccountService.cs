using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        

        public string Register(string username, string email, string password)
        {
            try
            {
                var result = GetAllEmails();

                if (result.Contains(email))
                {

                    throw RegisterException(ResponseMessages.InvalidRegisterMessage);

                }
                return "Register success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }

        private Exception RegisterException(string ınvalidRegisterMessage)
        {
            throw new NotImplementedException();
        }

        private List<string> GetAllEmails()
        {
            return new List<string>() { "pervin12@gmail.com", "ali111@gmail.com", "qemlo@gmail.com" };
        }


    }
}
