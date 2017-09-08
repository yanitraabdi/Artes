using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    public class UserModel : GeneralModel
    {
        public UserModel()
        {
            //this.UserDependents = new List<UserDependentModel>();
        }
        public int UserId { get; set; }
        public int UserKey { get; set; }
        public string UserFullName { get; set; }
        public int LookupCodeStatus { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public string Email { get; set; }
        public int IsFirstTimeUser { get; set; }
        public string UserPassword { get; set; }
        public string UserDefaultPassword { get; set; }
        public string Salt { get; set; }
        public int? TotalFailedAttempt { get; set; }
        public DateTime? LastFailedAttempt { get; set; }
        public DateTime? LastSuccessAttempt { get; set; }
        public string UserPasswordEncryted { get; set; }
        public string Photo { get; set; }
        public string UserType { get; set; }
    }
}
