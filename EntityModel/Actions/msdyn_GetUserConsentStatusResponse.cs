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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetUserConsentStatus")]
	public partial class msdyn_GetUserConsentStatusResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string status = "status";
		}
		
		public const string ActionLogicalName = "msdyn_GetUserConsentStatus";
		
		public msdyn_GetUserConsentStatusResponse()
		{
		}
		
		public string status
		{
			get
			{
				if (this.Results.Contains("status"))
				{
					return ((string)(this.Results["status"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["status"] = value;
			}
		}
	}
}