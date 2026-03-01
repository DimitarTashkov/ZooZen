using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooZen.Common.Messages
{
    /// <summary>
    /// Error messages for ZooZen
    /// </summary>
    public static class ErrorMessages
    {
        public static class UserMessages
        {
            public const string UsernameIsRequired = "Username is required!";
            public const string PasswordIsRequired = "Password is required!";
            public const string FirstNameIsRequired = "First name is required!";
            public const string LastNameIsRequired = "Last name is required!";
            public const string InvalidUserCredentials = "Invalid username or password!";
            public const string UsernameExists = "This username already exists!";
        }

        public static class ProductMessages
        {
            public const string ProductNameIsRequired = "Product name is required!";
            public const string ProductDescriptionIsRequired = "Product description is required!";
            public const string ProductCategoryIsRequired = "Product category is required!";
            public const string InvalidPrice = "Please enter a valid price!";
            public const string InvalidStock = "Please enter a valid stock quantity!";
        }

        public static class OrderMessages
        {
            public const string CustomerNameIsRequired = "Customer name is required!";
            public const string CustomerPhoneIsRequired = "Phone number is required!";
            public const string CustomerAddressIsRequired = "Address is required!";
            public const string EmptyCart = "The cart is empty!";
            public const string InsufficientStock = "Insufficient stock for this product!";
        }
    }
}
