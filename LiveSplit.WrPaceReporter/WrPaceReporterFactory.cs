using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit
{
    public class WrPaceReporterFactory : IComponentFactory
    {
        public string ComponentName => "WrPace Reporter";

        public string Description => "Notify members of the speedrunning community when you are on pace for a world record in your category!";

        public ComponentCategory Category => ComponentCategory.Other;

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => new Version("0.0.1");

        public IComponent Create(LiveSplitState state)
        {
            return new WrPaceReporter();
        }
    }
}
