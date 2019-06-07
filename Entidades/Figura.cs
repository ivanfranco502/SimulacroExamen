namespace SimulacroExamen.Entidades
{
    public abstract class Figura
    {
        public Lado[] Lados {get;set;}

        public string Nombre{get;set;}

        public abstract decimal Perimetro(){}
        public abstract decimal Area(){}
    }
}