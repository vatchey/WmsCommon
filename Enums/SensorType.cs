namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
   public enum SensorType : short
   {
      Undefined = 0,
      LVDT = 1,
      Voltage = 2,
      Current = 3,
      UpsetCapPres = 4,
      UpsetRodPres = 5,
      SysPres = 6
   }
}
   
