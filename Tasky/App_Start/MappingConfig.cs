using AutoMapper;
using Tasky.Entities;
using Tasky.Services.Common;
using Tasky.Services.Models;

namespace Tasky.App_Start
{
    public class MappingConfig
    {
        public static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // ======== Example ======== 
                // class NameValueItem { string Value, string name}
                // 
                // cfg.CreateMap<UserInfo, NameValueItem>()
                //    .ForMember(x => x.Value, o => o.MapFrom(x => x.UserId))
                //    .ForMember(x => x.Name, o => o.MapFrom(x => x.FullName));

                cfg.CreateMap<UserDetail, UserDetailsViewModel>()
                    .ForMember(x => x.FullName, o => o.MapFrom(x => x.FirstName + ' ' + x.LastName));

                cfg.CreateMap<Task, TaskViewModel>()
                    .ForMember(x => x.TaskName, o => o.MapFrom(x => x.ProjectTask.Name))
                    .ForMember(x => x.Comments, o => o.MapFrom(x => x.Description));

                cfg.CreateMap<Project, NameValueItem>()
                    .ForMember(x => x.Value, o => o.MapFrom(x => x.ProjectId));

                cfg.CreateMap<ProjectTask, NameValueItem>()
                    .ForMember(x => x.Value, o => o.MapFrom(x => x.ProjectTaskId));

                cfg.CreateMap<NewTaskModel, Task>();

            });
            App.MapperConfiguration = config;
            App.Mapper = config.CreateMapper();
        }
    }
}
