using LetsMusic.Domain;
using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;
using LetsMusic.Services;

namespace LetsMusic.Presentation.ProgramFlow
{
    public class SearchFlow : ISearchFlow
    {

        private readonly ISearchServices _searchServices;

        public SearchFlow(ISearchServices searchServices)
        {
            _searchServices = searchServices;
        }
        public void OpenSearchMenu()
        {
            SearchMenu();
        }
        public void SearchMenu()
        {
            int type;
            string searchObject;
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.SearchMenu, 1, 6);
            switch (selectedMenu)
            {
                case 1:
                    type = TypeOfSearch1();
                    if (type == 0) break;
                    searchObject = "student";
                    PersonSearch(type, searchObject);
                    break;
                case 2:
                    type = TypeOfSearch1();
                    if (type == 0) break;
                    searchObject = "teacher";
                    PersonSearch(type, searchObject);
                    break;
                case 3:
                    type = TypeOfSearch1();
                    if (type == 0) break;
                    searchObject = "course";
                    CourseSearch(type, searchObject);
                    break;
                case 4:
                    type = TypeOfSearch2();
                    if (type == 0) break;
                    searchObject = "class";
                    ClassSearch(type, searchObject);
                    break;
                case 5:
                    LessonSearch();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            ScreenPresenter.DisplayMessage(Messages.pressKeyContinue);
            Console.ReadKey();
            OpenSearchMenu();
        }

        public int TypeOfSearch1()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.SearchOptionMenu, 1, 4);
            switch (selectedMenu)
            {
                case 1:
                    return 1;
                    break;
                case 2:
                    return 2;
                    break;
                case 3:
                    return 3;
                    break;
                case 4:
                    return 0;
                    break;
            }
            return 0;
        }
        public int TypeOfSearch2()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.SearchOptionMenu2, 1, 4);
            switch (selectedMenu)
            {
                case 1:
                    return 1;
                    break;
                case 2:
                    return 2;
                    break;
                case 3:
                    return 3;
                    break;
                case 4:
                    return 0;
                    break;
            }
            return 0;
        }
        public void PersonSearch(int type, string searchObject)
        {
            if (type == 1)
            {
                Person person = new();
                person.Registration = Convert.ToInt32(ScreenPresenter.GetInput(Messages.idInput, InputValidations.ValidateConsoleNotEmpty, Messages.idInputError));
                _searchServices.SearchById(person.Registration, searchObject);
            }
            if (type == 2)
            {
                Person person = new();
                person.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
                _searchServices.SearchByName(person.Name, searchObject);
            }
            if (type == 3)
            {
                _searchServices.ListAllData(searchObject);
            }
        }
        public void CourseSearch(int type, string searchObject)
        {
            if (type == 1)
            {
                Course course = new();
                course.CourseId = Convert.ToInt32(ScreenPresenter.GetInput(Messages.CourseIdInput, InputValidations.ValidateConsoleNotEmpty, Messages.idInputError));
                _searchServices.SearchById(course.CourseId, searchObject);
            }
            if (type == 2)
            {
                Course course = new();
                course.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
                _searchServices.SearchByName(course.Name, searchObject);
            }
            if (type == 3)
            {
                _searchServices.ListAllData(searchObject);
            }

        }
        public void ClassSearch(int type, string searchObject)
        {
            if (type == 1)
            {
                MusicClass musicClass = new();
                musicClass.ClassId = Convert.ToInt32(ScreenPresenter.GetInput(Messages.CourseIdInput, InputValidations.ValidateConsoleNotEmpty, Messages.idInputError));
                _searchServices.SearchById(musicClass.ClassId, searchObject);
            }
            if (type == 2)
            {
                MusicClass musicClass = new();
                musicClass.Year = Convert.ToInt32(ScreenPresenter.GetInput(Messages.yearInput, InputValidations.ValidateConsoleNotEmpty, Messages.yearInputError));
                _searchServices.SearchByYear(musicClass.Year, searchObject);
            }
            if (type == 3)
            {
                _searchServices.ListAllData(searchObject);
            }
        }
        public void LessonSearch()
        {
            Console.WriteLine("Em desenvolvimento...");
        }

    }
}
