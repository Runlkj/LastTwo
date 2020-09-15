using System.ComponentModel.DataAnnotations;

namespace LastProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}