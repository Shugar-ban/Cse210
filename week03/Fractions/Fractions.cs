using System;

// Fraction class
public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor: default to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor: whole number becomes wholeNumber/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor: top and bottom provided
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for Top
    public int GetTop() => _top;
    public void SetTop(int top) => _top = top;

    // Getter and Setter for Bottom
    public int GetBottom() => _bottom;
    public void SetBottom(int bottom) => _bottom = bottom;

    // Returns fraction as string, e.g., "3/4"
    public string GetFractionString() => $"{_top}/{_bottom}";

    // Returns decimal value
    public double GetDecimalValue() => (double)_top / _bottom;
}
