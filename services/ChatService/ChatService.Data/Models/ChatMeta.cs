namespace DefaultNamespace;

public class ChatMeta
{
    public Guid Id { get; set; }
    public Guid UserId? { get; set; }
    public SessionTypeEnum SessionType { get; set; }
    public DateTime TimeStamp { get; set; }
}