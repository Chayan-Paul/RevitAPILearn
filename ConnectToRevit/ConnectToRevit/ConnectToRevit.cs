// -----------------------------------------------------------------------------
// PaulAi Academy – Revit API Learning Series
// This code is provided for educational and learning purposes only.
// You are free to study, modify, and experiment with it.
// Revit® is a registered trademark of Autodesk, Inc.
// -----------------------------------------------------------------------------



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
