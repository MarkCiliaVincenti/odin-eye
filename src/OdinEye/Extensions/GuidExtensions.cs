namespace OdinEye.Extensions;

using DeterministicGuids;
using System;

public static class NameBasedGuid
{
    private static readonly Guid NamespaceId = new("4b01a09a-9b18-493c-9877-4786611eeea2");

    public static Guid NewPlayerGuid(string steamId, string playerName) => DeterministicGuid.Create(NamespaceId, steamId + playerName);
}