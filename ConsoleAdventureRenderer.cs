public class ConsoleAdventureRenderer {
  public void Render(StoryNode node) {
    foreach (var line in node.Text) {
      Console.WriteLine(line);
    }
  }
}
