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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("_RemoveMarketingListMembersByIds")]
	public partial class _RemoveMarketingListMembersByIdsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ListId = "ListId";
			public const string MemberIds = "MemberIds";
		}
		
		public const string ActionLogicalName = "_RemoveMarketingListMembersByIds";
		
		public string ListId
		{
			get
			{
				if (this.Parameters.Contains("ListId"))
				{
					return ((string)(this.Parameters["ListId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ListId"] = value;
			}
		}
		
		public string MemberIds
		{
			get
			{
				if (this.Parameters.Contains("MemberIds"))
				{
					return ((string)(this.Parameters["MemberIds"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["MemberIds"] = value;
			}
		}
		
		public _RemoveMarketingListMembersByIdsRequest()
		{
			this.RequestName = "_RemoveMarketingListMembersByIds";
		}
	}
}