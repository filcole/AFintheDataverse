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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_CreateApmEventHandler")]
	public partial class msdyn_CreateApmEventHandlerResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string UpdateAppModuleResponse = "UpdateAppModuleResponse";
		}
		
		public const string ActionLogicalName = "msdyn_CreateApmEventHandler";
		
		public msdyn_CreateApmEventHandlerResponse()
		{
		}
		
		public string UpdateAppModuleResponse
		{
			get
			{
				if (this.Results.Contains("UpdateAppModuleResponse"))
				{
					return ((string)(this.Results["UpdateAppModuleResponse"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["UpdateAppModuleResponse"] = value;
			}
		}
	}
}