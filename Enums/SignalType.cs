namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
   public enum SignalType : short
   {
      Undefined = 0,
   	V_10 = 1, // -10 to +10
	   V_0_10 = 2,
	   MA_0_20 = 3,
	   MA_4_20 = 4
   }
}
