using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoSurvey.Models
{
    /*
    public Team FindById(long id)
    {
        using (IDbConnection dbConnection = Connection)
        {
            dbConnection.Open();
            var query =
            @"
        SELECT * FROM teams WHERE id = @Id;
        SELECT * FROM players WHERE team_id = @Id;
        ";

            using (var multi = dbConnection.QueryMultiple(query, new { Id = id }))
            {
                Team team = multi.Read<Team>().Single();
                team.players = multi.Read<Player>().ToList();
                return team;
            }
        }
    }
    */
}