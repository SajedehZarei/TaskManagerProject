using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Damain
{
    /// <summary>
    /// the information of task
    /// </summary>
    public class TaskInformation : BaseEntity
    {
        /// <summary>
        /// title of task
        /// </summary>
        public int Title { get; set; }

        /// <summary>
        /// category of task
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// the step of task
        /// </summary>
        public int TaskStepId { get; set; }
        public virtual StepType TaskStep { get; set; }

        /// <summary>
        /// the user who create task
        /// </summary>
        public int CreateUserId { get; set; }
        public virtual User CreateUser { get; set; }

    }
}
