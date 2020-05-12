using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<MXSong>> { }

        public class Handler : IRequestHandler<Query, List<MXSong>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
               _context = context;
            }

            public async Task<List<MXSong>> Handle(Query request, CancellationToken cancellationToken)
            {
                var songs = await _context.MXSongs.ToListAsync();
                return songs;
            }
        }
    }
}