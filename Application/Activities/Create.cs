using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Artist { get; set; }
            public string Movie { get; set; }
            public DateTime Date { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var song = new MXSong
                {
                    Id = request.Id,
                    Name = request.Name,
                    Artist = request.Artist,
                    Movie = request.Movie,
                    Date = request.Date

                };

                 _context.MXSongs.Add(song);
                var success = await _context.SaveChangesAsync()>0;
                if(success) return Unit.Value;

                 throw new Exception("Problem saving changes");
            }
        }

    }
}