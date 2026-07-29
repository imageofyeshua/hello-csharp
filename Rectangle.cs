public class Rectangle
{
  private float _width;
  private float _height;
  private float _area;

  public Rectangle(float width, float height)
  {
    _width = width;
    _height = height;
    _area = width * height;
  }

  public float GetWidth() => _width;
  public float GetHeight() => _height;
  public float GetArea() => _area;

  public void SetWidth(float value)
  {
    _width = value;
    _area = _width * _height;
  }

  public void SetHeight(float value)
  {
    _height = value;
    _area = _width * _height;
  }

  public static Rectangle CreateSquare(float size) => new Rectangle(size, size);
}
