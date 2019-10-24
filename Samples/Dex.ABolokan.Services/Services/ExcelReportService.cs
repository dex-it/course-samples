using System;
using System.Collections.Generic;
using System.Text;
using Dex.ABolokan.Services.Interfaces;

namespace Dex.ABolokan.Services.Services
{
	public class ExcelReportService : BaseReportService, IReportService
	{
		public string GetReportData(int reportId)
		{
			return $"Report_{reportId}.xlsx";
		}
	}
}
