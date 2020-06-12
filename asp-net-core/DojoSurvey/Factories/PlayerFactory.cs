/*
public IEnumerable<Player> PlayersWithTeams()
{
    using (IDbConnection dbConnection = Connection)
    {
        var query = $"SELECT * FROM players JOIN teams ON players.team_id=teams.id";
        dbConnection.Open();
 
        IEnumerable<Player> myPlayers = dbConnection.Query<Player, Team, Player>(query, (player, team) => { player.team = team; return player; });
        return myPlayers;
    }
}
*/