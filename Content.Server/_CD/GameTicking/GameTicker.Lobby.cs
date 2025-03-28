using Content.Shared.GameTicking;

namespace Content.Server.GameTicking
{
    public sealed partial class GameTicker
    {
        private CDUpdateCalendarEvent UpdateCalendar()
        {
            return new CDUpdateCalendarEvent(UniversalCalendar);
        }
    }
}
