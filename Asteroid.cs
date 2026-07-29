public class Asteroid
{
  public float PositionX { get; set; }
  public float PositionY { get; set; }
  public float VelocityX { get; set; }
  public float VelocityY { get; set; }

  public Asteroid(float positionX, float positionY,
                  float velocityX, float velocityY)
  {
    PositionX = positionX;
    PositionY = positionY;
    VelocityX = velocityX;
    VelocityY = velocityY;
  }

  public void Update()
  {
    PositionX += VelocityX;
    PositionY += VelocityY;
  }
}
