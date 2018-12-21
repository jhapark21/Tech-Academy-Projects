//Added EndDate property

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ScheduleUsers.Models;

namespace ScheduleUsers.ViewModels
{
    public class UserDetailsViewModel
    {
        /// <summary>
        /// Id of user
        /// </summary>
        [Display(Name = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// First name of user.
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// First name of user.
        /// </summary>
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Last name of user.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Hire Date of user.
        /// </summary>
        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// User's End Date.
        /// </summary>
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// User's Login Name.
        /// </summary>
        [Display(Name = "Login")]
        public string LoginName { get; set; }

        /// <summary>
        /// Department of the user.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Position of the user.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// User's Birthday.
        /// </summary>
        [Display(Name = "Birthdate")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// User's Work Email.
        /// </summary>
        [Display(Name = "Work Email")]
        public string WorkEmail { get; set; }

        /// <summary>
        /// User's Alternate Email.
        /// </summary>
        [Display(Name = "Alt Email")]
        public string AlternateEmail { get; set; }

        /// <summary>
        /// User's Work Phone.
        /// </summary>
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// User's Home Phone.
        /// </summary>
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// User's Mobile Phone.
        /// </summary>
        [Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// User's address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// User's hourly wage.
        /// </summary>
        [Display(Name = "Hourly Pay")]
        public decimal HourlyPayRate { get; set; }

        /// <summary>
        /// Distinction if the user is a fulltime employee or not.
        /// </summary>
        public bool Fulltime { get; set; }

        /// <summary>
        /// User's Clocked-in Status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// User's Next Scheduled Date.
        /// </summary>
        public string NextScheduled { get; set; }

        /// <summary>
        /// User's Next Scheduled Date.
        /// </summary>
        public string CurrentRole { get; set; }

        /// <summary>
        /// Implements user details
        /// </summary>
        public UserDetailsViewModel(ApplicationUser user, string currentRole)
        {
            Id = user.Id; // this is inherited
            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            HireDate = user.HireDate;
            EndDate = user.EndDate;
            Department = user.Department;
            Position = user.Position;
            BirthDate = user.BirthDate;
            WorkEmail = user.Email; // this is inherited
            AlternateEmail = user.AlternateEmail;
            WorkPhone = user.WorkPhone;
            HomePhone = user.PhoneNumber; // this is inherited
            MobilePhone = user.MobilePhone;
            Address = user.Address;
            HourlyPayRate = user.HourlyPayRate;
            Fulltime = user.Fulltime;
            LoginName = user.UserName; // this is inherited
            Status = user.GetStatus();
            CurrentRole = currentRole;
            NextScheduled = user.Schedules.Any() ? user.Schedules.First().GetNextScheduledDay() : "N/A";
        }
        
        /// <summary>
        /// Message Count
        /// </summary>
        public bool messages { get; set; }
       
    }
}