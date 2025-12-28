namespace MarQuesTT.Core.Interfaces.Clients;

public interface IClientSessionService
{
    Task SendPacketAsync(IPacket packet, CancellationToken cancellationToken = default);
}