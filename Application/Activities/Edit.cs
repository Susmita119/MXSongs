using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Artist { get; set; }
            public string Movie { get; set; }
            public DateTime? Date { get; set; }
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
                var songs = await _context.MXSongs.FindAsync(request.Id);

                if(songs.Id == null)
                throw new Exception("ID not found");

                songs.Name = request.Name ?? songs.Name;
                songs.Artist = request.Name ?? songs.Artist;
                songs.Movie = request.Name ?? songs.Movie;
                songs.Date = request.Date ?? songs.Date;

                 _context.MXSongs.Add(songs);
                var success = await _context.SaveChangesAsync()>0;
                if(success) return Unit.Value;

                 throw new Exception("Problem saving changes");
            }
        }
    }
}