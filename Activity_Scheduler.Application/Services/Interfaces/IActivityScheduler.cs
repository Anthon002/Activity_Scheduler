using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Activity_Scheduler.Core.DTO;
using Activity_Scheduler.Core.ViewModels;

namespace Activity_Scheduler.Application.Services.Interfaces
{
    public interface IActivityScheduler
    {
        Task<List<ActivityViewModel>> GetActivites(string UserId);
        Task<string> CreateActivity(ActivityViewModel newActivity, System.Security.Claims.ClaimsPrincipal user);
        Task<ActivityDTO> GetActivity(string Id);
        Task<string> DeleteActivity(string Id);
        Task<string> CompleteActivity(string Id);
        Task<List<ActivityViewModel>> GetCompletedActivities();
        Task<List<ActivityViewModel>> GetExpiredActivities();
        Task<string> DeleteExpiredActivity(string Id);
        Task<string> DeleteCompletedActivity(string Id);
    }
}
