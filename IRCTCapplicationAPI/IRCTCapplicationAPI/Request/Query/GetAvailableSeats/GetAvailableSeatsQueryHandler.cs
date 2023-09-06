﻿using IRCTC.Repository.Context;
using IRCTCapplicationAPI.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace IRCTCapplicationAPI.Request.Query.GetAvailableSeats
{
    public class GetAvailableSeatsQueryHandler : IRequestHandler<GetAvailableSeatsQuery, List<ViewAvailableSeats>>
    {
        private readonly IrctcContext _context;
        public GetAvailableSeatsQueryHandler(IrctcContext context)

        {
            _context = context;
        }
        public async Task<List<ViewAvailableSeats>> Handle(GetAvailableSeatsQuery request, CancellationToken cancellationToken)
        {
            return await _context.TrainClass.Where(x => x.TrainId == request.TrainId
                 && x.Seats.Select(x => x.TrainClassId).Contains(x.TrainClassId))
                 .Select(x => new ViewAvailableSeats
                 {
                     CoachName = x.Coach.CoachName,
                     Seats = x.Seats.Select(y => y.SeatStatus.Equals("NotConfirmed")).Count()
                 }).ToListAsync();
        }
    }
}