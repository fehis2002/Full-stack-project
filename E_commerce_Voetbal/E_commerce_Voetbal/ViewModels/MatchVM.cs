using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace E_commerce_Voetbal.ViewModels
{
    public class MatchVM
    {
        [Display(Name = "Home")]
        public string? HomeTeam { get; set; }
        public string? HomeTeamLogo { get; set; }
        [Display(Name = "Visitor")]
        public string? AwayTeam {  get; set; }
        public string? AwayTeamLogo { get; set; }
        public string? Stadium { get; set; }
        public DateTime Date {  get; set; }
        public TimeSpan Time { get; set; }

    }
}
