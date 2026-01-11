using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ConnectToRevit
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class ConnectToRevit : IExternalCommand
    { 
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("ConnectToRevit", "Hello from ConnectToRevit!");
            return Result.Succeeded;
        }
    }
}
