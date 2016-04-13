using AutoMapper;

namespace Tasky.Services.Common
{
    public class App
    {
        public static MapperConfiguration MapperConfiguration { get; set; }
        public static IMapper Mapper { get; set; }
    }
}
