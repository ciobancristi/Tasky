using System;
using Tasky.Services.Helpers;

namespace Tasky.Services
{
    public interface IValidationService
    {
        bool IsValidEmail(string email);
    }

    public class ValidationService : IValidationService
    {
        public bool IsValidEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException();

            var regexUtil = new RegexUtilities();

            return regexUtil.IsValidEmail(email);
        }
    }
}
