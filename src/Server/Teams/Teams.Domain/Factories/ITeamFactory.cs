﻿namespace BettingSystem.Domain.Teams.Factories
{
    using Common;
    using Models;

    public interface ITeamFactory : IFactory<Team>
    {
        ITeamFactory WithName(string name);

        ITeamFactory WithImage(
            byte[] imageOriginal,
            byte[] imageThumbnail);
    }
}