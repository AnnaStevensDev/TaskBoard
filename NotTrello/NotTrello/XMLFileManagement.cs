using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NotTrello
{
	class XMLFileManagement
	{
		static string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		static string path = location + "/tasks.txt";

		public static void SaveTasks(List<Task> t)
		{
			XmlSerializer writer = new XmlSerializer(typeof(List<Task>));
			FileStream file = File.Create(path);

			writer.Serialize(file, t);
			file.Close();
		}

		public static List<Task> ReadTasks()
		{
			List<Task> ListApp = new List<Task>();
			XmlSerializer reader = new XmlSerializer(typeof(List<Task>));
			StreamReader file = new StreamReader(path);

			ListApp = (List<Task>)reader.Deserialize(file);
			file.Close();

			return ListApp;
		}
	}
}