using LetsMusic.Domain;
using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;
using LetsMusic.Services;

namespace LetsMusic.Presentation.ProgramFlow
{
    public class RegistrationFlow : IRegistrationFlow
    {
        private readonly IRegistrationServices _registrationServices;

        public RegistrationFlow(IRegistrationServices registrationServices)
        {
            _registrationServices = registrationServices;
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
                    break;
            }
        }

        public void StudentRegistration()
        {
            Student student = new();
            student.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
            student.Email = ScreenPresenter.GetInput(Messages.emailInput, InputValidations.ValidateConsoleNotEmpty, Messages.emailInputError);
            student.Phone = ScreenPresenter.GetInput(Messages.phoneInput, InputValidations.ValidateConsoleNotEmpty, Messages.phoneInputError);

            bool registrationResult = _registrationServices.StudentRegistration(student);

            if (registrationResult)
            {
                Console.WriteLine("Aluno cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro no cadastro. Verifique se o aluno já não foi cadastrado anteriormente.");
            }
        }
        public void TeacherRegistration()
        {
            Teacher teacher = new();
            teacher.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
            teacher.Salary = Convert.ToDecimal(ScreenPresenter.GetInput(Messages.valueInput, InputValidations.ValidatePositiveNumber, Messages.valueInputError));
            teacher.Email = ScreenPresenter.GetInput(Messages.emailInput, InputValidations.ValidateConsoleNotEmpty, Messages.emailInputError);
            teacher.Phone = ScreenPresenter.GetInput(Messages.phoneInput, InputValidations.ValidateConsoleNotEmpty, Messages.phoneInputError);

            bool registrationResult = _registrationServices.TeacherRegistration(teacher);
            if (registrationResult)
            {
                Console.WriteLine("Professor cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro no cadastro. Verifique se o professor já não foi cadastrado anteriormente.");
            }
        }
        public void CourseRegistration()
        {
            Course course = new();
            course.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
            course.Workload = Convert.ToInt32(ScreenPresenter.GetInput(Messages.workLoadInput, InputValidations.ValidatePositiveNumber, Messages.workLoadInputError));
            course.Vacancies = Convert.ToInt32(ScreenPresenter.GetInput(Messages.vacanciesInput, InputValidations.ValidatePositiveNumber, Messages.vacanciesInputError));

            bool registrationResult = _registrationServices.CourseRegistration(course);
            if (registrationResult)
            {
                Console.WriteLine("Curso cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro no cadastro. Verifique se o curso já não foi cadastrado anteriormente.");
            }
        }
        public void ClassRegistration()
        {
            Console.WriteLine("Em desenvolvimento...");
        }
        public void LessonRegistration()
        {
            Console.WriteLine("Em desenvolvimento...");
        }
    }
}
