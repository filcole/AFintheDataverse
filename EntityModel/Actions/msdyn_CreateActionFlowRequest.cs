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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_CreateActionFlow")]
	public partial class msdyn_CreateActionFlowRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string SLAId = "SLAId";
		}
		
		public const string ActionLogicalName = "msdyn_CreateActionFlow";
		
		public string SLAId
		{
			get
			{
				if (this.Parameters.Contains("SLAId"))
				{
					return ((string)(this.Parameters["SLAId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SLAId"] = value;
			}
		}
		
		public msdyn_CreateActionFlowRequest()
		{
			this.RequestName = "msdyn_CreateActionFlow";
			this.SLAId = default(string);
		}
	}
}