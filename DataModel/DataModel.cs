using System.Reflection;

namespace BohTracker
{
   public static partial class DataModel
   {
      public static readonly List<string> AspectNames = new List<string>();
      public static bool InitializeDataModel()
      {
         // get list of principles
         foreach (int i in Enum.GetValues(typeof(PrincipleEnum)))
         {
            var s = Enum.GetName(typeof(PrincipleEnum), i)!;
            PrincipleNames.Add(s);
         }

         PrincipleNames.Sort();

         // get list of soul element names
         foreach (int i in Enum.GetValues(typeof(SoulElementEnum)))
         {
            var s = Enum.GetName(typeof(SoulElementEnum), i)!;
            SoulElementNames.Add(s);
         }

         SoulElementNames.Sort();

         // get path to xml files
         var loc = Assembly.GetExecutingAssembly().Location;
         var dir = Path.GetDirectoryName(loc)!;
         var xmlPath = Path.Combine(dir, "Xml", "BohSys.xml");
         
         // validate file
         if (!File.Exists(xmlPath))
         {
            var msg = "XML file BohSys.xml could not be found";
            var caption = "Fatal Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         
         if (!ValidateFile(xmlPath))
         {
            var msg = "XML file BohSys.xml failed validation";
            var caption = "Fatal Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         
         DeserializeSystemParameters(xmlPath);
         if (SysElm is null)
         {
            var msg = "XML file BohSys.xml failed to load";
            var caption = "Fatal Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         
         AspectNames.AddRange(SysElm.Aspects.Aspects.ToList());
         AspectNames.Sort();
         
         return true;
      }
   }
}