public class Score
{
  public string _name;
  public int _points;
  public int _level;

  public Score() : this("Unknown", 0, 1) { }

  public Score(string name, int points, int level)
  {
    _name = name;
    _points = points;
    _level = level;
  }
}
