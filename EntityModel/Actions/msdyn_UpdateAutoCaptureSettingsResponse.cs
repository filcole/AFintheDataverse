//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ebecs.PGC.CEEntityModel
{
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_UpdateAutoCaptureSettings")]
	public partial class msdyn_UpdateAutoCaptureSettingsResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string settingstatus = "settingstatus";
		}
		
		public const string ActionLogicalName = "msdyn_UpdateAutoCaptureSettings";
		
		public msdyn_UpdateAutoCaptureSettingsResponse()
		{
		}
		
		public bool settingstatus
		{
			get
			{
				if (this.Results.Contains("settingstatus"))
				{
					return ((bool)(this.Results["settingstatus"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["settingstatus"] = value;
			}
		}
	}
}