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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetAnalyticsReportDetail")]
	public partial class msdyn_GetAnalyticsReportDetailResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string ReportInfo = "ReportInfo";
		}
		
		public const string ActionLogicalName = "msdyn_GetAnalyticsReportDetail";
		
		public msdyn_GetAnalyticsReportDetailResponse()
		{
		}
		
		public string ReportInfo
		{
			get
			{
				if (this.Results.Contains("ReportInfo"))
				{
					return ((string)(this.Results["ReportInfo"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["ReportInfo"] = value;
			}
		}
	}
}