using LetsMusic.Domain;
using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;
using LetsMusic.Services;

namespace LetsMusic.Presentation.ProgramFlow
{
    public class RegistrationFlow : IRegistrationFlow
    {
        private readonly IRegistrationServices _teacherServices;

        public RegistrationFlow(IRegistrationServices teacherServices)
        {
            _teacherServices = teacherServices;
        }
        public void OpenRegistrationMenu()
        {
            RegistrationMenu();
        }
        public void RegistrationMenu()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.RegistrationMenu, 1, 6);
            switch (selectedMenu)
            {
                case 1:
                    StudentRegistration();
                    break;
                case 2:
                    TeacherRegistration();
                    break;
                case 3:
                    CourseRegistration();
                    break;
                case 4:
                    ClassRegistration();
                    break;
                case 5:
                    LessonRegistration();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            ScreenPresenter.DisplayMessage(Messages.pressKeyContinue);
            Console.ReadKey();
            OpenRegistrationMenu();
        }

        public void StudentRegistration()
        {

        }
        public void TeacherRegistration()
        {
            Teacher teacher = new();
            teacher.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
            teacher.Salary = Convert.ToDecimal(ScreenPresenter.GetInput(Messages.valueInput, InputValidations.ValidatePositiveNumber, Messages.valueInputError));
            teacher.Email = ScreenPresenter.GetInput(Messages.emailInput, InputValidations.ValidateConsoleNotEmpty, Messages.emailInputError);
            teacher.Phone = ScreenPresenter.GetInput(Messages.phoneInput, InputValidations.ValidateConsoleNotEmpty, Messages.phoneInputError);

            bool registrationResult = _teacherServices.TeacherRegistration(teacher);
            ScreenPresenter.DisplayMessage(Messages.pressKeyContinue);
            Console.ReadKey();

        }
        public void CourseRegistration()
        {

        }
        public void ClassRegistration()
        {

        }
        public void LessonRegistration()
        {

        }
    }
}
