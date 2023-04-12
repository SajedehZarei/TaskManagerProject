using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Damain
{
    public class BaseEntity
    {
        /// <summary>
        /// Id of data
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// date of create data
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// date of edit data
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// is data active?
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// is data deleted?
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
