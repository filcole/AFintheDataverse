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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetRelatedIoTDevicesByEntity")]
	public partial class msdyn_GetRelatedIoTDevicesByEntityResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string RelatedIoTDevicesByEntityOutput = "RelatedIoTDevicesByEntityOutput";
		}
		
		public const string ActionLogicalName = "msdyn_GetRelatedIoTDevicesByEntity";
		
		public msdyn_GetRelatedIoTDevicesByEntityResponse()
		{
		}
		
		public string RelatedIoTDevicesByEntityOutput
		{
			get
			{
				if (this.Results.Contains("RelatedIoTDevicesByEntityOutput"))
				{
					return ((string)(this.Results["RelatedIoTDevicesByEntityOutput"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["RelatedIoTDevicesByEntityOutput"] = value;
			}
		}
	}
}