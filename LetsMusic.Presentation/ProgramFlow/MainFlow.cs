using LetsMusic.Presentation.Infrastructure;
using LetsMusic.Presentation.Presentations;

namespace LetsMusic.Presentation.ProgramFlow
{
    public class MainFlow : IMainFlow
    {
        private readonly ISearchFlow _searchFlow;
        private readonly IRegistrationFlow _registrationFlow;
        public MainFlow(ISearchFlow searchFlow
            , IRegistrationFlow registrationFlow
            )
        {
            _searchFlow = searchFlow;
            _registrationFlow = registrationFlow;
        }
        public void BeginApp()
        {
            NavigateMenu();
        }
        public void NavigateMenu()
        {
            var selectedMenu = ScreenPresenter.GetOption(
                Menu.InitialMenu, 1, 4);
            switch (selectedMenu)
            {
                case 1:
                    _searchFlow.OpenSearchMenu();
                    break;
                case 2:
                    _registrationFlow.OpenRegistrationMenu();
                    break;
                //case 3:
                //    Update();
                //    break;
                case 4:
                    Quit();
                    break;
            }
            ScreenPresenter.DisplayMessage(Messages.pressKeyContinue);
            Console.ReadKey();
            BeginApp();
        }
        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
