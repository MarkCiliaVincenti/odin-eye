namespace OdinEye.Middlewares;

using Http;
using Models.Proto;

public class EventDispatcherMiddleware(HttpWebServer httpWebServer) : EventMiddleware
{
    protected override void Invoke(GameEvent gameEvent, MiddlewareDelegate next) =>
        httpWebServer.BroadcastWebSocketMessage(gameEvent);
}