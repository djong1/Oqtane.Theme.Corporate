using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Module.Corporate.AboutUs
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Corporate Theme - About Us",
            Description = "Add an About Us section to your Corporate Theme",
            Version = "6.0.1",
            PackageName = "Oqtane.Theme.Corporate"
        };
    }
}
