namespace DZDFreeTim.Web.Mvc.Models
{
    public class ResourceViewModel
    {
        public double ProjectBonus { get; set; }
        public double ITSMBonus { get; set; }
        public double TotalBonus { get; set; }
        public int OpenProjects { get; set; }
        public int OpenITSMs { get; set; }
        public int OpenAll { get; set; }
        public List<ProjectDetailModel> Projects { get; set; }
        public int[] ProjectQuarters { get; set; }
        public int[] ITSMQuarters { get; set; }
        public List<ITSMDetailModel> ITSMs { get; set; }
        public string Name { get; set;}

    }
}
