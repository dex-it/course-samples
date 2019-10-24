using System;
using System.Collections.Generic;
using System.Text;
using Dex.ABolokan.Services.Interfaces;

namespace Dex.ABolokan.Services.Services
{
	public class PdfReportService : BaseReportService, IReportService
	{
		public string GetReportData(int reportId)
		{
			return $"Report_{reportId}.pdf";
		}

		public override void SaveReportData(string reportData)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			base.SaveReportData(reportData);
			Console.ResetColor();
		}
	}
}
