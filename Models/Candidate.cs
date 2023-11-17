using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCourse.Models;

public class Candidate
{
	[Required(ErrorMessage ="Email is required.")]
	public String? Email { get; set; }= String.Empty;

    [Required(ErrorMessage = "FirstName is required.")]
    public String? FirstName { get; set; }= String.Empty;

    [Required(ErrorMessage = "LastName is required.")]
    public String? LastName { get; set; }= String.Empty;
	public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
    public int Age { get; set; }
	public String? SelectedCourse { get; set; }=string.Empty;
	public DateTime ApplyAt { get; set; }

    

}


