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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_EditAndSaveSuggestedContact")]
	public partial class msdyn_EditAndSaveSuggestedContactResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string id = "id";
		}
		
		public const string ActionLogicalName = "msdyn_EditAndSaveSuggestedContact";
		
		public msdyn_EditAndSaveSuggestedContactResponse()
		{
		}
		
		public string id
		{
			get
			{
				if (this.Results.Contains("id"))
				{
					return ((string)(this.Results["id"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["id"] = value;
			}
		}
	}
}