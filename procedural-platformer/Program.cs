using System;

class Player
{
    public float x, y;       // Posición del jugador
    public float velocityX;  // Velocidad en X
    public float velocityY;  // Velocidad en Y (para el salto)
    public float speed = 5f; // Velocidad de movimiento
    public float gravity = 0.5f; // Simulación de gravedad
    public bool isGrounded = true; // Verifica si el jugador está en el suelo

    public void Move(string input)
    {
        // Movimiento horizontal
        if (input == "left")
            velocityX = -speed;
        else if (input == "right")
            velocityX = speed;
        else
            velocityX = 0; // Detener si no hay entrada

        // Aplicar la velocidad al jugador
        x += velocityX;
    }

    public void Jump()
    {
        if (isGrounded)
        {
            velocityY = -10f; // Impulso hacia arriba
            isGrounded = false;
        }
    }

    public void Update()
    {
        // Aplicar gravedad
        velocityY += gravity;
        y += velocityY;

        // Simular colisión con el suelo
        if (y >= 0)
        {
            y = 0;
            velocityY = 0;
            isGrounded = true;
        }
    }

    public void DisplayPosition()
    {
        Console.WriteLine($"Posición del jugador: X = {x}, Y = {y}");
    }
}

// Prueba en consola
class Program
{
    static void Main()
    {
        Player player = new Player();

        while (true)
        {
            Console.Write("Mover (left/right), Saltar (jump), o salir (exit): ");
            string input = Console.ReadLine().ToLower();

            if (input == "exit") break;

            if (input == "jump")
                player.Jump();
            else
                player.Move(input);

            player.Update();
            player.DisplayPosition();
        }
    }
}
