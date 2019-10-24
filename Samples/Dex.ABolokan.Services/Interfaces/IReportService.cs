using System;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services.Interfaces
{
	public interface IReportService
	{
		string GetReportData(int reportId);
		void SaveReportData(string reportData);
	}
}
