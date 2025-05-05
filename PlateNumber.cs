public class PlateNumber {
    public int Value;
    public bool IsCrossed;
    public int Column;

    public PlateNumber(int value, int column)
    {
        Value = value;
        IsCrossed = false;
        Column = column;
    }
    public void CrossOut()
    {
        IsCrossed = true;
    }
    public bool IsCrossedOut()
    {
        return IsCrossed;
    }
}