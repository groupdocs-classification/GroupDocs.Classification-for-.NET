<%@ Page Title="Free online sentiment analysis and document classification for PDF, DOC, DOCX and other formats" 
    MetaDescription="Classify PDF, DOC, DOCX, RTF files or text with IAB, Document or Sentiment taxonomy. Perform sentiment analysis, article or news text classification or classify document by content and layout" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClassificationApp.aspx.cs" Inherits="GroupDocs.Classification.Live.Demos.UI.ClassificationApp.ClassificationFileApp" %>


<asp:Content ID="HeadContents1" ContentPlaceHolderID="HeadContents" runat="server">

    <meta name="viewport" content="width=device-width, height=device-height, initial-scale=1.0, minimum-scale=1.0">
    <meta property="og:type" content="website" />
    <meta property="og:url" content="https://products.groupdocs.app/classification/total" />
    <meta property="og:site_name" content="GroupDocs.App" />
    <meta property="og:image" itemprop="image primaryImageOfPage" content="https://cms.admin.containerize.com/templates/groupdocs/images/logos/groupdocs-logo.png" />

    <meta name="twitter:card" content="summary" />
    <meta name="twitter:domain" content="products.groupdocs.app/classification/total" />
    <meta name="twitter:title" property="og:title" itemprop="name" content="GroupDocs.App - Free Online Sentiment Analysis, Documents and News (with IAB-2) Classification" />
    <meta name="twitter:description" property="og:description" itemprop="description" content="GroupDocs.App | Free Online Sentiment Analysis, Documents and News (with IAB-2) Classification" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="/ClassificationApp/Assets/styles_31.03.2020.css" rel="stylesheet" />

	<!-- GroupDocs.Apps UI Template Starts Here -->
	<asp:Panel ID="pnlTest" runat="server">
		<div class="container-fluid GroupDocsApps pb5">					
			<div class="container">
            	<div class="row">
					<div class="col-md-12 pt-5 pb-5">
						<h1 runat="server" id="hFeatureTitle"></h1>
						<h4 runat="server"><%=hFeatureDetails %> <a runat="server" target="_blank" id="taxonomy" style="color:#FFFFFF"></a></h4>
					</div>
				</div>

				<div class="row">
					<div class="col-md-12 pt-5 pb-5" style="padding-bottom: 0px!important;">
                        <asp:Button runat="server" ID="nosuchbtn" style="display:none"/>

			            <div class="container-fluid GroupDocsApps">
				            <div class="container">
					            <div class="row">
					            <% if (Request.Url.AbsoluteUri.Contains("://products.groupdocs.app"))
					            { %>
						            <app-root apiUrl="https://api.groupdocs.app/classify/v1/classification/" fileFormat="<%=fileFormat.Trim()%>" 
                                        invalidFileExtension="<%= Resources["InvalidFileExtension"] %>"></app-root>
					            <% } else { %>
						            <app-root apiUrl="https://api-qa.groupdocs.app/classify/v1/classification/" fileFormat="<%=fileFormat.Trim()%>" 
                                        invalidFileExtension="<%= Resources["InvalidFileExtension"] %>"></app-root>
					            <% } %>
					            </div>
				            </div>
			            </div>
					</div>
				</div>
			</div>
		</div>
	</asp:Panel>

	<div class="col-md-12 pt-5 bg-gray tc" style="padding-bottom: 0px!important;" id="dvAllFormats" runat="server">
		<div class="container">
			<div class="col-md-12 pull-left">
				<h2 class="h2title">GroupDocs.Classificaion App</h2>
				<p>GroupDocs.Classification App Supported Output Document Formats</p>
				<div class="diagram1 d2 d1-net">
					<div class="d1-row">
						<div class="d1-col d1-left">
							<header>Microsoft Office</header>
							<ul>
								<li><strong>Word:</strong> DOC, DOCX, DOT, DOTX, DOCM, DOTM, RTF</li>
							</ul>
						</div>
						<!--/left-->
						<div class="d1-col d1-right">
							<header>OpenDocument &amp; Other Formats</header>
							<ul>
								<li><strong>OpenDocument Formats:</strong> ODT, OTT, ODS, ODP</li>
								<li><strong>Adobe &amp; Fixed Layout:</strong> PSD, PDF, XPS</li>
                                <li><strong>Text:</strong> TXT</li>
							</ul>
						</div>
						<!--/right-->
					</div>
					<!--/row-->
					<div class="d1-logo">
						<img src="/ClassificationApp/Assets/groupdocs-classification-cloud_9090.png" alt=".NET Files Classification API"><header>GroupDocs.Classification</header>
						<footer><small>App</small></footer>
					</div>
					<!--/logo-->
				</div>
			</div>
		</div>
	</div>

	<div class="col-md-12 pull-left d-flex d-wrap bg-gray appfeaturesectionlist" id="dvFormatSection" runat="server" visible="false">
		<div class="col-md-6 cardbox tc col-md-offset-3 b6">
			<h3 runat="server" id="hExtension1"></h3>
			<p runat="server" id="hExtension1Description"></p>
		</div>
	</div>


	<!-- HowTo Section -->
	<div class="col-md-12 tl bg-darkgray howtolist">
		<div class="container tl dflex">

			<div class="col-md-4 howtosectiongfx">
				<img src="/img/howto.png">
			</div>

            <div id="howToAll" class="howtosection col-md-8" runat="server">
				<div>
					<h4><i class="fa fa-question-circle "></i>&nbsp;<b>How to classify documents or texts</b></h4>
					<ul>
						<li>Click <b>Add a new text</b> to add the text (e.g. article or news content) or click <b>Add file(s)</b> to upload one or multiple files.</li>
						<li>File(s) or text will be added to the classification table.</li>
                        <li>Repeat previous steps for other texts or files if necessary.</li>
                        <li>Click a button with taxonomy name in the added row to classify one row or click <b>Classify all</b> button.</li>
                        <li>Click <b>Download as csv</b> button to download classification report.</li>
					</ul>
				</div>
			</div>

			<div id="howToFileFormat" class="howtosection col-md-8" runat="server" visible="false">
				<div>
					<h4><i class="fa fa-question-circle "></i>&nbsp;<b>How to classify <%=fileFormat  %>documents</b></h4>
					<ul>
						<li>Click <b>Add .<%=fileFormat%>file(s)</b> to upload one or multiple files.</li>
						<li>File(s) will be added to the classification table.</li>
                        <li>Click a button with taxonomy name in the added row to classify one file or click <b>Classify all</b> button.</li>
                        <li>Click <b>Download as csv</b> button to download classification report.</li>
					</ul>
				</div>
			</div>
		</div>
	</div>

	<div class="col-md-12 pt-5 app-features-section" style="padding-bottom: 0px!important;">
		<div class="container tc pt-5">
			<div class="col-md-4">
				<div class="imgcircle fasteasy">
					<img src="../../img/fast-easy.png" />
				</div>
				<h4><%= Resources["Feature1Classification"] %></h4>
				<p id="h4para" runat="server">.</p>
			</div>

			<div class="col-md-4">
				<div class="imgcircle anywhere">
					<img src="../../img/anywhere.png" />
				</div>
				<h4><%= Resources["Feature2Classification"] %></h4>
				<p><%= Resources["Feature2ClassificationDescription"] %>.</p>
			</div>

			<div class="col-md-4">
				<div class="imgcircle quality">
					<img src="../../img/quality.png" />
				</div>
				<h4><%= Resources["Feature3Classification"] %></h4>
				<p><%= Resources["PoweredBy"] %> <a runat="server" target="_blank" id="aPoweredBy"></a><%= Resources["Feature3ClassificationDescription"] %>.</p>
			</div>
		</div>
	</div>
	<script>
		if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {

			var swiper = new Swiper('.swiper-container', {
				slidesPerView: 5,
				spaceBetween: 20,
				// init: false,
				pagination: {
					el: '.swiper-pagination',
					clickable: true,
				},
				navigation: {
					nextEl: '.swiper-button-next',
					prevEl: '.swiper-button-prev',
				},
				breakpoints: {
					868: {
						slidesPerView: 4,
						spaceBetween: 20,
					},
					668: {
						slidesPerView: 2,
						spaceBetween: 0,
					}
				}
			});
		}
	</script>
    <script type="text/javascript" src="/ClassificationApp/Assets/runtime.js"></script>
	<script type="text/javascript" src="/ClassificationApp/Assets/es2015-polyfills.js" nomodule></script>
	<script type="text/javascript" src="/ClassificationApp/Assets/polyfills.js"></script>
	<script type="text/javascript" src="/ClassificationApp/Assets/main_31.03.2020.js"></script>
</asp:Content>
