using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Models
{
    [Table("Students")]
    public class Student
    {
        public int Id { get; set; }

        /// <summary>
        /// Distinct Student Number
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// Directory to an image in the file system.
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Middle Name
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        public int DateOfBirth { get; set; }

        public string Sex { get; set; }

        /// <summary>
        /// The current year level of the student.
        /// </summary>
        public byte YearLevel { get; set; }

        public string EmailAddress { get; set; }

        public string ContactNumber { get; set; }

        /// <summary>
        /// Date Creation.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The creator's User ID for the created student.
        /// </summary>
        public Guid CreatedBy  { get; set; }

        /// <summary>
        /// Property to check if a student is dropped out of school.
        /// </summary>
        public bool IsDeleted { get; set; }

        public StudentAddress Address { get; set; }

    }
}