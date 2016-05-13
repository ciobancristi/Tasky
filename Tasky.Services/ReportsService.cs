using System;
using Tasky.Services.Common;

namespace Tasky.Services
{
    public class ReportsService
    {
        private IUserService _userService;
        private ITaskService _taskService;
        private int NumberOfHoursPerWeek = 40;

        public ReportsService()
        {
            _userService = new UserService();
            _taskService = new TaskService();
        }
        public void GenerateWeeklyReports(DateTime date)
        {
            var startOfWeek = date.StartOfWeek(DayOfWeek.Monday);
            var endOfWeek = startOfWeek.AddDays(6);
            var users = _userService.GetAllUserDetails();
            foreach (var user in users)
            {
                var workedHours = _taskService.GetWorkedHoursForWeek(user.UserId, startOfWeek);
                var to = user.Email;
                var subject = "Tasky - Logging Hours Reminder";
                if (workedHours < NumberOfHoursPerWeek)
                {
                    var body =
                        "Hi " + user.FirstName + " " + user.LastName + "!<br/>"
                        + "You have " + (NumberOfHoursPerWeek - workedHours)
                        + " h <span style='color:red'>missing</span> "
                        + "from <strong>Tasky</strong> for week: "
                        + startOfWeek.ToShortDateString() + " - " + endOfWeek.ToShortDateString()
                        + ".<br/>Please log your hours in the application." + "<br/>Thank you!";
                    MailHelper.SendMail(to, subject, body);
                }
            }
        }
    }
}
