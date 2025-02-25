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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_ForecastGenerateHierarchy")]
	public partial class msdyn_ForecastGenerateHierarchyRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ForecastDefinition = "ForecastDefinition";
			public const string IsRefresh = "IsRefresh";
			public const string RecurrenceIndex = "RecurrenceIndex";
		}
		
		public const string ActionLogicalName = "msdyn_ForecastGenerateHierarchy";
		
		public Microsoft.Xrm.Sdk.EntityReference ForecastDefinition
		{
			get
			{
				if (this.Parameters.Contains("ForecastDefinition"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["ForecastDefinition"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["ForecastDefinition"] = value;
			}
		}
		
		public bool IsRefresh
		{
			get
			{
				if (this.Parameters.Contains("IsRefresh"))
				{
					return ((bool)(this.Parameters["IsRefresh"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["IsRefresh"] = value;
			}
		}
		
		public int RecurrenceIndex
		{
			get
			{
				if (this.Parameters.Contains("RecurrenceIndex"))
				{
					return ((int)(this.Parameters["RecurrenceIndex"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["RecurrenceIndex"] = value;
			}
		}
		
		public msdyn_ForecastGenerateHierarchyRequest()
		{
			this.RequestName = "msdyn_ForecastGenerateHierarchy";
			this.ForecastDefinition = default(Microsoft.Xrm.Sdk.EntityReference);
			this.IsRefresh = default(bool);
		}
	}
}