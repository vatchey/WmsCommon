using System.ComponentModel;

namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
   public enum SensorType : sbyte // short
   {
      [Description("Undefined")]
      Undefined = 0,
      
      [Description("Distance")]
      LVDT,
      
      [Description("Welder Voltage")]
      WelderVolt,
      
      [Description("Welder Current")]
      WelderCurrent,
      
      [Description("Upset cap side pressure")]
      UpsetCapPres = 4,
      
      [Description("Upset rod side pressure")]
      UpsetRodPres,
      
      [Description("System pressure")]
      SysPres
   }
}
   
