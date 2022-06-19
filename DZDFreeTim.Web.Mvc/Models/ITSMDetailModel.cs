namespace DZDFreeTim.Web.Mvc.Models
{
    public class ITSMDetailModel
    {
        public int IssueId { get; set; }
        public string IssueName { get; set; }
        public string IssueTypeName { get; set; }
        public string CompanyName { get; set; }
        public string Summary { get; set; }
        public string AssigneeMail { get; set; }
        public string ReporterName { get; set; }
        public string ResolutionName { get; set; }
        public int Priority { get; set; }
        public string Created { get; set; }
        public string Resolved { get; set; }
        public string StatusName { get; set; }
    }
}
