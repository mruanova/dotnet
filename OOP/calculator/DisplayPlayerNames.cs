namespace calculator
{
    public class DisplayPlayerNames
    {
        delegate int ScoreDelegate(PlayerStats stats);
        void onGameOver(PlayerStats[] allPlayersStats)
        {
            string playerNameMostKills = GetPlayerNameTopScore(allPlayersStats, stats => stats.kills);
            string playerNameMostFlags = GetPlayerNameTopScore(allPlayersStats, stats => stats.flags);
        }
        string GetPlayerNameTopScore(PlayerStats[] allPlayersStats, ScoreDelegate scoreCalculator)
        {
            string name = "";
            int bestScore = 0;
            foreach (PlayerStats stats in allPlayersStats)
            {
                int score = scoreCalculator(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.name;
                }
            }
            return name;
        }
    }
}
