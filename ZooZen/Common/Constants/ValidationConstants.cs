using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZen.Common.Constants
{
    public static class ValidationConstants
    {
        public static class ProductConstants
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;
            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 3;
        }

        public static class UserConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 3;
            public const int PasswordMaxLength = 50;
            public const int PasswordMinLength = 5;
            public const int PhoneMaxLength = 20;
            public const int AddressMaxLength = 200;
        }

        public static class InputConstants
        {
            public const string DialogFilter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| All files(*.*)|*.*";
        }

        public static class OrderConstants
        {
            public const int CustomerNameMaxLength = 100;
            public const int CustomerPhoneMaxLength = 20;
            public const int CustomerAddressMaxLength = 200;
        }
    }
}
