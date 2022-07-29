using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;

namespace LetsMusic.Presentation.ProgramFlow
{
    public class MainFlow
    {
        public static void BeginApp()
        {
            NavigateMenu();
        }
        public static void NavigateMenu()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.InitialMenu, 1, 4);
            switch (selectedMenu)
            {
                case 1:
                    Search();
                    break;
                case 2:
                    //Registration();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    Quit();
                    break;
            }
            ScreenPresenter.DisplayMessage(Messages.pressKeyContinue);
            Console.ReadKey();
            BeginApp();
        }

        //public void Create()
        //{
        //double value = Convert.ToDouble(ScreenPresenter.GetInput(Messages.valueInput, InputValidations.ValidatePositiveNumber, Messages.valueInputError));

        //double taxValue = _service.TaxCalculation(value);
        //ScreenPresenter.DisplayMessage(Messages.ScreenTaxToPay(taxValue));
        //return taxValue;
        //}
        public static void Update()
        {
            //Person person = new();
            //person.Name = ScreenPresenter.GetInput(Messages.nameInput, InputValidations.ValidateConsoleNotEmpty, Messages.nameInputError);
            //person.Cpf = ScreenPresenter.GetInput(Messages.cpfInput, InputValidations.ValidateConsoleNotEmpty, Messages.cpfInputError).Replace(".", "").Replace("-", "");
            //person.TotalValue = Convert.ToDouble(ScreenPresenter.GetInput(Messages.valueInput, InputValidations.ValidatePositiveNumber, Messages.valueInputError));
            //person.Tax = _service.TaxCalculation(person.TotalValue);
            //ScreenPresenter.DisplayMessage(Messages.ScreenTaxToPay(person.Tax));

            //if (!_service.RegisterTaxValue(person))
            //{
            //    ScreenPresenter.DisplayMessage(Messages.personAlreadyExists);
            //    return;
            //}
            //_service.RegisterTaxValue(person);
            //ScreenPresenter.DisplayMessage(Messages.registerSuccess);
        }
        public static void Search()
        {
            //string cpf = ScreenPresenter.GetInput(Messages.cpfInput, InputValidations.ValidateCpf, Messages.cpfInputError).Replace(".", "").Replace("-", "");
            //var personSearchedByCpf = _service.SearchTaxInfo(cpf);
            //if (personSearchedByCpf != null)
            //{
            //    ScreenPresenter.DisplayPerson(personSearchedByCpf);
            //    return;
            //}
            //ScreenPresenter.DisplayMessage(Messages.personNotFound);
        }
        public static void Quit()
        {
            Environment.Exit(0);
        }
    }
}
