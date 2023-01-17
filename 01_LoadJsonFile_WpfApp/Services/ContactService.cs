using _01_LoadJsonFile_WpfApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LoadJsonFile_WpfApp.Services
{
    public class ContactService
    {
        private readonly FileService fileService = new FileService();
        private ObservableCollection<Contact> contactList = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> PopulateContactList()
        {
            try
            {
                var content = fileService.ReadFromFile();
                if (!string.IsNullOrEmpty(content))
                    contactList = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(content)!;
            }
            catch { }

            return contactList;
        }

        public void AddToList(Contact contact)
        {
            contactList.Add(contact);   
            fileService.WriteToFile(JsonConvert.SerializeObject(contactList));
        }

        public void RemoveFromList(Contact contact)
        {
            contactList.Remove(contact);
            fileService.WriteToFile(JsonConvert.SerializeObject(contactList));
        }
    }
}
