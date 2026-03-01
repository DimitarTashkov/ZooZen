using System;

namespace ZooZen.Utilities
{
    /// <summary>
    /// Static text constants for ZooZen user interface
    /// </summary>
    public static class DynamicContentTranslator
    {
        public static class EntitiesTranslation
        {
            // User
            public static string Username       => "Username";
            public static string Password       => "Password";
            public static string FirstName      => "First Name";
            public static string LastName       => "Last Name";
            public static string Phone          => "Phone";
            public static string Address        => "Address";

            // Profile messages
            public static string ProfileRegistered         => "Registration successful!";
            public static string ProfileUpdatedSuccessfully => "Profile updated successfully!";
            public static string ProfileUpdateFailed        => "Update failed! Please try again.";
            public static string ProfileDeleteWarning       => "Are you sure you want to delete your account? This action is irreversible!";
            public static string ProfileDeletionSuccessful  => "Account deleted successfully!";
            public static string ProfileDeletionFailed      => "Failed to delete account!";

            // General
            public static string EmptyInputData         => "Please fill in all required fields!";
            public static string EmptyOrInvalidImage    => "Error processing the image!";
            public static string InvalidUserCredentials => "Invalid username or password!";
            public static string UsernameExists         => "This username already exists!";

            // Actions
            public static string Update  => "Update";
            public static string Edit    => "Edit";
            public static string Delete  => "Delete";
            public static string Cancel  => "Cancel";
            public static string Save    => "Save";
            public static string Add     => "Add";
            public static string AddToCart  => "Add to Cart";
            public static string BuyNow  => "Buy Now";

            // Statuses
            public static string Confirmation   => "Confirmation";
            public static string Error          => "Error";
            public static string Success        => "Success";
            public static string DeletionSuccessful => "Deletion successful.";
            public static string DeletionFailed     => "Deletion failed.";
            public static string EditSucceeded      => "Updated successfully.";

            // Products and cart
            public static string ItemName        => "Name:";
            public static string ItemDescription => "Description:";
            public static string ItemPrice       => "Price:";
            public static string ItemCategory    => "Category:";
            public static string ItemStock       => "Stock:";
            public static string CartEmpty       => "The cart is empty!";
            public static string OrderPlaced     => "Order placed successfully!";
            public static string InsufficientStock => "Insufficient stock!";

            // Orders
            public static string CustomerName    => "Customer Name:";
            public static string CustomerPhone   => "Phone:";
            public static string CustomerAddress => "Delivery Address:";
            public static string PromoCode       => "Promo Code:";
            public static string TotalPrice      => "Total:";

            // Validation
            public static string FieldLength => "{0} must be at least {1} characters";

            // Navigation
            public static string Catalog       => "Catalog";
            public static string Promotions    => "Promotions & Services";
            public static string Cart          => "Cart";
            public static string MyProfile     => "My Profile";
            public static string Admin         => "Administration";
        }
    }
}
