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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_SaveServiceTreeData")]
	public partial class _SaveServiceTreeDataResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string Error = "Error";
			public const string UpdatedRootNode = "UpdatedRootNode";
		}
		
		public const string ActionLogicalName = "_SaveServiceTreeData";
		
		public _SaveServiceTreeDataResponse()
		{
		}
		
		public string Error
		{
			get
			{
				if (this.Results.Contains("Error"))
				{
					return ((string)(this.Results["Error"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["Error"] = value;
			}
		}
		
		public string UpdatedRootNode
		{
			get
			{
				if (this.Results.Contains("UpdatedRootNode"))
				{
					return ((string)(this.Results["UpdatedRootNode"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["UpdatedRootNode"] = value;
			}
		}
	}
}