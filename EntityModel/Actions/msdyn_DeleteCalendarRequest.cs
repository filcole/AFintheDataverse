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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_DeleteCalendar")]
	public partial class msdyn_DeleteCalendarRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string CalendarEventInfo = "CalendarEventInfo";
		}
		
		public const string ActionLogicalName = "msdyn_DeleteCalendar";
		
		public string CalendarEventInfo
		{
			get
			{
				if (this.Parameters.Contains("CalendarEventInfo"))
				{
					return ((string)(this.Parameters["CalendarEventInfo"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["CalendarEventInfo"] = value;
			}
		}
		
		public msdyn_DeleteCalendarRequest()
		{
			this.RequestName = "msdyn_DeleteCalendar";
		}
	}
}