using System;
using Tasky.Services.Helpers;

namespace Tasky.Services
{
    public interface IValidationService
    {
        bool IsEmptyValidation(string[] fields);
        bool IsEmptyValidation(string field);
        bool IsValidEmail(string email);
    }

    public class ValidationService : IValidationService
    {
        public bool IsEmptyValidation(string field)
        {
            if (field == null)
                throw new ArgumentNullException();

            return IsFieldEmpty(field);
        }

        public bool IsEmptyValidation(string[] fields)
        {
            if (fields == null)
                throw new ArgumentNullException();

            foreach (var field in fields)
            {
                if (IsFieldEmpty(field))
                    return true;
            }
            return false;
        }

        public bool IsValidEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException();

            var regexUtil = new RegexUtilities();

            return regexUtil.IsValidEmail(email);
        }

        private bool IsFieldEmpty(string field)
        {
            if (field == null)
                throw new ArgumentNullException();

            return field.Length == 0;
        }

    }
}
