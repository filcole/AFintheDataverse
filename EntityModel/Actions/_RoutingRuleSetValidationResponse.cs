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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_RoutingRuleSetValidation")]
	public partial class _RoutingRuleSetValidationResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string ValidationMessageToDisplay = "ValidationMessageToDisplay";
			public const string ValidationMessageToDownload = "ValidationMessageToDownload";
		}
		
		public const string ActionLogicalName = "_RoutingRuleSetValidation";
		
		public _RoutingRuleSetValidationResponse()
		{
		}
		
		public string ValidationMessageToDisplay
		{
			get
			{
				if (this.Results.Contains("ValidationMessageToDisplay"))
				{
					return ((string)(this.Results["ValidationMessageToDisplay"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["ValidationMessageToDisplay"] = value;
			}
		}
		
		public string ValidationMessageToDownload
		{
			get
			{
				if (this.Results.Contains("ValidationMessageToDownload"))
				{
					return ((string)(this.Results["ValidationMessageToDownload"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["ValidationMessageToDownload"] = value;
			}
		}
	}
}