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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/crm/2011/Contracts")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveCascadeDeleteAsyncJobId")]
	public partial class RetrieveCascadeDeleteAsyncJobIdRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ParentEntityId = "ParentEntityId";
		}
		
		public const string ActionLogicalName = "RetrieveCascadeDeleteAsyncJobId";
		
		public System.Guid ParentEntityId
		{
			get
			{
				if (this.Parameters.Contains("ParentEntityId"))
				{
					return ((System.Guid)(this.Parameters["ParentEntityId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
			set
			{
				this.Parameters["ParentEntityId"] = value;
			}
		}
		
		public RetrieveCascadeDeleteAsyncJobIdRequest()
		{
			this.RequestName = "RetrieveCascadeDeleteAsyncJobId";
			this.ParentEntityId = default(System.Guid);
		}
	}
}