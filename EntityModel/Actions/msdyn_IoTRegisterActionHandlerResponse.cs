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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_IoTRegisterActionHandler")]
	public partial class msdyn_IoTRegisterActionHandlerResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string RegistrationResultsJSON = "RegistrationResultsJSON";
		}
		
		public const string ActionLogicalName = "msdyn_IoTRegisterActionHandler";
		
		public msdyn_IoTRegisterActionHandlerResponse()
		{
		}
		
		public string RegistrationResultsJSON
		{
			get
			{
				if (this.Results.Contains("RegistrationResultsJSON"))
				{
					return ((string)(this.Results["RegistrationResultsJSON"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["RegistrationResultsJSON"] = value;
			}
		}
	}
}