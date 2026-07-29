public class Oval
{
  private float _a;
  private float _b;

  public Oval(float a, float b)
  {
    _a = a;
    _b = b;
  }

  public float MeasureA
  {
    get => _a;
    set => _a = value;
  }

  public float MeasureB
  {
    get => _b;
    set => _b = value;
  }

  public float Area => _a * _b * MathF.PI;
}
