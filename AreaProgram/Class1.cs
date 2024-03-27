using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaProgram
{
    internal class Lote
    {
        float largura;
        float profundidade;
        Char letra;
        String codigo;
        float area; //?
        private int v1;
        private int v2;
        private object e;

      
        public Lote(float largura, float profundidade, char letra)
        {
            this.largura = largura;
            this.profundidade = profundidade;
            this.letra = letra;
        }

        public void calculaCodigo()
        {
            float area = this.profundidade * this.largura;
            this.codigo = this.letra.ToString() + area.ToString();
            this.area = area;

        }
        public void mostraDados(){
            Console.WriteLine(this.codigo);
            Console.WriteLine(this.area);
            Console.WriteLine(this.largura);
            Console.WriteLine(this.profundidade);
        }

        public static Lote operator +(Lote a, Lote b){
            Lote aux = new Lote(a.largura + b.largura, a.profundidade, a.letra > b.letra? b.letra : a.letra); //pensar no algoritmo de ver qual a menor letra
            if (a.profundidade == b.profundidade){
                aux.calculaCodigo();
                return aux;
                

            }
            else
            {
                Console.WriteLine("Parâmetros inválidos");
                return null;
            }
        }

        public static Lote[] operator /(Lote a, Lote b){
            if (b.largura == 0)
                throw new ArgumentException("Não é possível dividir por um lote com largura zero.");

            int n = (int)(a.largura / b.largura);
            if (n <= 0)
                throw new ArgumentException("Não é possível dividir a largura igualmente.");

            Lote[] novosLotes = new Lote[n];
            char letra = a.letra;

            for (int i = 0; i < n; i++)
            {
                novosLotes[i] = new Lote(b.largura, a.profundidade, letra);
                letra = (char)(((letra - 'A' + 1) % 26) + 'A'); // Próxima letra (retorna à A após Z)
            }

            return novosLotes;


        }

   

    }
}
