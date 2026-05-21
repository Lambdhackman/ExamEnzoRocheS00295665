using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEnzoRocheS00295665
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string MembershipType { get; set; }
        public virtual List<TrainingSession> TrainingSessions { get; set; }

    }
    public class TrainingSession
    {
        public int SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public int DurationMinutes { get; set; }
        public string CoachNotes { get; set; }
        public virtual Member TrainedMember { get; set; }
        public int TrainedMemberId { get; set; }


    }
    public class MemberData : DbContext
    {
        public MemberData() : base("MyMemberData") { }
        public DbSet<Member> Members { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }

    }
}
