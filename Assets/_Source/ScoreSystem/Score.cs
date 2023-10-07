using System;

namespace ScoreSystem
{
    public class Score
    {
        private const int _startValue = 5;
        private const int _endValue = 0;
        private int _score;
        public Action<int> OnScoreChanged;
        public void ResetScore() => _score = _endValue;
        public void SetupScore() => _score = _startValue;

        public void AddScore()
        {
            OnScoreChanged?.Invoke(_score);
        }
    }
}
