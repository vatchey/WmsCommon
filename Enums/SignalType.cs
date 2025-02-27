using System.ComponentModel;

namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
	public enum SignalType : sbyte // short
	{
		[Description("Undefined")]
		Undefined = 0,
		[Description("-10 to +10 vdc")]
		V_10 = 1,
		[Description("0 to 10 vdc")]
		V_0_10 = 2,
		[Description("0 to 20 mA")]
		MA_0_20 = 3,
		[Description("4 to 20 mA")]
		MA_4_20 = 4
	}
}
