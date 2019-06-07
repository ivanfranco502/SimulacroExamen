namespace SimulacroExamen.Entidades
{
    public class Rectangulo : Figura
    {
        public Rectangulo(decimal longitudBase, decimal longitudAltura)
        {
            this.Nombre = "Rectangulo";
            this.Lados = new Lado[2]{
                longitudBase,
                longitudAltura
            };
        }

        public override decimal Area(){
            decimal area = 1;

            for (int i = 0; i < this.Lados.Length; i++)
            {
                area = area * this.Lados[i];
            }

            return area;
        }

        public override decimal Perimetro(){
            decimal perimetro = 0;

            for (int i = 0; i < this.Lados.Length; i++)
            {
                perimetro = perimetro + this.Lados[i];
            }

            return perimetro * 2;
        }
    }
}