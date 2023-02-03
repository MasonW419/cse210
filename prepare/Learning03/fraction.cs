using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction() {
        _bottom = 1;
        _top = 1;
    }
    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop() {
        return _top;
    }
    public void SetTop(int number) {
        _top = number;
    }
    public int GetBottom() {
        return _bottom;
    }
    public void SetBottom(int number) {
        _bottom = number;
    }

    public string GetFractionString() {
        string fraction = $"{GetTop()}/{GetBottom()}";
        return fraction;
    }
    public double GetDecimalValue() {
        double top = Convert.ToDouble(GetTop());
        double bottom = Convert.ToDouble(GetBottom());
        double fraction = top / bottom;
        return fraction;
    }
}