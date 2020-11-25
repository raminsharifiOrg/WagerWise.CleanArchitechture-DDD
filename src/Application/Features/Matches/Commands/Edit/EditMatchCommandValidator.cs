﻿namespace BettingSystem.Application.Features.Matches.Commands.Edit
{
    using Common;
    using FluentValidation;

    using static Domain.Models.ModelConstants.Common;

    public class EditMatchCommandValidator : AbstractValidator<EditMatchCommand>
    {
        public EditMatchCommandValidator()
        {
            this.Include(new MatchCommandValidator<EditMatchCommand>());

            this.RuleFor(m => m.HomeTeamScore)
                .InclusiveBetween(Zero, int.MaxValue);

            this.RuleFor(m => m.AwayTeamScore)
                .InclusiveBetween(Zero, int.MaxValue);
        }
    }
}
