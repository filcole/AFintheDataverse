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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_ExportAndUploadToSPAction")]
	public partial class msdyn_ExportAndUploadToSPActionResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string SavedToSharePoint = "SavedToSharePoint";
		}
		
		public const string ActionLogicalName = "msdyn_ExportAndUploadToSPAction";
		
		public msdyn_ExportAndUploadToSPActionResponse()
		{
		}
		
		public bool SavedToSharePoint
		{
			get
			{
				if (this.Results.Contains("SavedToSharePoint"))
				{
					return ((bool)(this.Results["SavedToSharePoint"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["SavedToSharePoint"] = value;
			}
		}
	}
}