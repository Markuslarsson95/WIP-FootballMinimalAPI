﻿using Application.Interfaces;
using MediatR;
using WebApp.DTOs.Stadium;

namespace Application.Commands.Stadiums
{
    public static class AddStdiumCommand
    {
        public record Command(CreateStadiumDto dto) : IRequest<int>;

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IStadiumRepository _stadiumRepository;

            public Handler(IStadiumRepository stadiumRepository)
            {
                _stadiumRepository = stadiumRepository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var stadium = new WebApp.Models.Stadium
                {
                    Name = request.dto.Name,
                    Location = request.dto.Location,
                    Adress = request.dto.Adress,
                    Capacity = request.dto.Capacity,
                    YearBuilt = request.dto.YearBuilt
                };
                _stadiumRepository.Add(stadium);
                await _stadiumRepository.Save();

                return stadium.Id;
            }
        }
    }
}