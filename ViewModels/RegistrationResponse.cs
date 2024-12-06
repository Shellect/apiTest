namespace ApiTest.ViewModels
{
    public class RegistrationResponse
    {
        public string? Token { get; set ;}
        public bool Status { get; set; }
        public Dictionary<string, string[]> ErrorList { get; set; } = [];
    }
}