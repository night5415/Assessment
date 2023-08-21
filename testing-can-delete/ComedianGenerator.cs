namespace testing_can_delete
{
    public class Comedian
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Joke
    {
        public int ComedianId { get; set; }
        public string? PunchLine { get; set; }
    }

    public static class ComedianGenerator
    {
        public static IEnumerable<Comedian> GetComedians()
        {
            var comedains = new List<Comedian>
                {
                    new Comedian() { Name = "Dave Chappelle", Id = 1 },
                    new Comedian() { Name = "Chris Rock", Id = 2 }
                };

            return comedains;
        }

        public static IEnumerable<Joke> GetJokes()
        {
            var jokes = new List<Joke>
            {
                new Joke(){ComedianId=1,PunchLine="yo mamma" },
                new Joke(){ComedianId=1,PunchLine="Boo Hoo" },
                new Joke(){ComedianId=1,PunchLine="Boo Hoo" },

                new Joke(){ComedianId=2,PunchLine="Knock Knock"},
                new Joke(){ComedianId=2,PunchLine="Knock Knock"},
                new Joke(){ComedianId=2,PunchLine="Who's there?"}
            };
            return jokes;
        }
    }
}