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

                cfg.CreateMap<UserDetail, UserDetailViewModel>()
                    .ForMember(x => x.FullName, o => o.MapFrom(x => x.FirstName + ' ' + x.LastName));

                cfg.CreateMap<Task, TaskViewModel>();


            });
            App.MapperConfiguration = config;
            App.Mapper = config.CreateMapper();
        }
    }
}
