﻿using System.Diagnostics;

namespace InternetMonitorApp.url
{
    public interface IUrlRetriever
    {
        string Browser { get; }

        string GetUrl(Process process);
    }
}