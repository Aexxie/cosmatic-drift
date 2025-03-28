using System.Linq;
using System.Threading.Tasks;
using Content.Shared.GameTicking;

namespace Content.Server.GameTicking;

public sealed partial class GameTicker
{
    private void ModifyCalendar(int mod = 1, bool set = false)
    {
        var task = Task.Run(async () =>
        {
            var server = await _dbEntryManager.ServerEntity;
            return await _db.AccessUniversalCalendar(server.Id, mod, set) ?? 0;
        });

        _taskManager.BlockWaitOnTask(task);
        UniversalCalendar = task.GetAwaiter().GetResult();

        var cdStartingEvent = new CDUpdateCalendarEvent(UniversalCalendar);
        RaiseNetworkEvent(cdStartingEvent);
        RaiseLocalEvent(cdStartingEvent);
    }
}
