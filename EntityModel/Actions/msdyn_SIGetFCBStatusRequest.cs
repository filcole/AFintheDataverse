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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_SIGetFCBStatus")]
	public partial class msdyn_SIGetFCBStatusRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string FCBName = "FCBName";
		}
		
		public const string ActionLogicalName = "msdyn_SIGetFCBStatus";
		
		public string FCBName
		{
			get
			{
				if (this.Parameters.Contains("FCBName"))
				{
					return ((string)(this.Parameters["FCBName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["FCBName"] = value;
			}
		}
		
		public msdyn_SIGetFCBStatusRequest()
		{
			this.RequestName = "msdyn_SIGetFCBStatus";
			this.FCBName = default(string);
		}
	}
}