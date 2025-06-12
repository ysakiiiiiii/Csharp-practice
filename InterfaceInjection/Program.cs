namespace InterfaceInjection
{    public interface IWriterTools
    {
         void SetPaper(Paper paper);
         void SetPencil(Pencil pencil);
    }
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

    public class EssayWriter : IWriterTools
    {
        private Pencil _pencil;
        private Paper _paper;
        
        public void SetPaper(Paper paper)
        {
            _paper = paper;
        }

        public void SetPencil(Pencil pencil)
        {
            _pencil = pencil;
        }

        public void MakeEssay()
        {
            _paper.Use();
            _pencil.Use();
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

            writer.SetPaper(paper);
            writer.SetPencil(pencil);
            writer.MakeEssay();
        }
    }
}
