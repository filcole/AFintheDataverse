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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("ExtractKeyPhrases")]
	public partial class ExtractKeyPhrasesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string countOfPhrases = "countOfPhrases";
			public const string phrases = "phrases";
		}
		
		public const string ActionLogicalName = "ExtractKeyPhrases";
		
		public ExtractKeyPhrasesResponse()
		{
		}
		
		public decimal countOfPhrases
		{
			get
			{
				if (this.Results.Contains("countOfPhrases"))
				{
					return ((decimal)(this.Results["countOfPhrases"]));
				}
				else
				{
					return default(decimal);
				}
			}
			set
			{
				this.Results["countOfPhrases"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection phrases
		{
			get
			{
				if (this.Results.Contains("phrases"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Results["phrases"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Results["phrases"] = value;
			}
		}
	}
}