using Microsoft.Xna.Framework;

namespace PersonajeEjemplo
{
    public class Personaje
    {
        public Vector2 Posicion { get; set; }
        public int Velocidad { get; set; }

        public Personaje(Vector2 posicionInicial, int velocidad)
        {
            Posicion = posicionInicial;
            Velocidad = velocidad;
        }
    }
}