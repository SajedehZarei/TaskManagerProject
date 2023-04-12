using AutoMapper;
using CoreLayer.Damain;
using CoreLayer.Dto;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class TaskManagerService: ITaskManagerService
    {
        private readonly TaskManagerDbContext _dbContext;
        private readonly IMapper ObjectMapper;
        public TaskManagerService(TaskManagerDbContext dbContext, IMapper objectMapper)
        {
            _dbContext = dbContext;
            ObjectMapper = objectMapper;
        }

        /// <summary>
        /// save and edit taskInformation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<SaveTaskInformationResponseDto> SaveTaskInformation(SaveTaskInformationDto input, CancellationToken cancellationToken)
        {
            var task = await _dbContext.TaskInformation.FirstOrDefaultAsync(p => p.Id == input.TaskInformationId);
            if (task is null)
            {
                var result = ObjectMapper.Map<TaskInformation>(input);
                _dbContext.TaskInformation.Add(result);
            }
            else
            {
                ObjectMapper.Map(input, task);
            }
            await _dbContext.SaveChangesAsync();
            return new SaveTaskInformationResponseDto() { TaskInformationId=task.Id};
        }

        /// <summary>
        /// show TaskInformation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetTaskInformationResponseDto> GetTaskInformation(GetTaskInformationDto input, CancellationToken cancellationToken)
        {
            var task = await _dbContext.TaskInformation.FirstOrDefaultAsync(p => p.Id == input.TaskInformationId);
            if (task is null)
            {
                // throw new Exception("NotFoundTaskInformation");
                return new GetTaskInformationResponseDto();
            }
            var result = ObjectMapper.Map<GetTaskInformationResponseDto>(task);
            return result;

        }

        /// <summary>
        /// show list of task in a step
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<List<GetTaskInformationResponseDto>> GetTaskInformationList(GetTaskInformationListDto input, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(input.Param)) input.Param = input.Param.Replace('ی', 'ي').Replace('ک', 'ك');

            var lst = _dbContext.TaskInformation.AsNoTracking()
                .Include(p=>p.TaskStep)
                .Where(p => p.IsActive == true && p.TaskStepId == input.StepTypeId 
                && p.CreateUserId == input.CreateUserId
            && (string.IsNullOrEmpty(input.Param) || p.Category.Contains(input.Param))).AsEnumerable();
            if (lst != null)
            {
                var result = await ObjectMapper.ProjectTo<GetTaskInformationResponseDto>(lst.Take(input.Take).Skip(input.skip).AsQueryable()).ToListAsync();
                return result;
            }
            return new List<GetTaskInformationResponseDto>();
        }

        /// <summary>
        /// delete one task
        /// </summary>
        /// <param name="input"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<DeleteTaskInformationResponseDto> DeleteTaskInformation(DeleteTaskInformationDto input,CancellationToken cancellationToken)
        {
            var task = await _dbContext.TaskInformation.FirstOrDefaultAsync(p => p.Id == input.TaskInformationId);
            if (task is null) throw new Exception("NotFoundTaskInformation");
            task.IsDeleted = true;
            await _dbContext.SaveChangesAsync();
            return new DeleteTaskInformationResponseDto() { TaskInformationId = input.TaskInformationId };
        }
    }
}
