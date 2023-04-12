using AutoMapper;
using CoreLayer.Damain;
using CoreLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Mapping
{
    public class CustomDtoMapper : Profile
    {
        public CustomDtoMapper()
        {
            ValueTransformers.Add<string>(value => !string.IsNullOrWhiteSpace(value) ? value.Replace('ی', 'ي').Replace('ک', 'ك') : value);

            CreateMap<SaveTaskInformationDto, TaskInformation>();
            CreateMap<DeleteTaskInformationDto, TaskInformation>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TaskInformationId));
            CreateMap<TaskInformation, GetTaskInformationResponseDto>()
                .ForMember(dest => dest.TaskInformationId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TaskStep, opt => opt.MapFrom(src => src.TaskStep.Title));

        }
    }
        }
