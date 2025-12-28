namespace MarQuesTT.Core.Interfaces;

/// <summary>
/// Interface for handling MQTT packets.
/// </summary>
public interface IPacketHandler
{
    /// <summary>
    /// Handles raw data about MQTT packet.
    /// </summary>
    /// <param name="rawPacket">Raw data as byte array.</param>
    /// <returns>Specific packet, depending on realisation of child class.</returns>
    IPacket Handle(byte[] rawPacket);
}