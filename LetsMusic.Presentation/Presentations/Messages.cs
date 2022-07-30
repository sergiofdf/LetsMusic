namespace LetsMusic.Presentation.Presentations
{
    public static class Messages
    {
        public const string nameInput = "Digite o nome";
        public const string nameInputError = "Não é aceito campo vazio";
        public const string idInput = "Digite a matrícula";
        public const string idInputError = "Digite um número inteiro. Não é aceito campo vazio";
        public const string emailInput = "Digite o email";
        public const string emailInputError = "Digite um email válido";
        public const string phoneInput = "Digite o telefone";
        public const string phoneInputError = "Digite um telefone válido no formato (12) 112341234";
        public const string valueInput = "Digite o salário.";
        public const string valueInputError = "Valor inválido. Digite um valor positivo e utilize vírgula como separador decimal.";
        public const string personAlreadyExists = "\nEssa pessoa já está cadastrada.";
        public const string pressKeyContinue = "\nPressione qualquer tecla para continuar...";
        public const string personNotFound = "\nPessoa não cadastrada.";
        public const string personListEmpty = "\nAinda não existem pessoas cadastradas.";
        public const string registerSuccess = "\nRegistro realizado com sucesso!";
        public static string ScreenTaxToPay(double value)
        {
            return $"\nO valor total de impostos a pagar é de R$ {string.Format("{0:0.00}", value)}.";
        }
    }
}
