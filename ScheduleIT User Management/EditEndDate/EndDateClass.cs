//Changeset #469: When editing a user on the user index, editing the End Date 
//should update the database just like the Start Date

//Added property for user's End Date so editing it should
//update the database

public class RegisterViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "User Role")]
        public string UserRoles { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// User's last name.
        /// </summary>
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// New users will provide their email during registration.
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// User can select a UserName for reference.
        /// </summary>
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// User's phone number.
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        [Phone]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Desired password for a new user.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Repeated desired password for new user.
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// User's department within the company.
        /// </summary>
        [Display(Name = "Department")]
        public string Department { get; set; }

        /// <summary>
        /// User's position within the company.
        /// </summary>
        [Display(Name = "Position")]
        public string Position { get; set; }

        /// <summary>
        /// Address of the user.
        /// </summary>
        [Display(Name = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// The date the user was hired into the company.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// The date the user will end working in the company.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The date the user was hired into the company.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Wage of the user.
        /// </summary>
        [Display(Name = "Hourly Pay Rate")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", 
            ErrorMessage = "Please enter valid number with maximum 2 decimal places (example: 25.00 or 25 rather than $25).")]
        [Range(0, 9999999999999999.99)]
        public decimal HourlyPayRate { get; set; }

        /// <summary>
        /// Distinction of whether the user is a fulltime employee or parttime employee.
        /// </summary>
        [Display(Name = "Full Time")]
        public bool Fulltime { get; set; }

        /// <summary>
        /// User's Current Role
        /// </summary>
        [Display(Name = "Current Role")]
        public string CurrentRole { get; set; }
    }