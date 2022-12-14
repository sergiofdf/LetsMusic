namespace LetsMusic.Presentation.ProgramFlow
{
    public interface ISearchFlow
    {
        public void OpenSearchMenu();
        public void SearchMenu();
        public int TypeOfSearch(int menu);
        public void PersonSearch(int type, string searchObject);
        public void CourseSearch(int type, string searchObject);
        public void ClassSearch(int type, string searchObject);
        public void LessonSearch();
    }
}
