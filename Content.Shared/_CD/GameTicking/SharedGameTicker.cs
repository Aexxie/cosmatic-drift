using Robust.Shared.Serialization;

namespace Content.Shared.GameTicking
{
    [Serializable, NetSerializable]
    public sealed class CDUpdateCalendarEvent : EntityEventArgs
    {
        public int UniversalCalendar { get; }
        public CDUpdateCalendarEvent(int calendar)
        {
            UniversalCalendar = calendar;
        }
    }
}
