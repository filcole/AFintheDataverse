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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_PostRetrieveRealTimeSuggestedActivities")]
	public partial class msdyn_PostRetrieveRealTimeSuggestedActivitiesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string RetrievedRealTimeSuggestedActivitiesCount = "RetrievedRealTimeSuggestedActivitiesCount";
		}
		
		public const string ActionLogicalName = "msdyn_PostRetrieveRealTimeSuggestedActivities";
		
		public msdyn_PostRetrieveRealTimeSuggestedActivitiesResponse()
		{
		}
		
		public int RetrievedRealTimeSuggestedActivitiesCount
		{
			get
			{
				if (this.Results.Contains("RetrievedRealTimeSuggestedActivitiesCount"))
				{
					return ((int)(this.Results["RetrievedRealTimeSuggestedActivitiesCount"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Results["RetrievedRealTimeSuggestedActivitiesCount"] = value;
			}
		}
	}
}