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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_GetServiceBaseUrl")]
	public partial class msdyn_GetServiceBaseUrlRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string AzureApplicationType = "AzureApplicationType";
		}
		
		public const string ActionLogicalName = "msdyn_GetServiceBaseUrl";
		
		public int AzureApplicationType
		{
			get
			{
				if (this.Parameters.Contains("AzureApplicationType"))
				{
					return ((int)(this.Parameters["AzureApplicationType"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["AzureApplicationType"] = value;
			}
		}
		
		public msdyn_GetServiceBaseUrlRequest()
		{
			this.RequestName = "msdyn_GetServiceBaseUrl";
			this.AzureApplicationType = default(int);
		}
	}
}