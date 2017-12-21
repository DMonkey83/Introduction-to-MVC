using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
  public class CustomerFormViewModel
  {
    public IEnumerable<MembershipType> MembershipTypes { get; set; }
    public Customer Customer { get; set; }

    public string Button
    {
      get { return Customer.Id != 0 ? "Update" : "Save"; }
    }
    public string Title
    {
      get { return Customer.Id != 0 ? "Edit Customer" : "New Customer"; }
    }
  }
}