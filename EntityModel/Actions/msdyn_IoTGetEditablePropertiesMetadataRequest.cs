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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_IoTGetEditablePropertiesMetadata")]
	public partial class msdyn_IoTGetEditablePropertiesMetadataRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string DeviceCategory = "DeviceCategory";
		}
		
		public const string ActionLogicalName = "msdyn_IoTGetEditablePropertiesMetadata";
		
		public Microsoft.Xrm.Sdk.EntityReference DeviceCategory
		{
			get
			{
				if (this.Parameters.Contains("DeviceCategory"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["DeviceCategory"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["DeviceCategory"] = value;
			}
		}
		
		public msdyn_IoTGetEditablePropertiesMetadataRequest()
		{
			this.RequestName = "msdyn_IoTGetEditablePropertiesMetadata";
			this.DeviceCategory = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
}