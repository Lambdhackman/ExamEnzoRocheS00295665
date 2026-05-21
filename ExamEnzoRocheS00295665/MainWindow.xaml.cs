using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamEnzoRocheS00295665
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Member m1 = new Member() { MemberId = 1, FirstName = "Kelly", SurName = "Niamh", ContactNumber = "087 333 4455", DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), MembershipType = "Senior", TrainingSessions=new List<TrainingSession>() };
            Member m2 = new Member() { MemberId = 2, FirstName = "Stan", SurName = "Edgar", ContactNumber = "099 999 9999", DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), MembershipType = "Adult", TrainingSessions = new List<TrainingSession>() };
            Member m3 = new Member() { MemberId = 3, FirstName = "Billie", SurName = "Butcher", ContactNumber = "034 567 8910", DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), MembershipType = "Teen", TrainingSessions = new List<TrainingSession>() };
            Member m4 = new Member() { MemberId = 4, FirstName = "Zinedine", SurName = "Zidane", ContactNumber = "065 808 1998", DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), MembershipType = "Pro", TrainingSessions = new List<TrainingSession>() };

            TrainingSession ts1 = new TrainingSession() { SessionId=1, SessionType="Strength", SessionDate= new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), DurationMinutes=60, TrainedMember=m1, TrainedMemberId=1, CoachNotes="Great improvement" };
            TrainingSession ts2 = new TrainingSession() { SessionId = 2, SessionType = "Velocity", SessionDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), DurationMinutes = 30, TrainedMember = m1, TrainedMemberId = 1, CoachNotes = "Great improvement" };
            TrainingSession ts3 = new TrainingSession() { SessionId = 3, SessionType = "Abs", SessionDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), DurationMinutes = 120, TrainedMember = m2, TrainedMemberId = 2, CoachNotes = "Great improvement" };
            TrainingSession ts4 = new TrainingSession() { SessionId = 4, SessionType = "Strength", SessionDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), DurationMinutes = 60, TrainedMember = m3, TrainedMemberId = 3, CoachNotes = "Great improvement" };
            TrainingSession ts5 = new TrainingSession() { SessionId = 5, SessionType = "CrowBar", SessionDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), DurationMinutes = 10, TrainedMember = m4, TrainedMemberId = 4, CoachNotes = "Meh..." };
            
            m1.TrainingSessions.Add(ts1);
            m1.TrainingSessions.Add(ts2);
            m2.TrainingSessions.Add(ts3);
            m3.TrainingSessions.Add(ts4);
            m4.TrainingSessions.Add(ts5);

            List<Member> Members = new List<Member>();
            Members.Add(m1);
            Members.Add(m2);
            Members.Add(m3);
            Members.Add(m4);
            MemberList.ItemsSource = from mnm in Members 
                                     orderby mnm.FirstName
                                     select mnm;
        }

        private void MemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member member = MemberList.SelectedItem as Member;
            if (member == null) { }
            else 
            {
                ShowDtl.Text = "ID:" + member.MemberId + "     First Name: " + member.FirstName + "     Last Name: " + member.SurName + "\nContact Number" + member.ContactNumber + "     Membership Type: " + member.MembershipType + "     DOB: " + member.DateOfBirth;
                TrainingList.ItemsSource= member.TrainingSessions;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Show();
            Member member = MemberList.SelectedItem as Member;
            if (member == null) { return; }
            TrainingSession ts1 = new TrainingSession() { SessionId = 1, SessionType = "bfhslf", SessionDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), DurationMinutes = 60, TrainedMember=member, TrainedMemberId = member.MemberId, CoachNotes = "Great improvement" };
            member.TrainingSessions.Add(ts1);
        }
    }
}