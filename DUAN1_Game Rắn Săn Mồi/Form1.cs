using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}

public struct Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Game
{
    private const int Width = 20;
    private const int Height = 10;
    private List<Position> snake;
    private static Position food;
    private Position direction;
    private bool gameOver;

    public Game()
    {
        snake = new List<Position> { new Position(6, 6) };
        direction = new Position(0, 0); // Bắt đầu đi sang phải
        gameOver = false;
        GenerateFood();
    }

    public void Start()
    {
        while (!gameOver)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                direction = key switch
                {
                    ConsoleKey.UpArrow => new Position(0, -1),
                    ConsoleKey.DownArrow => new Position(0, 1),
                    ConsoleKey.LeftArrow => new Position(-1, 0),
                    ConsoleKey.RightArrow => new Position(1, 0),
                    _ => direction
                };
            }

            UpdateSnake();
            Draw();
            Thread.Sleep(100);
        }

        Console.Clear();
        Console.WriteLine("Game Over!");
    }

    private void UpdateSnake()
    {
        Position newHead = new Position(snake[0].X + direction.X, snake[0].Y + direction.Y);

        // Kiểm tra va chạm với tường hoặc thân rắn
        if (newHead.X < 0 || newHead.X >= Width || newHead.Y < 0 || newHead.Y >= Height || snake.Skip(1).Any(s => s.X == newHead.X && s.Y == newHead.Y))
        {
            gameOver = true;
            return;
        }

        snake.Insert(0, newHead);

        // Kiểm tra ăn mồi
        if (newHead.X == food.X && newHead.Y == food.Y)
        {
            GenerateFood();

            // Tạo mồi mới
        }
        else
        {
            snake.RemoveAt(snake.Count - 1); // Xóa đuôi rắn
        }
    }

    private void GenerateFood()
    {
        Random rand = new Random();
        food = new Position(rand.Next(0, Width), rand.Next(0, Height));
    }

    private void Draw()
    {
        Console.Clear();

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                {
                    Console.Write("#"); // Vẽ tường
                }
                else if (snake.Any(s => s.X == x && s.Y == y))
                {
                    Console.Write("0"); // Vẽ rắn
                }
                else if (food.X == x && food.Y == y)
                {
                    Console.Write("o"); // Vẽ mồi
                }
                else
                {
                    Console.Write(" "); // Vùng trống
                }
            }
            Console.WriteLine();
        }
    }
}
