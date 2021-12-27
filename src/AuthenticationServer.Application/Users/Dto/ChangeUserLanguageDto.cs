using System.ComponentModel.DataAnnotations;

namespace AuthenticationServer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}