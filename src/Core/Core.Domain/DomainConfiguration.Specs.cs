﻿namespace BettingSystem.Domain
{
    using System.Linq;
    using Common;
    using Competitions.Factories;
    using FluentAssertions;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;

    public class DomainConfigurationSpecs
    {
        [Fact]
        public void AddDomainShouldRegisterFactories()
        {
            var serviceCollection = new ServiceCollection();

            var services = serviceCollection
                .AddDomain()
                .BuildServiceProvider();

            services
                .GetService<ILeagueFactory>()
                .Should()
                .NotBeNull();
        }

        [Fact]
        public void AddDomainShouldRegisterInitialData()
        {
            var serviceCollection = new ServiceCollection();

            var services = serviceCollection
                .AddDomain()
                .BuildServiceProvider();

            services
                .GetServices<IInitialData>()
                .ToList()
                .ForEach(initialData => initialData
                    .Should()
                    .NotBeNull());
        }
    }
}
