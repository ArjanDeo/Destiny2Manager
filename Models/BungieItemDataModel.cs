namespace Destiny2ManagerMVC.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public Item items { get; set; }
    }

    public class Equipment
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
        public List<int> tooltipNotificationIndexes { get; set; }
        public int versionNumber { get; set; }
        public long? overrideStyleItemHash { get; set; }
    }

    public class BungieItemDataModelMessageData
    {
    }

    public class BungieItemDataModelResponse
    {
        public Equipment equipment { get; set; }
        public UninstancedItemComponents uninstancedItemComponents { get; set; }
    }

    public class BungieItemDataModel
    {
        public BungieItemDataModelResponse Response { get; set; }
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

