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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_RetrieveKpiValuesFromRI")]
	public partial class msdyn_RetrieveKpiValuesFromRIResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string KpiValues = "KpiValues";
		}
		
		public const string ActionLogicalName = "msdyn_RetrieveKpiValuesFromRI";
		
		public msdyn_RetrieveKpiValuesFromRIResponse()
		{
		}
		
		public string KpiValues
		{
			get
			{
				if (this.Results.Contains("KpiValues"))
				{
					return ((string)(this.Results["KpiValues"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["KpiValues"] = value;
			}
		}
	}
}