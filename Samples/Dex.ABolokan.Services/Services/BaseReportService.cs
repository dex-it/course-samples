using System;

namespace Dex.ABolokan.Services.Services
{
	public abstract class BaseReportService
	{
		public virtual void SaveReportData(string reportData)
		{
			Console.WriteLine($"{reportData} сохранен!");
		}
	}
}
