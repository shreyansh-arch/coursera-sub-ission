namespace EventEase.Services
{
    public class AttendeeService
    {
        private readonly List<string> _attendees = new();

        public IReadOnlyList<string> Attendees => _attendees;

        public void AddAttendee(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && !_attendees.Contains(name))
            {
                _attendees.Add(name);
            }
        }
    }
}
