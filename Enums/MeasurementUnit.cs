using System.ComponentModel;

namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
	public enum MeasurementUnit : sbyte //short
	{
		[Description("Undefined")]
		Undefined = 0,

		[Description("mm")]
		Millimeter,
		[Description("V AC")]
		AcVoltage,
		[Description("A AC")]
		AcCurrent,
		[Description("psi")]
		Psi
	}
}
