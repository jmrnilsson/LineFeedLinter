using System.IO;
using System.Text.RegularExpressions;

namespace Cslint
{
	class Lf : CheckerBase, IChecker
	{
		public void Check(FileInfo file)
		{
			string fileName = file.FullName;
			string content = File.ReadAllText(fileName);
			content = Regex.Replace(content, "\r\n", "_");

			if (Regex.IsMatch(content, "\n", RegexOptions.Multiline))
			{
				OnError($"EE\tMatches LF: {fileName}");
			}
			else
			{
				OnInformation($"||\tMatches CRLF: {fileName}");
			}
		}

	}
}

