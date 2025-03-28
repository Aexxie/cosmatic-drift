using System.Linq;
using Content.Shared._CD.Calendar;
using Content.Shared._CD.CCVars;
using Robust.Shared.Configuration;

namespace Content.Client._CD.Calendar;

public sealed class CalendarSystem : SharedCalendarSystem
{
    private string _year = Loc.GetString("cd-calendar-year");
    private string _month = Loc.GetString("cd-calendar-month");
    private string _day = Loc.GetString("cd-calendar-day");

    public string FormatDate(int daysInYear, int daysInMonth, int daysInWeek, int days)
    {
        var dayOfWeek = days % daysInWeek;
        var years = days / daysInYear;
        var months = (days -= years * daysInYear) / daysInMonth;
        days -= months * daysInMonth;

        var isTeen = days / 10 % 10 == 1;
        var lastDigit = days % 10;

        var suffix = isTeen ? Loc.GetString($"cd-numbersuffix-0") : Loc.GetString($"cd-numbersuffix-{days % 10}");

        var month = Loc.GetString($"cd-calendar-month-{months}");
        var day = Loc.GetString($"cd-calendar-day-{dayOfWeek}");

        var universalDate = Loc.GetString(
            "cd-calendar-date-format",
            ("dayName", day),
            ("monthName", month),
            ("day", days),
            ("suffix", suffix),
            ("year", years)
        );

        return universalDate;
    }
}
