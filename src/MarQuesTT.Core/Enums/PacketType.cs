namespace MarQuesTT.Core.Enums;

/// <summary>
/// Describes MQTT packet types.
/// </summary>
public enum PacketType
{
    Connect,
    ConnectAcknowledgement,
    Publish,
    PublishAcknowledgement,
    PublishRelease,
    PublishComplete,
    Subscribe,
    SubscribeAcknowledgement,
    Unsubscribe,
    UnsubscribeAcknowledgement,
    PingRequest,
    PingResponse,
    Disconnect,
    Authentication
}