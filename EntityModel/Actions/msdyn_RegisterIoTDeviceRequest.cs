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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_RegisterIoTDevice")]
	public partial class msdyn_RegisterIoTDeviceRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string IoTDeviceIds = "IoTDeviceIds";
		}
		
		public const string ActionLogicalName = "msdyn_RegisterIoTDevice";
		
		public string IoTDeviceIds
		{
			get
			{
				if (this.Parameters.Contains("IoTDeviceIds"))
				{
					return ((string)(this.Parameters["IoTDeviceIds"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["IoTDeviceIds"] = value;
			}
		}
		
		public msdyn_RegisterIoTDeviceRequest()
		{
			this.RequestName = "msdyn_RegisterIoTDevice";
			this.IoTDeviceIds = default(string);
		}
	}
}