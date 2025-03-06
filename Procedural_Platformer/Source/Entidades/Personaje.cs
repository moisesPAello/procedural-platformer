using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entidades
{
    public class Personaje
    {
        public Vector2 Posicion { get; set; }
        public int Velocidad { get; set; }
        public Texture2D Textura { get; set; }

        public Personaje(Vector2 posicionInicial, int velocidad)
        {
            Posicion = posicionInicial;
            Velocidad = velocidad;
        }
        public void Dibujar(SpriteBatch spriteBatch)
        {
            if (Textura != null)
            {
                spriteBatch.Draw(Textura, Posicion, Color.White);
            }
        }
    }
}