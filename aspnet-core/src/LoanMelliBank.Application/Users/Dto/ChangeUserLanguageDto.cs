using System.ComponentModel.DataAnnotations;

namespace LoanMelliBank.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}