using Sitecore.Diagnostics;

namespace milestonealaa.Models
{
    public class ConfirmChanges
    {
        public void Process(Sitecore.Pipelines.Save.SaveArgs args)
        {
            Log.Info("Hello this me", this);
        }

    }

}


