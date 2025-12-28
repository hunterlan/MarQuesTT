using MarQuesTT.Core.Enums;

namespace MarQuesTT.Core.Interfaces;

/// <summary>
/// This is a base class, which contains basic information about MQTT packet and which will be inherited
/// and expanded by child classes.
/// </summary>
public interface IPacket
{
    /// <summary>
    /// Type of MQTT packet.
    /// </summary>
    PacketType Type { get; set; }
    /// <summary>
    /// Flags of MQTT packet.
    /// </summary>
    byte Flags { get; set; }
}