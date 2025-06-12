namespace SetterInjection
{
    public class Paper
    {
        public void Use()
        {
            Console.WriteLine("Preparing Paper...");
        }
    }
    public class Pencil
    {
        public void Use()
        {
            Console.WriteLine("Writing in the Paper...");
        }
    }

    public class EssayWriter
    {
        public Paper Paper { get; set; }
        public Pencil Pencil { get; set; }


        public void MakeEssay()
        {
            Paper.Use(); 
            Pencil.Use();
            Console.WriteLine("Finished Writing an Essay");

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Paper paper = new Paper(); 
            Pencil pencil = new Pencil();
            EssayWriter writer = new EssayWriter();

            writer.Paper = paper;
            writer.Pencil = pencil; 
            writer.MakeEssay();
        }
    }
}
