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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("CategorizeText")]
	public partial class CategorizeTextResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string categories = "categories";
			public const string originalText = "originalText";
		}
		
		public const string ActionLogicalName = "CategorizeText";
		
		public CategorizeTextResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection categories
		{
			get
			{
				if (this.Results.Contains("categories"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Results["categories"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Results["categories"] = value;
			}
		}
		
		public string originalText
		{
			get
			{
				if (this.Results.Contains("originalText"))
				{
					return ((string)(this.Results["originalText"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["originalText"] = value;
			}
		}
	}
}