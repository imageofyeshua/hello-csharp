public class Circle
{
  private float _radius;

  public Circle(float radius)
  {
    _radius = radius;
  }

  public float GetRadius() => _radius;
  public float GetArea() => MathF.PI * _radius * _radius;

  public void SetRadius(float value) => _radius = value;
}
