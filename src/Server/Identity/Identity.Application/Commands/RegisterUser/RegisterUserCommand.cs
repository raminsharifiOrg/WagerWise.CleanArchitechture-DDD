﻿namespace BettingSystem.Application.Identity.Commands.RegisterUser;

using System.Threading;
using System.Threading.Tasks;
using Common;
using MediatR;

public class RegisterUserCommand : UserRequestModel, IRequest<Result>
{
    public RegisterUserCommand(
        string email,
        string password,
        string confirmPassword)
        : base(email, password)
        => this.ConfirmPassword = confirmPassword;

    public string ConfirmPassword { get; }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result>
    {
        private readonly IIdentity identity;

        public RegisterUserCommandHandler(IIdentity identity)
            => this.identity = identity;

        public async Task<Result> Handle(
            RegisterUserCommand request,
            CancellationToken cancellationToken)
            => await this.identity.Register(request);
    }
}