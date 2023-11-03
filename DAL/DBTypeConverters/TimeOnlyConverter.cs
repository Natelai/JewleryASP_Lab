using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.DBTypeConverters
{
    internal class TimeOnlyConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        public TimeOnlyConverter() : base(
             x => x.ToTimeSpan(),
             x => TimeOnly.FromTimeSpan(x))
        { }
    }
}