﻿namespace WebApp.DTOs.Club
{
    public record UpdateClubDto(
        string Name,
        int LeaguePoints,
        int MatchesPlayed,
        int Wins,
        int Losses,
        int Draws,
        int Goals,
        int GoalsConceded,
        int CleanSheets,
        int YearFounded,
        int StadiumId);
}
