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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_CreateNewAnalysisJobForRuleSet")]
	public partial class msdyn_CreateNewAnalysisJobForRuleSetResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string CreatedAnalysisJob = "CreatedAnalysisJob";
		}
		
		public const string ActionLogicalName = "msdyn_CreateNewAnalysisJobForRuleSet";
		
		public msdyn_CreateNewAnalysisJobForRuleSetResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.EntityReference CreatedAnalysisJob
		{
			get
			{
				if (this.Results.Contains("CreatedAnalysisJob"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["CreatedAnalysisJob"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["CreatedAnalysisJob"] = value;
			}
		}
	}
}