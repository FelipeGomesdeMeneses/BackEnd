namespace Construtores
{
    public class Computador
    {
        public string Nome;
        public string Marca;

        public int MemoriaRam;

        public int Armazenamento;

        public Computador()
        {
            Nome = "Salgado";
            Marca = "Pichau";
            MemoriaRam = 12;
            Armazenamento = 2000;
        }

        public Computador(string n, string m, int mem, int a)
        {
            Nome = n;
            Marca = m;
            MemoriaRam = mem;
            Armazenamento = a;
        }
        
        public void Exibir()
        {
            Console.WriteLine($"O computador do {Nome} é da marca {Marca}, tem {MemoriaRam} gb de memória ram e {Armazenamento} gb de armazenamento");
            
        }
    }
}