using System.ComponentModel;

namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
	public enum PlcModuleType : short
	{
		[Description("Undefined")]
		Undefined = 0,
		[Description("EL3174")]
		AinEL3174 = 1,
		[Description("ER3174")]
		AinER3174 = 2
	}
}
