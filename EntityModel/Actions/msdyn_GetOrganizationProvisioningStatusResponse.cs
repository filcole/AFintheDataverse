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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetOrganizationProvisioningStatus")]
	public partial class msdyn_GetOrganizationProvisioningStatusResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string OrgProvisioningStatus = "OrgProvisioningStatus";
		}
		
		public const string ActionLogicalName = "msdyn_GetOrganizationProvisioningStatus";
		
		public msdyn_GetOrganizationProvisioningStatusResponse()
		{
		}
		
		public string OrgProvisioningStatus
		{
			get
			{
				if (this.Results.Contains("OrgProvisioningStatus"))
				{
					return ((string)(this.Results["OrgProvisioningStatus"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["OrgProvisioningStatus"] = value;
			}
		}
	}
}