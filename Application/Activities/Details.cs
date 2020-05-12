using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<MXSong>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, MXSong>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
               _context = context;
            }

            public async Task<MXSong> Handle(Query request, CancellationToken cancellationToken)
            {
               var song = await _context.MXSongs.FindAsync(request.Id);
               return song;
            }
        }
    }
}