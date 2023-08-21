namespace testing_can_delete
{
    public class DateHolder
    {
        public double? MinutesToNextTime { get; set; }
        public DateTime Parsed { get; set; }
        public string? InitialValue { get; set; }
    }
    public static class DateGenerator
    {
        public static IEnumerable<string> GetDates()
        {
            var dates = new List<string>
                {
                    "5:00am",
                    "4:00am",
                    "12:15pm",
                    "12:00pm",
                    "6:00pm",
                    "6:30pm"
                };

            return dates;
        }
    }
}