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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_GetIoTVisualizationSummary")]
	public partial class msdyn_GetIoTVisualizationSummaryRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string DeviceId = "DeviceId";
			public const string ConfigurationTypeId = "ConfigurationTypeId";
		}
		
		public const string ActionLogicalName = "msdyn_GetIoTVisualizationSummary";
		
		public string DeviceId
		{
			get
			{
				if (this.Parameters.Contains("DeviceId"))
				{
					return ((string)(this.Parameters["DeviceId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DeviceId"] = value;
			}
		}
		
		public string ConfigurationTypeId
		{
			get
			{
				if (this.Parameters.Contains("ConfigurationTypeId"))
				{
					return ((string)(this.Parameters["ConfigurationTypeId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ConfigurationTypeId"] = value;
			}
		}
		
		public msdyn_GetIoTVisualizationSummaryRequest()
		{
			this.RequestName = "msdyn_GetIoTVisualizationSummary";
			this.DeviceId = default(string);
			this.ConfigurationTypeId = default(string);
		}
	}
}