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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_cesinvoke")]
	public partial class msdyn_cesinvokeRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string CallType = "CallType";
			public const string EventName = "EventName";
			public const string SurveyName = "SurveyName";
		}
		
		public const string ActionLogicalName = "msdyn_cesinvoke";
		
		public string CallType
		{
			get
			{
				if (this.Parameters.Contains("CallType"))
				{
					return ((string)(this.Parameters["CallType"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["CallType"] = value;
			}
		}
		
		public string EventName
		{
			get
			{
				if (this.Parameters.Contains("EventName"))
				{
					return ((string)(this.Parameters["EventName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["EventName"] = value;
			}
		}
		
		public string SurveyName
		{
			get
			{
				if (this.Parameters.Contains("SurveyName"))
				{
					return ((string)(this.Parameters["SurveyName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SurveyName"] = value;
			}
		}
		
		public msdyn_cesinvokeRequest()
		{
			this.RequestName = "msdyn_cesinvoke";
		}
	}
}