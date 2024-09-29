using System.Xml.Schema;
using BohDataMoodel;
using BohDataMoodel.Ns;
using LiquidTechnologies.XmlObjects;

namespace BohTracker;

public static class DataModel
{
   private static int _validationErrors;
   private static readonly XmlDataModelValidator Validator = new();

   public static BohSysElm? SysElm;

   public static bool ValidateFile(string xmlPath)
   {
      _validationErrors = 0;
      Validator.Validate(xmlPath, ValidationEventHandler);
      return _validationErrors == 0;
   }

   public static void DeserializeSystemParameters(string xmlPath)
   {
      var serializer = new LxSerializer<BohSysElm>();
      using TextReader textReader = new StreamReader(xmlPath);
      var readerSettings = new LxReaderSettings { ErrorHandler = XmlReader_ErrorHandler };
      SysElm = serializer.Deserialize(textReader, readerSettings);
   }

   private static void ValidationEventHandler(object? sender, ValidationEventArgs e)
   {
      Console.WriteLine($@"XML Validation Error :{e.Severity}:{e.Message}");
      _validationErrors++;
   }

   private static void XmlReader_ErrorHandler
   (
      string msg,
      LxErrorSeverity severity,
      LxErrorCode errorCode,
      TextLocation? location,
      object targetObject
   )
   {
      if (location != null)
         Console.WriteLine($@"XML Reader Error : {severity}:{errorCode}:{location} {msg}");
      else
         Console.WriteLine($@"XML Reader Error : {severity}:{errorCode}:Location Unkn {msg}");

      // throwing an exception will stop de-serialization
      if (severity == LxErrorSeverity.Error)
         throw new LxSerializationException(msg, severity, errorCode, location, targetObject);
   }
}