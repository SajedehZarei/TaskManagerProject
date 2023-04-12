using CoreLayer.Dto;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace TaskManagerProject.Controllers
{
    public class TaskManagerController:Controller
    {

        private readonly ITaskManagerService _taskManagerService;

        public TaskManagerController( ITaskManagerService taskManagerService)
        {
            _taskManagerService = taskManagerService;
        }

        /// <summary>
        /// save and edit taskInformation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("SaveTaskInformation")]
        public async Task<SaveTaskInformationResponseDto> SaveTaskInformation(SaveTaskInformationDto input, CancellationToken cancellationToken)
        {
           return await _taskManagerService.SaveTaskInformation(input, cancellationToken);
        }

        /// <summary>
        /// show TaskInformation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("GetTaskInformation")]
        public async Task<GetTaskInformationResponseDto> GetTaskInformation(GetTaskInformationDto input, CancellationToken cancellationToken)
        {
            return await _taskManagerService.GetTaskInformation(input,cancellationToken);

        }

        /// <summary>
        /// show list of task in a step
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("GetTaskInformationList")]
        public async Task<List<GetTaskInformationResponseDto>> GetTaskInformationList(GetTaskInformationListDto input, CancellationToken cancellationToken)
        {
            return await _taskManagerService.GetTaskInformationList(input,cancellationToken);
        }

        /// <summary>
        /// delete one task
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpDelete("DeleteTaskInformation")]
        public async Task<DeleteTaskInformationResponseDto> DeleteTaskInformation(DeleteTaskInformationDto input, CancellationToken cancellationToken)
        {
            return await _taskManagerService.DeleteTaskInformation(input,cancellationToken);
        }
    }
}
