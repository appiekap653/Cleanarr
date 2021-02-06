﻿using Cleanerr.PluginBase.Common;

namespace Cleanerr.PluginBase
{
    public interface IPlugin
    {
        public string Name { get; }
        public string Author { get; }
        public string Description { get; }
        public string Version { get; }
        public string WebURL { get; }
        IPluginHost PluginHost { get; set; }

        public T GetConfiguration<T>() where T : PluginConfiguration;
        public void SetConfiguration<T>(T configuration) where T : PluginConfiguration;
        public void Intialize();
        public void Load();
        public void Unload();
    }
}
