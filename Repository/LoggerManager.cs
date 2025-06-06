﻿using NLog;

namespace DemoModel.Repository
{
    public class LoggerManager : ILoggerManager
    {
        private static readonly NLog.ILogger _logger = NLog.LogManager.GetCurrentClassLogger();
        public void LogDebug(string message) => _logger.Debug(message);
        public void LogError(string message) => _logger.Error(message);
        public void LogInfo(string message) => _logger.Info(message);
        public void LogWarn(string message) => _logger.Warn(message);
    }
}
