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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_ForecastApi")]
	public partial class msdyn_ForecastApiRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string WebApiName = "WebApiName";
			public const string RequestJson = "RequestJson";
		}
		
		public const string ActionLogicalName = "msdyn_ForecastApi";
		
		public string WebApiName
		{
			get
			{
				if (this.Parameters.Contains("WebApiName"))
				{
					return ((string)(this.Parameters["WebApiName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["WebApiName"] = value;
			}
		}
		
		public string RequestJson
		{
			get
			{
				if (this.Parameters.Contains("RequestJson"))
				{
					return ((string)(this.Parameters["RequestJson"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["RequestJson"] = value;
			}
		}
		
		public msdyn_ForecastApiRequest()
		{
			this.RequestName = "msdyn_ForecastApi";
			this.WebApiName = default(string);
		}
	}
}