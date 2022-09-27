using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Motel.Application.Contracts;
using Motel.Application.Contracts.Infrastructure;
using Motel.Application.Models;
using Motel.Domain.Entities;

namespace Motel.Application.Features.MovimientoHabitacion.Commands.MovimientoHabitacionRegistrarEntrada
{
    public class MovimientoHabitacionRegistrarEntradaCommandHandler : IRequestHandler<MovimientoHabitacionRegistrarEntradaCommand, int>
    {
        private readonly IMovimientoHabitacionRepository _movimientoHabitacionRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<MovimientoHabitacionRegistrarEntradaCommandHandler> _logger;

        public MovimientoHabitacionRegistrarEntradaCommandHandler(IMovimientoHabitacionRepository movimientoHabitacionRepository, IMapper mapper, IEmailService emailService, ILogger<MovimientoHabitacionRegistrarEntradaCommandHandler> logger)
        {
            _movimientoHabitacionRepository = movimientoHabitacionRepository;
            _mapper = mapper;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<int> Handle(MovimientoHabitacionRegistrarEntradaCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<MovimientoHabitacionModel>(request);
            var newEntity = await _movimientoHabitacionRepository.AddAsync(entity);

            _logger.LogInformation($"Movimiento Habitación {newEntity} fue registrado exitosamente");

            await SendEmail(newEntity);

            return newEntity.Id;

        }

        private async Task SendEmail(MovimientoHabitacionModel movimientoHabitacion)
        {
            var email = new Email
            {
                To = "mkcfernandez@gmail.com",
                Subject = "Nuevo Movimiento Registrado!",
                Body = "Se ha registrado el movimiento correctamente"
            };

            try
            {
                await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al intentar enviar el email del registro de {movimientoHabitacion.Id}");
            }


        }
    }
}
