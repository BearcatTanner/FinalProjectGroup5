using System.ComponentModel.DataAnnotations;

namespace FinalProjectGroup5.Models
{
    public class GroupMembers
    {
        [Key] public int Member { get; set; }
        public DateTime Birthdate { get; set; }
        public string Program { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }

        public GroupMembers() { }

        public GroupMembers(int member, DateTime birthdate, string program, string year, string name)
        {
            Member = member;
            Birthdate = birthdate;
            Program = program;
            Year = year;
            Name = name;
        }
    }
}
