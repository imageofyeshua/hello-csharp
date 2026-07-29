public class AsteroidGame
{
  private Asteroid[] _asteroids;

  public static AsteroidGame Current { get; set; }

  public Asteroid[] Asteroids => _asteroids;

  public AsteroidGame()
  {
    _asteroids = new Asteroid[5];
    _asteroids[0] = new Asteroid(100, 200, -4, -2);
    _asteroids[1] = new Asteroid(-20, 100, -1, +3);
    _asteroids[2] = new Asteroid(0, 0, 2, 1);
    _asteroids[3] = new Asteroid(400, -100, -3, -1);
    _asteroids[4] = new Asteroid(200, -300, 0, 3);
  }

  public AsteroidGame(Asteroid[] startingAsteroids)
  {
    _asteroids = startingAsteroids;
  }

  public void Run()
  {
    while (true)
    {
      foreach (Asteroid asteroid in _asteroids)
      {
        asteroid.Update();
      }
    }
  }
}
