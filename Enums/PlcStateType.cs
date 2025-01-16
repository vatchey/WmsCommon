using System.ComponentModel;

namespace WmsCommon.Enums
{
	// ensure it matches the database table and plc enum
	public enum PlcStateType
	{
		[Description("Undefined")]
		Undefined = 0,
		[Description("Idle")]
		Idle,
		[Description("Reset")]
		Reset,
		[Description("Initialize")]
		Init,
		[Description("Start")]
		Start,
		[Description("Run")]
		Run,
		[Description("Stop")]
		Stop,
		[Description("Save Configuration")]
		SaveConfig,
		[Description("Load Configuration")]
		LoadConfig,
		[Description("Power Failure")]
		PowerFailure,
		[Description("Power Good")]
		PowerGood,
		[Description("Error")]
		Error,
		[Description("Shutdown")]
		Shutdown,
		[Description("Suspend")]
		Suspend,
		[Description("Resume")]
		Resume,
		[Description("Config")]
		Config,
		[Description("Reconfig")]
		Reconfig,
		[Description("Stopping")]
		Stopping,
		[Description("Incompatible")]
		Incompatible,
		[Description("Exception")]
		Exception
	}
}
