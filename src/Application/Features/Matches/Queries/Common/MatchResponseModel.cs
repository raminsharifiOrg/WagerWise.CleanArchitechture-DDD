﻿namespace BettingSystem.Application.Features.Matches.Queries.Common
{
    using AutoMapper;
    using Domain.Models.Matches;
    using Mapping;

    public class MatchResponseModel : IMapFrom<Match>
    {
        public int Id { get; private set; }

        public string StartDate { get; private set; } = default!;

        public string HomeTeamName { get; private set; } = default!;

        public string AwayTeamName { get; private set; } = default!;

        public int? HomeTeamScore { get; private set; }

        public int? AwayTeamScore { get; private set; }

        public virtual void Mapping(Profile mapper)
            => mapper
                .CreateMap<Match, MatchResponseModel>()
                .ForMember(m => m.HomeTeamScore, cfg => cfg
                    .MapFrom(m => m.Statistics.HomeScore))
                .ForMember(m => m.AwayTeamScore, cfg => cfg
                    .MapFrom(m => m.Statistics.AwayScore));
    }
}
