using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string InvalidProductName = "Invalide prudct name";
        public static string ProductAdded = "Product is added";
        public static string ProductsListed = "The products are listed";
        public static string MaintenanceTime = "System is under maintenance";
        public static string UnitPraceInvalid;
        public static string ProductCountOfCategoryError = "Max 10 categories" ;
        public static string ProductNameAlreadyExists = "Prduct name is already exists";
        public static string CategoryLimitExceded = "Category limit is exceded";
        public static string AuthorizationDenied = "Authorization is Denied";
        public static  string UserRegistered = "The user is registered";
        public static string UserNotFound = "The user is not found";
        public static string PasswordError = "The password is not correct";
        public static string SuccessfulLogin = "Login is successful";
        public static string UserAlreadyExists = "The user is already exists";
        public static string AccessTokenCreated = "The access token is created";
    }
}
