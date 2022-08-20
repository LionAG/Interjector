namespace Injector
{
    internal class Process
    {
        public static int GetID(string processMainModuleName)
        {
            Logger.LogLine($"Searching processes, looking for {processMainModuleName}");

            foreach (var p in System.Diagnostics.Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processMainModuleName)))
            {
                if (p.MainModule == null || p.MainModule.ModuleName == null)
                    continue;

                if (p.MainModule.ModuleName.Contains(processMainModuleName, StringComparison.OrdinalIgnoreCase))
                {
                    Logger.LogLine($"Process {processMainModuleName} found with id {p.Id}");
                    return p.Id;
                }
            }

            return 0;
        }
    }
}
