using System;namespace FuncionamentoElevador.classes
{
    public class Elevador
    {
        private int totalDeAndares = 3;
        private int andarAtual = 0;
        private int capacidade = 6;
        private int pessoasPresentes;

        public int Capacidade
        {
            get { return capacidade; }
        }
        public int TotalDeAndares
        {
            get { return totalDeAndares; }
            set { totalDeAndares = value; }
        }
        public void Inicializa(int capacidade, int andares)
        {
            andarAtual = 0;
            pessoasPresentes = 0;
            Console.WriteLine($"Andar Atual é o Térreo e o elevador esta vazio");
        }
        public string Entrar(int capacidade)
        {
            if (pessoasPresentes < capacidade)
            {
                Console.WriteLine("Foi acrecentado uma pessoa");
                this.pessoasPresentes = this.pessoasPresentes + 1;
                return "O elevador tem " + pessoasPresentes + " pessoas";
            }
            else
            {
                return "Elevador está com a capacidade maxima de pessoas";
            }
        }
        public string Sair()
        {
            if (pessoasPresentes != 0)
            {
                Console.WriteLine("Uma pessoa saiu do elevador");
                this.pessoasPresentes = this.pessoasPresentes - 1;
                return "O elevador tem " + pessoasPresentes + " pessoas";
            }
            else
            {
                return "Elevador já está vazio!";
            }
        }
        public string Subir(int andares)
        {
            if (andarAtual < andares)
            {
                Console.WriteLine("Você subiu um andar");
                this.andarAtual = this.andarAtual + 1;
                if (this.andarAtual == 0)
                {
                    return "O elevador está no térreo";
                }
                else
                {
                    return "O elevador está no " + andarAtual + "º andar";
                }
            }
            else
            {
                return "Você só tem acesso até o terceiro andar!!!";
            }
        }
        public string Descer(int andares)
        {
            if (0 < andarAtual)
            {
                Console.WriteLine("Você desceu um andar");
                this.andarAtual = this.andarAtual - 1;
                if (this.andarAtual == 0)
                {
                    return "O elevador está no térreo";
                }
                else
                {
                    return "O elevador está no " + andarAtual + "º andar";
                }
            }
            else
            {
                return "Não é possível descer mais um andar";
            }
        }
    }
}