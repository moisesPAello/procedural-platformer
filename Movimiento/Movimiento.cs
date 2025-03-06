using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PersonajeEjemplo
{
    public class claseMovimiento
    {
        public void Mover(Personaje personaje, GameTime gameTime)
        {
            KeyboardState estadoTeclado = Keyboard.GetState();
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Vector2 nuevaPosicion = personaje.Posicion;

            if (estadoTeclado.IsKeyDown(Keys.W))
                nuevaPosicion.Y -= personaje.Velocidad * deltaTime;
            if (estadoTeclado.IsKeyDown(Keys.S))
                nuevaPosicion.Y += personaje.Velocidad * deltaTime;
            if (estadoTeclado.IsKeyDown(Keys.A))
                nuevaPosicion.X -= personaje.Velocidad * deltaTime;
            if (estadoTeclado.IsKeyDown(Keys.D))
                nuevaPosicion.X += personaje.Velocidad * deltaTime;

            personaje.Posicion = nuevaPosicion;
        }
    }
}