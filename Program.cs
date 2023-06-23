using System;
using System.IO;
using Newtonsoft.Json;
using poc.ga4.ev.EventModels;
using poc.ga4.ev.Factories;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev
{
    internal class Program
	{
		private static string _outputDirectory;

		static void Main(string[] args)
		{
			_outputDirectory = GetDirectory();

			var orderEntity = new OrderEntity();
			var factory = new EventModelFactory(new ECommerceFactory());
			var eventTypes = Enum.GetValues(typeof(EventType));

			foreach (EventType eventType in eventTypes)
			{
				var eventModel = factory.Create(eventType, orderEntity);
				WriteToJsonFile(eventModel);
			}
		}

		private static void WriteToJsonFile(BaseEventModel baseEventModel)
		{
			var jsonString = JsonConvert.SerializeObject(baseEventModel);
			File.WriteAllText($"{_outputDirectory}{baseEventModel.GetType().Name}.json", jsonString);
        }

		private static string GetDirectory()
		{
			var directoryPath = $"d:/Develop/Repos/poc.ga4.ev/examples/{DateTime.Now:yyyyMMddHHmmss}/";
			return Directory.CreateDirectory(directoryPath).FullName;
		}
	}
}
