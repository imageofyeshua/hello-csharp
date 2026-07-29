public class Rhombus
{
  public float DiagonalP { get; set; }
  public float DiagonalQ { get; set; }
  public float Area => DiagonalP * DiagonalQ / 2;

  public Rhombus(float p, float q)
  {
    DiagonalP = p;
    DiagonalQ = q;
  }
}
