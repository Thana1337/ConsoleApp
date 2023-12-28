using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET.Models;

public interface IContacts
{
    string Address { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string PhoneNumber { get; set; }
}

public class Contacts : IContacts
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
}
