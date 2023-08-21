
using testing_can_delete;

/**
 * Combine list of comedians with their respective
 * jokes as a distinct list.
 */
var comedains = ComedianGenerator.GetComedians();
var jokes = ComedianGenerator.GetJokes();

var combined = (from c in comedains
                join j in jokes
                on c.Id equals j.ComedianId into st
                orderby c.Name
                select new
                {
                    comedian = c,
                    jokes = (from t in st
                            orderby t.PunchLine
                            group t by t.PunchLine into k
                            select k.FirstOrDefault()?.PunchLine
                            ).ToList()
                });

//Print each comedian with distict jokes
foreach (var c in combined)
{
    Console.WriteLine($"{c.comedian.Name} - {c.jokes.Count}");
    c.jokes.ForEach(pl => Console.WriteLine(pl));
}

/**
 * Determine what times are closest.
 */
var dates = (from time in DateGenerator.GetDates()
             orderby DateTime.Parse(time)
             select new DateHolder
             {
                 InitialValue = time,
                 Parsed = DateTime.Parse(time)
             })
             .OrderBy(x => x.Parsed)
             .ToList();

for (int i = 0; i < dates.Count - 1; i++)
{
    var current = dates[i];
    var next = dates[i + 1];

    current.MinutesToNextTime = next.Parsed.Subtract(current.Parsed).TotalMinutes;
}

var sortedByShortestInterval = dates
    .OrderBy(x => x.MinutesToNextTime ?? double.MaxValue)
    .Select(x => x.InitialValue)
    .ToArray();
