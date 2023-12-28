using ConsoleApp_NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp_NET.Services;

public class CustomerService
{
    private readonly FileService _fileService = new FileService(@"D:\Projects\ConsoleAppFirst\contact.json");
    private readonly List<Contacts> _contactList = new List<Contacts>();
    public void AddContactToList(Contacts contacts)
    {
        if (!_contactList.Any(x=> x.Email == contacts.Email))
        {
            _contactList.Add(contacts);
            _fileService.SaveContentToFile(JsonConvert);
        }
    }
}
