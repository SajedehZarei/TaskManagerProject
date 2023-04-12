using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dto
{
    public class DeleteTaskInformationDto
    {
        /// <summary>
        /// id of task
        /// </summary>
        public int TaskInformationId { get; set; }
    }

    public class DeleteTaskInformationResponseDto
    {
        /// <summary>
        /// id of task
        /// </summary>
        public int TaskInformationId { get; set; }
    }
}
