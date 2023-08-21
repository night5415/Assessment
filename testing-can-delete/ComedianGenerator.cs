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
                new Joke(){ComedianId=1,PunchLine="My wife told me to stop impersonating a flamingo. I had to put my foot down." },
                new Joke(){ComedianId=1,PunchLine="I went to buy some camo pants but couldn’t find any." },
                new Joke(){ComedianId=1,PunchLine="I went to buy some camo pants but couldn’t find any." },

                new Joke(){ComedianId=2,PunchLine="When life gives you melons, you might be dyslexic."},
                new Joke(){ComedianId=2,PunchLine="My father has schizophrenia, but he’s good people."},
                new Joke(){ComedianId=2,PunchLine="Never trust atoms; they make up everything."},
                new Joke(){ComedianId=2,PunchLine="Never trust atoms; they make up everything."}
            };
            return jokes;
        }
    }
}