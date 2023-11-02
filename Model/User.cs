using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointr.Model
{
    class User
    {
        public int UserId { get; set; }
        public string Username { get; }
        public string Password { get; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public static string CurrentUsername { get; set; }
        public static int CurrentUserId { get; set; }

        public DateTime BusinessOpen = DateTime.Parse(new TimeSpan(7, 0, 0).ToString());

        public DateTime BusinessClose = DateTime.Parse(new TimeSpan(19, 0, 0).ToString());

        public User() : this(0, string.Empty, string.Empty, DateTime.Now, String.Empty, DateTime.Now, String.Empty) { }

        public User(int userId, string userName, string password, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            UserId = userId;
            Username = userName;
            Password = password;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
            
        }

    }
}
