using AutoMapperExtension;
using System;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Client, ClientDto>().ReverseMap());

            var clientDto = new ClientDto
            {
                FirstName = "Anas",
                LastName = "CHELLY",
                Address = "France",
                Email = "anaschelly@gmail.com",
                Phone = "010000000"
            };

            var mapper = new Mapper(config);
            var client = mapper.Map<Client>(clientDto);

            Console.WriteLine($"Client information : {client.FirstName} {client.LastName} {client.Address} {client.Email} {client.Phone}");
        }
    }
}
