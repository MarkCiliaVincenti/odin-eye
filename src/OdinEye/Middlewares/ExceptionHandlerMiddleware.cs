namespace OdinEye.Middlewares;

using Logging;
using Models.Proto;
using System;

public class ExceptionHandlerMiddleware(ILogger logger) : EventMiddleware
{
    protected override void Invoke(GameEvent gameEvent, MiddlewareDelegate next)
    {
        try
        {
            next(gameEvent);
        }
        catch (Exception ex)
        {
            logger.LogError($"Error while handling game event: {ex.Message}");
        }
    }
}