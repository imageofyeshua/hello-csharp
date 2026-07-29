public class AsteroidDriftingSystem
{
  public void Update(Asteroid[] asteroids)
  {
    foreach (Asteroid asteroid in asteroids)
    {
      asteroid.PositionX += asteroid.VelocityX;
      asteroid.PositionY += asteroid.VelocityY;
    }
  }
}
