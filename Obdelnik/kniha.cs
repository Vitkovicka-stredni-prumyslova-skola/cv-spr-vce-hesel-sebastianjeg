

namespace Knihovna
{
    // Rozhraní pro knihy
    public interface IKniha
    {
        string Nazev();  
        string Autor(); 
        int RokVydani(); 
    }

    
    public class Kniha : IKniha
    {
        private string nazev;
        private string autor;
        private int rokVydani;

        
        public Kniha(string nazev, string autor, int rokVydani)
        {
            this.nazev = nazev;
            this.autor = autor;
            this.rokVydani = rokVydani;
        }

        public string Nazev()
        {
            return this.nazev;
        }

        public string Autor()
        {
            return this.autor;
        }

        public int RokVydani()
        {
            return this.rokVydani;
        }

    }
    string[] Kniha1 = ("1984", "George Orwell", "1949");



def VypisKnih();

 



  }  