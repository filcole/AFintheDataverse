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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_ResourcesAddUpdateAction")]
	public partial class _ResourcesAddUpdateActionResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string CyclicResources = "CyclicResources";
		}
		
		public const string ActionLogicalName = "_ResourcesAddUpdateAction";
		
		public _ResourcesAddUpdateActionResponse()
		{
		}
		
		public string CyclicResources
		{
			get
			{
				if (this.Results.Contains("CyclicResources"))
				{
					return ((string)(this.Results["CyclicResources"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["CyclicResources"] = value;
			}
		}
	}
}