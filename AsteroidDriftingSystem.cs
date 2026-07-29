public class AsteroidDriftingSystem
{
  public Asteroid[] Asteroids { get; set; }

  public void Update()
  {
    foreach (Asteroid asteroid in AsteroidGame.Current.Asteroids)
    {
      asteroid.PositionX += asteroid.VelocityX;
      asteroid.PositionY += asteroid.VelocityY;
    }
  }
}
