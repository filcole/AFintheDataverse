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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_RetrieveActivities")]
	public partial class msdyn_RetrieveActivitiesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string ActivityList = "ActivityList";
		}
		
		public const string ActionLogicalName = "msdyn_RetrieveActivities";
		
		public msdyn_RetrieveActivitiesResponse()
		{
		}
		
		public string ActivityList
		{
			get
			{
				if (this.Results.Contains("ActivityList"))
				{
					return ((string)(this.Results["ActivityList"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["ActivityList"] = value;
			}
		}
	}
}