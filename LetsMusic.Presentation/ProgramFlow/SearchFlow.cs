using LetsMusic.Domain;
using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;
using LetsMusic.Services;
using System.Data;

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
                    type = TypeOfSearch(1);
                    if (type == 0) break;
                    searchObject = "student";
                    PersonSearch(type, searchObject);
                    break;
                case 2:
                    type = TypeOfSearch(1);
                    if (type == 0) break;
                    searchObject = "teacher";
                    PersonSearch(type, searchObject);
                    break;
                case 3:
                    type = TypeOfSearch(1);
                    if (type == 0) break;
                    searchObject = "course";
                    CourseSearch(type, searchObject);
                    break;
                case 4:
                    type = TypeOfSearch(2);
                    if (type == 0) break;
                    searchObject = "class";
                    ClassSearch(type, searchObject);
                    break;
                case 5:
                    LessonSearch();
                    break;
                case 6:
                    break;
            }
        }

        public int TypeOfSearch(int menu)
        {
            int selectedMenu;
            if (menu == 1)
            {
                selectedMenu = ScreenPresenter.GetOption(
                Menu.SearchOptionMenu, 1, 4);
            }
            else
            {
                selectedMenu = ScreenPresenter.GetOption(
                Menu.SearchOptionMenu2, 1, 4);
            }
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
                person.Registration = Convert.ToInt32(ScreenPresenter.GetInput(Messages.idInput, InputValidations.ValidatePositiveNumber, Messages.idInputError));
                var searchedPerson = _searchServices.SearchById(person.Registration, searchObject);
                if (searchedPerson.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno encontrado para a matrícula digitada.");
                }
                else
                    searchedPerson.Print();
            }
            if (type == 2)
            {
                Person person = new();
                person.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
                var searchedPerson = _searchServices.SearchByName(person.Name, searchObject);
                if (searchedPerson.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno encontradao para o nome digitado.");
                }
                else
                    searchedPerson.Print();
            }
            if (type == 3)
            {
                var people = _searchServices.ListAllData(searchObject);
                people.Print();
                if (people.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno cadastrado.");
                }
            }
        }
        public void CourseSearch(int type, string searchObject)
        {
            if (type == 1)
            {
                Course course = new();
                course.CourseId = Convert.ToInt32(ScreenPresenter.GetInput(Messages.CourseIdInput, InputValidations.ValidatePositiveNumber, Messages.idInputError));
                var searchedCourse = _searchServices.SearchById(course.CourseId, searchObject);
                if (searchedCourse.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum curso encontrado para o código digitado.");
                }
                else
                    searchedCourse.Print();
            }
            if (type == 2)
            {
                Course course = new();
                course.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
                var searchedCourse = _searchServices.SearchByName(course.Name, searchObject);
                if (searchedCourse.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum curso encontrado para o nome digitado.");
                }
                else
                    searchedCourse.Print();
            }
            if (type == 3)
            {
                var courseList = _searchServices.ListAllData(searchObject);
                courseList.Print();
                if (courseList.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum curso cadastrado.");
                }
            }

        }
        public void ClassSearch(int type, string searchObject)
        {
            if (type == 1)
            {
                MusicClass musicClass = new();
                musicClass.ClassId = Convert.ToInt32(ScreenPresenter.GetInput(Messages.CourseIdInput, InputValidations.ValidatePositiveNumber, Messages.idInputError));
                var searchedClass = _searchServices.SearchById(musicClass.ClassId, searchObject);
                if (searchedClass.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhuma turma encontrada para o código digitado.");
                }
                else
                    searchedClass.Print();
            }
            if (type == 2)
            {
                MusicClass musicClass = new();
                musicClass.Year = Convert.ToInt32(ScreenPresenter.GetInput(Messages.yearInput, InputValidations.ValidatePositiveNumber, Messages.yearInputError));
                var searchedClass = _searchServices.SearchByYear(musicClass.Year);
                if (searchedClass.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhuma turma encontrada para o ano digitado.");
                }
                else
                    searchedClass.Print();
            }
            if (type == 3)
            {
                var classList = _searchServices.ListAllData(searchObject);
                classList.Print();
                if (classList.Rows.Count == 0)
                {
                    Console.WriteLine("Nenhum curso cadastrado.");
                }
            }
        }
        public void LessonSearch()
        {
            Console.WriteLine("Em desenvolvimento...");
        }

    }
}
