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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_IoTSetConfiguration")]
	public partial class msdyn_IoTSetConfigurationRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Key = "Key";
			public const string Value = "Value";
		}
		
		public const string ActionLogicalName = "msdyn_IoTSetConfiguration";
		
		public string Key
		{
			get
			{
				if (this.Parameters.Contains("Key"))
				{
					return ((string)(this.Parameters["Key"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Key"] = value;
			}
		}
		
		public string Value
		{
			get
			{
				if (this.Parameters.Contains("Value"))
				{
					return ((string)(this.Parameters["Value"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Value"] = value;
			}
		}
		
		public msdyn_IoTSetConfigurationRequest()
		{
			this.RequestName = "msdyn_IoTSetConfiguration";
			this.Key = default(string);
			this.Value = default(string);
		}
	}
}