using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace scripting_session.SwagLabs.Models
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public static List<InventoryItem> GetItemsFromJson(string fileName)
        {
            string filePath = Path.GetFullPath(@"Data\"+fileName);
            string text = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<InventoryItem[]>(text).ToList();
        }
        
    }
}