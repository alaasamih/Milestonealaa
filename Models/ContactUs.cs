using Sitecore.Data;
using Sitecore.Diagnostics;
using Sitecore.WFFM.Abstractions.Actions;
using System;

namespace milestonealaa
{
    public class ContactUs : ISaveAction
    {
        public ID ActionID { get; set; }
        public string UniqueKey { get; set; }

        public ActionType ActionType { get; set; }

        public  void Execute(ID formId, AdaptedResultList adaptedFields, ActionCallContext actionCallContext = null, params object[] data)
        {
            string FirstName = adaptedFields.GetEntryByName("FirstName").Value;
            string LastName = adaptedFields.GetEntryByName("LastName").Value;
            string Message = adaptedFields.GetEntryByName("Message").Value;
            string Date = adaptedFields.GetEntryByName("Date").Value;
            string Email = adaptedFields.GetEntryByName("Email").Value;
            Log.Info("New Form has been submited", this);
        }

        public ActionState QueryState(ActionQueryContext queryContext)
        {
            return ActionState.Enabled;
        }
    }
}