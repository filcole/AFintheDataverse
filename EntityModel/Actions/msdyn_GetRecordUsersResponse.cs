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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetRecordUsers")]
	public partial class msdyn_GetRecordUsersResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string recordusers = "recordusers";
		}
		
		public const string ActionLogicalName = "msdyn_GetRecordUsers";
		
		public msdyn_GetRecordUsersResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection recordusers
		{
			get
			{
				if (this.Results.Contains("recordusers"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Results["recordusers"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Results["recordusers"] = value;
			}
		}
	}
}