using Myriad.Gateway;

namespace PluralKit.Bot;

public interface IEventHandler<in T> where T : IGatewayEvent
{
    Task Handle(Shard shard, T evt);

    ulong? ErrorChannelFor(T evt) => null;
}