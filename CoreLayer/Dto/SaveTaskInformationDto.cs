using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dto
{
    public class SaveTaskInformationDto
    {
        /// <summary>
        /// id of task
        /// </summary>
        public int TaskInformationId { get; set; }

        /// <summary>
        /// title of task
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// category of task
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// stepId of task
        /// </summary>
        public int TaskStepId { get; set; }

        /// <summary>
        /// user who created task
        /// </summary>
        public int UserId { get; set; }

    }
    public class SaveTaskInformationResponseDto
    {
        /// <summary>
        /// id of task
        /// </summary>
        public int TaskInformationId { get; set; }
    }
}
