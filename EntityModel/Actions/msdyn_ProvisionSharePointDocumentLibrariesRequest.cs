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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_ProvisionSharePointDocumentLibraries")]
	public partial class msdyn_ProvisionSharePointDocumentLibrariesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string SharePointSiteURL = "SharePointSiteURL";
			public const string FolderStructureEntityValue = "FolderStructureEntityValue";
		}
		
		public const string ActionLogicalName = "msdyn_ProvisionSharePointDocumentLibraries";
		
		public string SharePointSiteURL
		{
			get
			{
				if (this.Parameters.Contains("SharePointSiteURL"))
				{
					return ((string)(this.Parameters["SharePointSiteURL"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SharePointSiteURL"] = value;
			}
		}
		
		public int FolderStructureEntityValue
		{
			get
			{
				if (this.Parameters.Contains("FolderStructureEntityValue"))
				{
					return ((int)(this.Parameters["FolderStructureEntityValue"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["FolderStructureEntityValue"] = value;
			}
		}
		
		public msdyn_ProvisionSharePointDocumentLibrariesRequest()
		{
			this.RequestName = "msdyn_ProvisionSharePointDocumentLibraries";
		}
	}
}