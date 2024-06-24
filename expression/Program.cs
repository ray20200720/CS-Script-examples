using HostApplication.DataModel;

namespace HostApplication.DataModel
{
    public class BOM
    {
        public string? PlantCode { get; set; }
        public string? Material { get; set; }
        public string? Component { get; set; }
        public string? BomNodeType { get; set; }
    }
}

namespace HostApplication
{
	internal class Program
	{
		static void Main(string[] args)
		{
			 var bomData = new BOM 
			 { 
					 BomNodeType = "PC", 
					 Component = "C1", 
					 Material = "M1", 
					 PlantCode = "CP60" 
			 };
			 
			 Console.WriteLine($"{bomData.BomNodeType}");
			 
		}
	}
}