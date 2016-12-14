namespace DynamicPartialLoad.Models
{
    public class MyModelAllInOne
    {
        public string Header { get; set; }

        public PageContent IndexMainContent { get; set; }

        public PageContent InfoMainContent { get; set; }

        public PageContent ContactMainContent { get; set; }

        public string Footer { get; set; }

        public EnumViewMode ViewMode { get; set; }
    }
}