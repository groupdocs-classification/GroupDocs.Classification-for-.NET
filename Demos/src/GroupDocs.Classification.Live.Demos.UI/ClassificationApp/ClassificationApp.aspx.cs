using GroupDocs.Classification.Live.Demos.UI.Config;
using System;

namespace GroupDocs.Classification.Live.Demos.UI.ClassificationApp
{
	public partial class ClassificationFileApp : BasePage
	{
		public string fileFormat = "";

        public string hFeatureDetails = "";

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				dvAllFormats.Visible = true;

                taxonomy.InnerText = "IAB-2, Documents or Sentiment taxonomies";
                taxonomy.HRef = "https://docs.groupdocs.com/display/classificationnet/Taxonomies";

                aPoweredBy.InnerText = "GroupDocs.Classification";
				aPoweredBy.HRef = "https://products.groupdocs.com/classification";

				hFeatureTitle.InnerText = "Free Online Document or Text Classification";
				hFeatureDetails = "Categorize PDF, MS Word (DOC, DOCX,..), OpenOffice, TXT documents online with";

				h4para.InnerText = string.Format(Resources["Feature1ClassificationDescription"], "");
			}
		}
	}
}