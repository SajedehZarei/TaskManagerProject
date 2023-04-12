using CoreLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface ITaskManagerService
    {
        /// <summary>
        /// save and edit taskInformation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<SaveTaskInformationResponseDto> SaveTaskInformation(SaveTaskInformationDto input, CancellationToken cancellationToken);

        /// <summary>
        /// show TaskInformation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GetTaskInformationResponseDto> GetTaskInformation(GetTaskInformationDto input, CancellationToken cancellationToken);

        /// <summary>
        /// show list of task in a step
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<List<GetTaskInformationResponseDto>> GetTaskInformationList(GetTaskInformationListDto input, CancellationToken cancellationToken);

        /// <summary>
        /// delete one task
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        Task<DeleteTaskInformationResponseDto> DeleteTaskInformation(DeleteTaskInformationDto input, CancellationToken cancellationToken);






    }
}
