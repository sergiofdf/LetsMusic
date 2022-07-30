using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;
using LetsMusic.Services;

namespace LetsMusic.Presentation.ProgramFlow
{
    public class SearchFlow : ISearchFlow
    {

        private readonly ISearchServices _searchServices;
        private readonly IRegistrationServices _registrationServices;

        public SearchFlow(ISearchServices searchServices,
            IRegistrationServices registrationServices)
        {
            _searchServices = searchServices;
            _registrationServices = registrationServices;
        }
        public void OpenSearchMenu()
        {
            SearchMenu();
        }
        public void SearchMenu()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.SearchMenu, 1, 6);
            switch (selectedMenu)
            {
                case 1:
                case 2:
                    int type = TypeOfPersonSearch();
                    if (type == 0) break;
                    PersonSearch(type);
                    break;
                case 3:
                    CourseSearch();
                    break;
                case 4:
                    ClassSearch();
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

        public int TypeOfPersonSearch()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.PersonSearchMenu, 1, 4);
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

        public void PersonSearch(int type)
        {
            if (type == 1)
            {
                //Student student = new();
                //student.Registration = Convert.ToInt32(ScreenPresenter.GetInput(Messages.idInput, InputValidations.ValidateConsoleNotEmpty, Messages.idInputError));
                //_searchServices.SearchPersonById(student.Registration);
            }
            if (type == 2)
            {
                //Student student = new();
                //student.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
                //_searchServices.SearchPersonByName(student.Name);
            }
            if (type == 3)
            {
                _searchServices.ListAllPerson();
            }
        }
        public void CourseSearch()
        {

        }
        public void ClassSearch()
        {

        }
        public void LessonSearch()
        {

        }

    }
}
