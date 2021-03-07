﻿namespace BettingSystem.Domain.Betting
{
    using Common.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DomainConfiguration
    {
        public static IServiceCollection AddDomain(
            this IServiceCollection services)
            => services.AddCommonDomain();
    }
}
