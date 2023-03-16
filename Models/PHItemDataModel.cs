namespace Destiny2ManagerMVC.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public List<Item> items { get; set; }
        public List<Loadout> loadouts { get; set; }
    }

    public class Equipment
    {
        public Data data { get; set; }
        public int privacy { get; set; }
    }

    public class Inventory
    {
        public Data data { get; set; }
        public int privacy { get; set; }
    }

    public class Item
    {
        public object itemHash { get; set; }
        public string itemInstanceId { get; set; }
        public int quantity { get; set; }
        public int bindStatus { get; set; }
        public int location { get; set; }
        public object bucketHash { get; set; }
        public int transferStatus { get; set; }
        public bool lockable { get; set; }
        public int state { get; set; }
        public int dismantlePermission { get; set; }
        public bool isWrapper { get; set; }
        public List<object> tooltipNotificationIndexes { get; set; }
        public int versionNumber { get; set; }
        public long? overrideStyleItemHash { get; set; }
        public List<object> plugItemHashes { get; set; }
    }

    public class Loadout
    {
        public object colorHash { get; set; }
        public int iconHash { get; set; }
        public object nameHash { get; set; }
        public List<Item> items { get; set; }
        public Data data { get; set; }
        public int privacy { get; set; }
    }

    public class PHItemDataModelMessageData
    {
    }

    public class PHItemDataModelResponse
    {
        public Inventory inventory { get; set; }
        public Equipment equipment { get; set; }
        public Loadout loadouts { get; set; }
        public UninstancedItemComponents uninstancedItemComponents { get; set; }
    }

    public class PHItemDataModel
    {
        public Response Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }

    public class UninstancedItemComponents
    {
    }




}
