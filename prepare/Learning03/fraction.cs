using System.Dynamic;

public class Fraction
{
    private int _bottom;
    private int _top;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;

    }

    public Fraction(int wholeNumber)
    {
        _bottom = 1;
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }


    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string str;
        return str = $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}