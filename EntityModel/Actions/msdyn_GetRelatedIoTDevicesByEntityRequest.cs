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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_GetRelatedIoTDevicesByEntity")]
	public partial class msdyn_GetRelatedIoTDevicesByEntityRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string EntityLogicalName = "EntityLogicalName";
			public const string EntityId = "EntityId";
		}
		
		public const string ActionLogicalName = "msdyn_GetRelatedIoTDevicesByEntity";
		
		public string EntityLogicalName
		{
			get
			{
				if (this.Parameters.Contains("EntityLogicalName"))
				{
					return ((string)(this.Parameters["EntityLogicalName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["EntityLogicalName"] = value;
			}
		}
		
		public string EntityId
		{
			get
			{
				if (this.Parameters.Contains("EntityId"))
				{
					return ((string)(this.Parameters["EntityId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["EntityId"] = value;
			}
		}
		
		public msdyn_GetRelatedIoTDevicesByEntityRequest()
		{
			this.RequestName = "msdyn_GetRelatedIoTDevicesByEntity";
			this.EntityLogicalName = default(string);
			this.EntityId = default(string);
		}
	}
}