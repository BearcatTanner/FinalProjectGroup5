namespace FinalProjectGroup5.Models
{
    public class Hobby
    {
        public int HobbyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly StartDate { get; set; }
        public int HoursPerWeek { get; set; }
        public string PreferredPlatform { get; set; }


        public Hobby() { }

        public Hobby(int hobbyId, string name, string description, DateOnly startDate, int hoursPerWeek, string preferredPlatform)
        {
            HobbyId = hobbyId;
            Name = name;
            Description = description;
            StartDate = startDate;
            HoursPerWeek = hoursPerWeek;
            PreferredPlatform = preferredPlatform;
        }
    }
}

    

