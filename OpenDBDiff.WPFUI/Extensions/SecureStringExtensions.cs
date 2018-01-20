using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenDBDiff.WPFUI.Extensions
{
    // https://blogs.msdn.microsoft.com/fpintos/2009/06/12/how-to-properly-convert-securestring-to-string/
    public static class SecureStringExtensions
    {
        public static string ConvertToUnsecureString(this SecureString securePassword)
        {
            if (securePassword == null)
                throw new ArgumentNullException("securePassword");

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        public static SecureString ConvertToSecureString(this string password)
        {
            if (password == null)
                throw new ArgumentNullException("password");

#if UNSAFE
            unsafe
            {
                fixed (char* passwordChars = password)
                {
                    var securePassword = new SecureString(passwordChars, password.Length);
                    securePassword.MakeReadOnly();
                    return securePassword;
                }
            }
#else
            var securePassword = new SecureString();

            foreach (var c in password)
                securePassword.AppendChar(c);

            securePassword.MakeReadOnly();

            return securePassword;
#endif
        }
    }
}
