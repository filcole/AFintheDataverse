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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_GetTalkingPoints")]
	public partial class msdyn_GetTalkingPointsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string entityId = "entityId";
			public const string entityType = "entityType";
		}
		
		public const string ActionLogicalName = "msdyn_GetTalkingPoints";
		
		public string entityId
		{
			get
			{
				if (this.Parameters.Contains("entityId"))
				{
					return ((string)(this.Parameters["entityId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["entityId"] = value;
			}
		}
		
		public string entityType
		{
			get
			{
				if (this.Parameters.Contains("entityType"))
				{
					return ((string)(this.Parameters["entityType"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["entityType"] = value;
			}
		}
		
		public msdyn_GetTalkingPointsRequest()
		{
			this.RequestName = "msdyn_GetTalkingPoints";
			this.entityId = default(string);
			this.entityType = default(string);
		}
	}
}