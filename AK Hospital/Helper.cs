using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Helper
{
    public static class MailHelper
    {
        public static void ValidateMail(in string mail)
        {
            try
            {
                CheckForbiddenCharacter(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            var mailComponents = mail.Split('@');

            if (mailComponents.Length != 2)
                throw new MailFormatException("Mail format is wrong. Try Again!");
        }
        private static void CheckForbiddenCharacter(in string data)
        {
            var pattern = "!#$%&*()_+-=";
            foreach (var @char in pattern)
            {
                if (data.Contains(@char.ToString()))
                    throw new MailFormatException(
                        $"Mail address can not be contains any of this characters -> {pattern}");
            }
        }

    }
    static class UserHelper
    {
        public static void CheckForbiddenCharacter(in string data)
        {
            var pattern = "1234567890-=!#$%&*()_+";
            foreach (var @char in pattern)
            {
                
                if (data.Contains(@char.ToString()))
                    throw new UserException($"Name can not be contains any of this characters -> {pattern}");
                if (data == String.Empty)
                    throw new UserException($"Surame can not  contains NO data ");

            }
        }
        public static void CheckForbiddenCharacterS(in string data)
        {
            var pattern = "1234567890-=!#$%&*()_+";
            foreach (var @char in pattern)
            {
                if (data.Contains(@char.ToString()))
                throw new UserException($"Surame can not be contains any of this characters -> {pattern}");
                if (data == String.Empty)
                    throw new UserException($"Surame can not  contains NO data ");
            }
        }

        public static void ValidateMail(in string mail)
        {
            try
            {
                CheckForbiddenCharacter(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var mailComponents = mail.Split('@');
            if (mailComponents.Length != 2)
            throw new MailFormatException("Mail format is wrong. Try Again!");
        }
    }

 
}