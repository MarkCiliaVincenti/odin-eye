namespace OdinEye.Extensions;

using Models.Proto;

public static class ZNetPeerExtensions
{
    public static Player ToPlayer(this ZNetPeer peer) =>
        new()
        {
            Id = NameBasedGuid.NewPlayerGuid(peer.m_socket.GetHostName(), peer.m_playerName),
            Name = peer.m_playerName,
            SteamId = peer.m_socket.GetHostName()
        };
}