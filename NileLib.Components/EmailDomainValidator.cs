using System.ComponentModel.DataAnnotations;

namespace NileLib.Components;

public class EmailDomainValidator : ValidationAttribute
{
    public string AllowedDomain { get; set; }
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        string[] strings = value.ToString().Split('@');
        if (strings.Length > 1 && strings[1].ToUpper() == AllowedDomain.ToUpper())
            return null;
        return new ValidationResult($"Domain must be {AllowedDomain}",
            new[] { validationContext.MemberName });
    }
}