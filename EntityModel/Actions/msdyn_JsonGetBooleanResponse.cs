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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_JsonGetBoolean")]
	public partial class msdyn_JsonGetBooleanResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string Value = "Value";
		}
		
		public const string ActionLogicalName = "msdyn_JsonGetBoolean";
		
		public msdyn_JsonGetBooleanResponse()
		{
		}
		
		public bool Value
		{
			get
			{
				if (this.Results.Contains("Value"))
				{
					return ((bool)(this.Results["Value"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["Value"] = value;
			}
		}
	}
}