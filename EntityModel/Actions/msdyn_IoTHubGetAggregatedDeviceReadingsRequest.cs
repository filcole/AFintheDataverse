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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_IoTHubGetAggregatedDeviceReadings")]
	public partial class msdyn_IoTHubGetAggregatedDeviceReadingsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string DeviceId = "DeviceId";
			public const string Measures = "Measures";
		}
		
		public const string ActionLogicalName = "msdyn_IoTHubGetAggregatedDeviceReadings";
		
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
		
		public string Measures
		{
			get
			{
				if (this.Parameters.Contains("Measures"))
				{
					return ((string)(this.Parameters["Measures"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Measures"] = value;
			}
		}
		
		public msdyn_IoTHubGetAggregatedDeviceReadingsRequest()
		{
			this.RequestName = "msdyn_IoTHubGetAggregatedDeviceReadings";
			this.DeviceId = default(string);
			this.Measures = default(string);
		}
	}
}