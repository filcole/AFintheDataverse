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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_IoTRegisterActionHandler")]
	public partial class msdyn_IoTRegisterActionHandlerRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string EntityCollection = "EntityCollection";
		}
		
		public const string ActionLogicalName = "msdyn_IoTRegisterActionHandler";
		
		public Microsoft.Xrm.Sdk.EntityCollection EntityCollection
		{
			get
			{
				if (this.Parameters.Contains("EntityCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["EntityCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["EntityCollection"] = value;
			}
		}
		
		public msdyn_IoTRegisterActionHandlerRequest()
		{
			this.RequestName = "msdyn_IoTRegisterActionHandler";
		}
	}
}