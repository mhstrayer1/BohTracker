using System.Xml.Schema;
using BohDataModel;
using LiquidTechnologies.XmlObjects;
using BohDataModel.Ns;

namespace BohTracker
{
   public static partial class DataModel
   {
      static int _validationErrors;
      static readonly XmlDataModelValidator Validator = new XmlDataModelValidator();

      public static BohSysElm? SysElm = null;
      public static bool ValidateFile(string xmlPath)
      {
         _validationErrors = 0;
         Validator.Validate(xmlPath, ValidationEventHandler!);
         return _validationErrors == 0;
      }
      
      public static void DeserializeSystemParameters(string xmlPath)
      {
         var serializer = new LxSerializer<BohSysElm>();
         using TextReader textReader = new StreamReader(xmlPath);
         var readerSettings = new LxReaderSettings { ErrorHandler = XmlReader_ErrorHandler! };
         SysElm = serializer.Deserialize(textReader, readerSettings);
      }

      static void ValidationEventHandler(object sender, ValidationEventArgs e)
      {
         Console.WriteLine($@"XML Validation Error :{e.Severity}:{e.Message}");
         _validationErrors++;
      }

      static void XmlReader_ErrorHandler
         (
            string msg,
            LxErrorSeverity severity,
            LxErrorCode errorCode,
            TextLocation location,
            object targetObject
         )
      {
         Console.WriteLine($@"XML Reader Error : {severity}:{errorCode}:{location} {msg}");

         // throwing an exception will stop de-serialization
         if (severity == LxErrorSeverity.Error)
            throw new LxSerializationException(msg, severity, errorCode, location, targetObject);
      }
   }
}