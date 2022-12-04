﻿namespace SICore.Clients.Viewer;

/// <summary>
/// Downloads files in background and allows to access to them after download.
/// </summary>
internal interface ILocalFileManager : IDisposable
{
    void Start(CancellationToken token);

    bool AddFile(Uri mediaUri, Action<Exception> errorCallback);

    string? TryGetFile(Uri mediaUri);
}
