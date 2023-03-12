namespace Destiny2ManagerMVC.Models
{
    public class BungieUserMembershipsModel
    {
        public BungieUserMembershipsResponse Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }

    public class BungieUserMembershipsResponse
    {
        public List<DestinyMembership> destinyMemberships { get; set; }
        public string primaryMembershipId { get; set; }
        public BungieNetUser bungieNetUser { get; set; }
    }

    public class DestinyMembership
    {
        public string LastSeenDisplayName { get; set; }
        public int LastSeenDisplayNameType { get; set; }
        public string iconPath { get; set; }
        public int crossSaveOverride { get; set; }
        public List<int> applicableMembershipTypes { get; set; }
        public bool isPublic { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
        public string bungieGlobalDisplayName { get; set; }
        public int bungieGlobalDisplayNameCode { get; set; }
    }
}
