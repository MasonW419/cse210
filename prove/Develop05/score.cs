using System;

class Score
{
    private int _score;
    public Score()
    {
        _score = 0;
    }
    public int GetScore()
    {
        return _score;
    }
    public void AddScore(int points)
    {
        _score = _score + points;
    }
    public void ResetScore()
    {
        _score = 0;
    }
    public void SetScore(int num)
    {
        _score = num;
    }
}