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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_EvaluateSearchRequest")]
	public partial class _EvaluateSearchRequestResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string AvailableSlots = "AvailableSlots";
		}
		
		public const string ActionLogicalName = "_EvaluateSearchRequest";
		
		public _EvaluateSearchRequestResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection AvailableSlots
		{
			get
			{
				if (this.Results.Contains("AvailableSlots"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Results["AvailableSlots"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Results["AvailableSlots"] = value;
			}
		}
	}
}