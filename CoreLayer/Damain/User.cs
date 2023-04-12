using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Damain
{
    public class User : BaseEntity
    {
        /// <summary>
        /// UserName
        /// </summary>
        public int UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Name Of User
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// family of user
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// mobile of user
        /// </summary>
        public string PhonNumber { get; set; }

        //is user's mobile config?
        public bool? IsPhonNumberConfig { get; set; }

        /// <summary>
        /// mail of user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///is user's mail config?
        /// </summary>
        public bool? IsEmailConfig { get; set; }

    }
}
