﻿using System;
using System.Web.UI;

namespace GroupDocs.Classification.Live.Demos.UI
{
	public partial class Index : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string productName = "";

				if (Page.RouteData.Values.Count > 0)
				{
					productName = Page.RouteData.Values["PageName"].ToString();
				}
				if (productName != "")
				{
					if (productName != "WebResource.axd")
					{
						Response.Redirect("~/errorpage");
					}
				}
			}

		}
	}
}