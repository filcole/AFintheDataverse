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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_ProvisionSharePointDocumentLibraries")]
	public partial class msdyn_ProvisionSharePointDocumentLibrariesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string ProvisioningResult = "ProvisioningResult";
			public const string ProvisioningSummary = "ProvisioningSummary";
		}
		
		public const string ActionLogicalName = "msdyn_ProvisionSharePointDocumentLibraries";
		
		public msdyn_ProvisionSharePointDocumentLibrariesResponse()
		{
		}
		
		public string ProvisioningResult
		{
			get
			{
				if (this.Results.Contains("ProvisioningResult"))
				{
					return ((string)(this.Results["ProvisioningResult"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["ProvisioningResult"] = value;
			}
		}
		
		public string ProvisioningSummary
		{
			get
			{
				if (this.Results.Contains("ProvisioningSummary"))
				{
					return ((string)(this.Results["ProvisioningSummary"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["ProvisioningSummary"] = value;
			}
		}
	}
}