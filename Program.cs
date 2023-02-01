using System.Xml;

namespace CustomBuildStepsDisabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var replace = @"<Command>""$(OutDir)injector.exe""
powershell -nop -c ""&amp; {sleep 15}""</Command>";
            var path = Path.Combine(Environment.CurrentDirectory, "cheat-library", "cheat-library.vcxproj");
            var text = File.ReadAllText(path);
            text = text.Replace(replace, "<Command></Command>");
            File.WriteAllText(path, text);
        }
    }
}