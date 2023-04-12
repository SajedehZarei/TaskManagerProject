using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dto
{
    public class GetTaskInformationDto
    {
        /// <summary>
        /// id of task 
        /// </summary>
        public int TaskInformationId { get; set; }
       
    }

    public class GetTaskInformationResponseDto
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
        /// id of taskStep
        /// </summary>
        public int TaskStepId { get; set; }

        /// <summary>
        /// title of taskStep
        /// </summary>
        public string TaskStep { get; set; }

    }
    public class GetTaskInformationListDto
    {
        /// <summary>
        /// take of list
        /// </summary>
        public int Take { get; set; }

        /// <summary>
        /// skip of list
        /// </summary>
        public int skip { get; set; }

        /// <summary>
        /// id of step
        /// </summary>
        public int StepTypeId { get; set; }

        /// <summary>
        /// id of user who create task
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// search in category
        /// </summary>
        public string Param { get; set; }
    }
}
