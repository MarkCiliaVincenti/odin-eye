namespace OdinEye.Middlewares;

using Logging;
using Models.Proto;

public class LoggingMiddleware(ILogger logger) : EventMiddleware
{
    protected override void Invoke(GameEvent gameEvent, MiddlewareDelegate next)
    {
        logger.LogInfo($"Handling game event: {gameEvent.Message}");
        next(gameEvent);
    }
}