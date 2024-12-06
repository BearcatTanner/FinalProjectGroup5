using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup5.Models
{
    public class Jobs
    {
        [Key] public int JobID { get; set; }
        public string Location { get; set; }
        public int HourlyPay { get; set; }
        public int WeeklyHours { get; set; }
        public int TravelTime { get; set; }

        public Jobs() { }

        public Jobs(int jobID, string location, int hourlyPay, int weeklyHours, int travelTime)
        {
            JobID = jobID;
            Location = location;
            HourlyPay = hourlyPay;
            WeeklyHours = weeklyHours;
            TravelTime = travelTime;
        }
    }
}
