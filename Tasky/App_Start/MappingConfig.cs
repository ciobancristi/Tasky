using AutoMapper;
using Tasky.Services.Common;

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
                //cfg.CreateMap<UserInfo, NameValueItem>()
                //    .ForMember(x => x.Value, o => o.MapFrom(x => x.UserId))
                //    .ForMember(x => x.Name, o => o.MapFrom(x => x.FullName));

            });
            App.MapperConfiguration = config;
            App.Mapper = config.CreateMapper();
        }
    }
}
