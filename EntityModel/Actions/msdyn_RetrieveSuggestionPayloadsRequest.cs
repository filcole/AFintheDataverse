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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_RetrieveSuggestionPayloads")]
	public partial class msdyn_RetrieveSuggestionPayloadsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string SuggestionFor = "SuggestionFor";
			public const string Context = "Context";
			public const string SuggestionType = "SuggestionType";
		}
		
		public const string ActionLogicalName = "msdyn_RetrieveSuggestionPayloads";
		
		public Microsoft.Xrm.Sdk.EntityReference SuggestionFor
		{
			get
			{
				if (this.Parameters.Contains("SuggestionFor"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["SuggestionFor"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["SuggestionFor"] = value;
			}
		}
		
		public string Context
		{
			get
			{
				if (this.Parameters.Contains("Context"))
				{
					return ((string)(this.Parameters["Context"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Context"] = value;
			}
		}
		
		public string SuggestionType
		{
			get
			{
				if (this.Parameters.Contains("SuggestionType"))
				{
					return ((string)(this.Parameters["SuggestionType"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SuggestionType"] = value;
			}
		}
		
		public msdyn_RetrieveSuggestionPayloadsRequest()
		{
			this.RequestName = "msdyn_RetrieveSuggestionPayloads";
			this.SuggestionFor = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
}