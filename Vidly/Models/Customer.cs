using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidly.Models
{
  public class Customer
  {
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    [DisplayName("Full Name")]
    public string Name { get; set; }

    [DisplayName("Subscribed to NewsLetter?")]
    public bool IsSubscribedToNewsLetter { get; set; }

    [DisplayName("Date of Birth")]
    [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Min18YearsIfAMember]
    public DateTime? BirthDate { get; set; }

    public MembershipType MembershipType { get; set; }

    [DisplayName("Membership Type")]
    public byte MembershipTypeId { get; set; }
  }
}