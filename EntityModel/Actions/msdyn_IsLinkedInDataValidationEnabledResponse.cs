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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_IsLinkedInDataValidationEnabled")]
	public partial class msdyn_IsLinkedInDataValidationEnabledResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string Result = "Result";
		}
		
		public const string ActionLogicalName = "msdyn_IsLinkedInDataValidationEnabled";
		
		public msdyn_IsLinkedInDataValidationEnabledResponse()
		{
		}
		
		public string Result
		{
			get
			{
				if (this.Results.Contains("Result"))
				{
					return ((string)(this.Results["Result"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["Result"] = value;
			}
		}
	}
}