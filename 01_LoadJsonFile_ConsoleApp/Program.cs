using _01_LoadJsonFile_ConsoleApp.Models;
using _01_LoadJsonFile_ConsoleApp.Services;
using Newtonsoft.Json;

var fileService = new FileService();
var contactList = new List<Contact>();

PopulateContactList();

while(true)
{

}







void PopulateContactList()
{
    try
    {
        var content = fileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            contactList = JsonConvert.DeserializeObject<List<Contact>>(content);
    }
    catch { }
}

