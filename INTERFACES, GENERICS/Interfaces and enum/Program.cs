public enum ColourEnum
{
    Red,
    Green,
    Blue
}
interface IColoured
{
    ColourEnum Colour
    {
        get { return ColourEnum.Red; }
    }
}
interface IDocument
{
    static string defaultText = "Lorem ipsum";
    public int Pages
    {
        get; set;
    }
    public string Name { get; set; }
    public void AddPages(int value) 
        => this.Pages += value;
    public void Rename(string newName) 
        => this.Name = newName;

}
class ColouredDocument : IColoured, IDocument
{
    public string Name { get; set; }
    public int Pages { get; set; }
    public ColourEnum Colour
    {
        get
        {
            return ColourEnum.Red;
        }
        set { }
    }
    public ColouredDocument() { }
    public ColouredDocument(ColourEnum color)
    {
        this.Colour = color;
    }
}
class Example
{
    public static void Do()
    {
        ColouredDocument doc1 = new ColouredDocument();
        doc1.Name = "Document1";
        Console.WriteLine(doc1.Name);
        ((IDocument)doc1).Rename("Document2");
        Console.WriteLine(doc1.Name);
    }
}
