using System.ComponentModel;

namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
   public enum SensorType : short
   {
      [Description("Undefined")]
      Undefined = 0,
      
      [Description("Distance")]
      LVDT = 1,
      
      [Description("Welder Voltage")]
      Voltage = 2,
      
      [Description("Welder Current")]
      Current = 3,
      
      [Description("Upset cap side pressure")]
      UpsetCapPres = 4,
      
      [Description("Upset rod side pressure")]
      UpsetRodPres = 5,
      
      [Description("System pressure")]
      SysPres = 6
   }
}
   
