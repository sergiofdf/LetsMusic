namespace LetsMusic.Presentation.ProgramFlow
{
    public interface ISearchFlow
    {
        public void OpenSearchMenu();
        public void SearchMenu();
        public int TypeOfPersonSearch();
        public void PersonSearch(int type);
        public void CourseSearch();
        public void ClassSearch();
        public void LessonSearch();
    }
}
