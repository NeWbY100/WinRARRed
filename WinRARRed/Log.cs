using System;
using System.IO;
using Serilog;
using ReScene.Core;

namespace WinRARRed;

/// <summary>
/// Provides centralized logging functionality using Serilog with file and debug output.
/// Raises events for UI log display integration.
/// </summary>
public static class Log
{
    /// <summary>
    /// Occurs when a log message is written. Subscribe to display messages in the UI.
    /// </summary>
    public static event EventHandler<LogEventArgs>? Logged;

    private static readonly Serilog.Core.Logger Logger;

    /// <summary>
    /// The timestamp when the application started, used in log filenames.
    /// </summary>
    public static readonly DateTime StartupTime = DateTime.Now;

    static Log()
    {
        // Get the directory where the executable is located
        string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string logsDirectory = Path.Combine(exeDirectory, "logs");

        // Ensure logs directory exists
        Directory.CreateDirectory(logsDirectory);

        // Generate log filename with startup timestamp (e.g., winrarred-2026-02-02_14-30-45.log)
        string startupTimestamp = StartupTime.ToString("yyyy-MM-dd_HH-mm-ss");
        string logFileName = $"winrarred-{startupTimestamp}.log";

        // Configure Serilog
        Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(
                path: Path.Combine(logsDirectory, logFileName),
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                retainedFileCountLimit: 30)
            .CreateLogger();

        Logger.Information("=== WinRARRed Application Started ===");
    }

    public static void Write(object? sender, string text, LogTarget target = LogTarget.System)
    {
        Information(sender, text, target);
    }

    public static void Debug(object? sender, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Debug("[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[DEBUG] {message}", target));
    }

    public static void Information(object? sender, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Information("[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[INFO] {message}", target));
    }

    public static void Warning(object? sender, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Warning("[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[WARNING] {message}", target));
    }

    public static void Error(object? sender, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Error("[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[ERROR] {message}", target));
    }

    public static void Error(object? sender, Exception exception, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Error(exception, "[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[ERROR] {message}: {exception.Message}", target));
    }

    public static void Fatal(object? sender, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Fatal("[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[FATAL] {message}", target));
    }

    public static void Fatal(object? sender, Exception exception, string message, LogTarget target = LogTarget.System)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Fatal(exception, "[{Sender}] {Message}", senderName, message);
        Logged?.Invoke(sender, new LogEventArgs($"[FATAL] {message}: {exception.Message}", target));
    }

    public static void Verbose(object? sender, string message)
    {
        string senderName = sender?.GetType().Name ?? "Unknown";
        Logger.Verbose("[{Sender}] {Message}", senderName, message);
    }

    public static void CloseAndFlush()
    {
        Logger.Information("=== WinRARRed Application Shutting Down ===");
        Serilog.Log.CloseAndFlush();
    }
}

/// <summary>
/// IReSceneLogger implementation that delegates to the static Log class (Serilog).
/// </summary>
public class SerilogReSceneLogger : IReSceneLogger
{
    public void Debug(object? sender, string message, LogTarget target = LogTarget.System)
        => Log.Debug(sender, message, target);

    public void Information(object? sender, string message, LogTarget target = LogTarget.System)
        => Log.Information(sender, message, target);

    public void Warning(object? sender, string message, LogTarget target = LogTarget.System)
        => Log.Warning(sender, message, target);

    public void Error(object? sender, string message, LogTarget target = LogTarget.System)
        => Log.Error(sender, message, target);

    public void Error(object? sender, Exception exception, string message, LogTarget target = LogTarget.System)
        => Log.Error(sender, exception, message, target);

    public void Verbose(object? sender, string message)
        => Log.Verbose(sender, message);
}
