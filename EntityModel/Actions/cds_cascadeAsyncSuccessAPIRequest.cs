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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("cds_cascadeAsyncSuccessAPI")]
	public partial class cds_cascadeAsyncSuccessAPIRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string cds_casadeAsyncJobName = "cds_casadeAsyncJobName";
		}
		
		public const string ActionLogicalName = "cds_cascadeAsyncSuccessAPI";
		
		public string cds_casadeAsyncJobName
		{
			get
			{
				if (this.Parameters.Contains("cds_casadeAsyncJobName"))
				{
					return ((string)(this.Parameters["cds_casadeAsyncJobName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["cds_casadeAsyncJobName"] = value;
			}
		}
		
		public cds_cascadeAsyncSuccessAPIRequest()
		{
			this.RequestName = "cds_cascadeAsyncSuccessAPI";
			this.cds_casadeAsyncJobName = default(string);
		}
	}
}