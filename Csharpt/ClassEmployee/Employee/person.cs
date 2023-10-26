namespace ClassEmployee.person
{
    public class person
    {
        public string id { get; set; }
        
        public string FullName { get; set; }
        
        public void EnterData()
        {
            System.Console.WriteLine("id");
            id = Console.ReadLine();
            System.Console.WriteLine(FullName);
            FullName = Console.ReadLine();
            
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1}",id, FullName);
        }
    }
}