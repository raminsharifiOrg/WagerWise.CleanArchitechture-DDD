﻿namespace BettingSystem.Infrastructure.Teams.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Teams;
    using Application.Teams.Queries.All;
    using Application.Teams.Queries.Players;
    using AutoMapper;
    using Common.Events;
    using Common.Persistence.Models;
    using Common.Persistence.Repositories;
    using Domain.Teams.Models;
    using Domain.Teams.Repositories;
    using Microsoft.EntityFrameworkCore;

    internal class TeamRepository : DataRepository<ITeamsDbContext, Team, TeamData>,
        ITeamDomainRepository,
        ITeamQueryRepository
    {
        public TeamRepository(
            ITeamsDbContext db,
            IMapper mapper,
            IEventDispatcher eventDispatcher)
            : base(db, mapper, eventDispatcher)
        {
        }

        public async Task<bool> Delete(
            int id,
            CancellationToken cancellationToken = default)
        {
            var team = await this.Data.Teams.FindAsync(id);

            if (team == null)
            {
                return false;
            }

            this.Data.Teams.Remove(team);

            await this.Data.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<Team> Find(
            int id,
            CancellationToken cancellationToken = default)
            => await this.Mapper
                .ProjectTo<Team>(this
                    .AllAsDataModels()
                    .Where(t => t.Id == id))
                .FirstOrDefaultAsync(cancellationToken);

        public async Task<IEnumerable<GetAllTeamsResponseModel>> GetTeamListings(
            CancellationToken cancellationToken = default)
            => await this.Mapper
                .ProjectTo<GetAllTeamsResponseModel>(this
                    .AllAsDomainModels())
                .ToListAsync(cancellationToken);

        public async Task<IEnumerable<GetTeamPlayersResponseModel>> GetTeamPlayers(
            int teamId,
            CancellationToken cancellationToken = default)
            => await this.Mapper
                .ProjectTo<GetTeamPlayersResponseModel>(this
                    .AllAsDataModels()
                    .Where(t => t.Id == teamId)
                    .SelectMany(t => t.Players))
                .ToListAsync(cancellationToken);
    }
}
