
namespace ADO.NET
{
    public class Assessment
    {
        public int ID { get; set; }
        public string? FullName { get; set; }
        public string? GroupName { get; set; }
        public int? Average { get; set; }
        public int? AssessMin { get; set; }
        public int? AssessMax { get; set; }
        public string? SubjectMin { get; set; }
        public string? SubjectMax { get; set; }

        public Assessment(int iD, string? fullName, string? groupName, int? average, int? assessMin, int? assessMax, string? subjectMin, string? subjectMax)
        {
            ID = iD;
            FullName = fullName;
            GroupName = groupName;
            Average = average;
            AssessMin = assessMin;
            AssessMax = assessMax;
            SubjectMin = subjectMin;
            SubjectMax = subjectMax;
        }
    }
}
