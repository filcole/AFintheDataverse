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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_getAppConfigByContext")]
	public partial class msdyn_getAppConfigByContextRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string AppUniqueName = "AppUniqueName";
			public const string UserId = "UserId";
			public const string Roles = "Roles";
			public const string FormFactor = "FormFactor";
		}
		
		public const string ActionLogicalName = "msdyn_getAppConfigByContext";
		
		public string AppUniqueName
		{
			get
			{
				if (this.Parameters.Contains("AppUniqueName"))
				{
					return ((string)(this.Parameters["AppUniqueName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["AppUniqueName"] = value;
			}
		}
		
		public string UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((string)(this.Parameters["UserId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public string Roles
		{
			get
			{
				if (this.Parameters.Contains("Roles"))
				{
					return ((string)(this.Parameters["Roles"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Roles"] = value;
			}
		}
		
		public int FormFactor
		{
			get
			{
				if (this.Parameters.Contains("FormFactor"))
				{
					return ((int)(this.Parameters["FormFactor"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["FormFactor"] = value;
			}
		}
		
		public msdyn_getAppConfigByContextRequest()
		{
			this.RequestName = "msdyn_getAppConfigByContext";
			this.AppUniqueName = default(string);
		}
	}
}