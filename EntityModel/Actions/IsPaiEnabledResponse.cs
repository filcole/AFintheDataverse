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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("IsPaiEnabled")]
	public partial class IsPaiEnabledResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string arePreviewScenarioEnabled = "arePreviewScenarioEnabled";
			public const string isdatamodelv2enabled = "isdatamodelv2enabled";
			public const string ispaienabled = "ispaienabled";
			public const string paigastatus = "paigastatus";
			public const string templates = "templates";
		}
		
		public const string ActionLogicalName = "IsPaiEnabled";
		
		public IsPaiEnabledResponse()
		{
		}
		
		public bool arePreviewScenarioEnabled
		{
			get
			{
				if (this.Results.Contains("arePreviewScenarioEnabled"))
				{
					return ((bool)(this.Results["arePreviewScenarioEnabled"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["arePreviewScenarioEnabled"] = value;
			}
		}
		
		public bool isdatamodelv2enabled
		{
			get
			{
				if (this.Results.Contains("isdatamodelv2enabled"))
				{
					return ((bool)(this.Results["isdatamodelv2enabled"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["isdatamodelv2enabled"] = value;
			}
		}
		
		public bool ispaienabled
		{
			get
			{
				if (this.Results.Contains("ispaienabled"))
				{
					return ((bool)(this.Results["ispaienabled"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["ispaienabled"] = value;
			}
		}
		
		public bool paigastatus
		{
			get
			{
				if (this.Results.Contains("paigastatus"))
				{
					return ((bool)(this.Results["paigastatus"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["paigastatus"] = value;
			}
		}
		
		public string templates
		{
			get
			{
				if (this.Results.Contains("templates"))
				{
					return ((string)(this.Results["templates"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["templates"] = value;
			}
		}
	}
}