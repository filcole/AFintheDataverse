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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("DownloadSolutionExportData")]
	public partial class DownloadSolutionExportDataRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ExportJobId = "ExportJobId";
		}
		
		public const string ActionLogicalName = "DownloadSolutionExportData";
		
		public System.Guid ExportJobId
		{
			get
			{
				if (this.Parameters.Contains("ExportJobId"))
				{
					return ((System.Guid)(this.Parameters["ExportJobId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
			set
			{
				this.Parameters["ExportJobId"] = value;
			}
		}
		
		public DownloadSolutionExportDataRequest()
		{
			this.RequestName = "DownloadSolutionExportData";
			this.ExportJobId = default(System.Guid);
		}
	}
}