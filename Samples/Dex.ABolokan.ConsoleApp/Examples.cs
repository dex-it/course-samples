using System;
using System.Collections.Generic;
using Dex.ABolokan.Services.Interfaces;
using Dex.ABolokan.Services.Services;

namespace Dex.ABolokan.ConsoleApp
{
	public class Examples : ExampleBase
	{
		public static void OopTest()
		{
			Start();

			var reportIds = new[] { 1, 2, 3, 4, 5 };

			var reportServices = new List<IReportService> { new ExcelReportService(), new PdfReportService() };

			foreach (var reportId in reportIds)
			{
				foreach (var reportService in reportServices)
				{
					var data = reportService.GetReportData(reportId);
					reportService.SaveReportData(data);
				}
				Line();
			}

			Finish();
		}
	}

	public class ExampleBase
	{
		public static void Start()
		{
			Console.WriteLine("Start! \n");
		}

		public static void Line()
		{
			Console.WriteLine(new string('-', 25));
		}

		public static void Finish()
		{
			Console.WriteLine("\n Finish!");
		}
	}

}
