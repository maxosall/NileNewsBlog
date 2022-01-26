using System.ComponentModel.DataAnnotations;

namespace Nile.lib
{
    public class Job
    {
        public string JobTitle { get; set; }
        [Display(Name = "Job Description")]
        public string Dscription { get; set; }
        [Display(Name = "Busness Name")]
        [MaxLength(500, ErrorMessage = "you have reached the maximun char limit(500 char) ")]
        public string BusnessName { get; set; }

        [Display(Name = "Maximum Salary ")]
        public double MaxSalary { get; set; }
        [Display(Name = "Minimum Salary ")]
        public double MinSalary { get; set; }
        [Display(Name = "Work Loation ")]
        public string WorkLoation { get; set; }
        public DateTime DatePosted { get; set; }
        [Display(Name = "Is Still Open For Application?")]
        public bool IsOpenForApplications { get; set; }
        public SalaryType SalaryType { get; set; } = new SalaryType();
        public JobType JobType { get; set; }
    }
    public class JobCalegory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
    public enum SalaryType
    {
        [Display(Name = "Per Hour")]
        PerHour,
        [Display(Name = "Per Day")]
        PerDay,
        [Display(Name = "Per Week")]
        PerWeek,
        [Display(Name = "Per Tow Weeks")]
        PerTowWeeks,
        [Display(Name = "Per Month")]
        PerMonth,
        [Display(Name = "Per Year")]
        PerYear,
        [Display(Name = "One Time")]
        OneTime
    }
    public enum JobType
    {
        [Display(Name = "Full Time")]
        FullTime,
        [Display(Name = "Part Time")]
        PartTime,
        Internship,
        Volunterr,
        Contract
    }
}