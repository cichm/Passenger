using System;
using System.Threading.Tasks;
using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IMapper _mapper;

        public DriverService(IDriverRepository driverRepository, IMapper mapper)
        {
            this._driverRepository = driverRepository;
            this._mapper = mapper;
        }

        public async Task<DriverDto> GetAsync(Guid userId)
        {
            var driver = await _driverRepository.GetAsync(userId);
            
            return this._mapper.Map<Driver,DriverDto>(driver);
        }
    }
}