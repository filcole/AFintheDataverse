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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_StartODOSProvisioning")]
	public partial class msdyn_StartODOSProvisioningRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Entities = "Entities";
			public const string FeatureName = "FeatureName";
			public const string FeatureDisplayName = "FeatureDisplayName";
			public const string Roles = "Roles";
			public const string Primitives = "Primitives";
		}
		
		public const string ActionLogicalName = "msdyn_StartODOSProvisioning";
		
		public string Entities
		{
			get
			{
				if (this.Parameters.Contains("Entities"))
				{
					return ((string)(this.Parameters["Entities"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Entities"] = value;
			}
		}
		
		public string FeatureName
		{
			get
			{
				if (this.Parameters.Contains("FeatureName"))
				{
					return ((string)(this.Parameters["FeatureName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["FeatureName"] = value;
			}
		}
		
		public string FeatureDisplayName
		{
			get
			{
				if (this.Parameters.Contains("FeatureDisplayName"))
				{
					return ((string)(this.Parameters["FeatureDisplayName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["FeatureDisplayName"] = value;
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
		
		public string Primitives
		{
			get
			{
				if (this.Parameters.Contains("Primitives"))
				{
					return ((string)(this.Parameters["Primitives"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Primitives"] = value;
			}
		}
		
		public msdyn_StartODOSProvisioningRequest()
		{
			this.RequestName = "msdyn_StartODOSProvisioning";
			this.Entities = default(string);
			this.FeatureName = default(string);
			this.FeatureDisplayName = default(string);
			this.Roles = default(string);
			this.Primitives = default(string);
		}
	}
}