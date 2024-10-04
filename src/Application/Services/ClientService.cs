using System;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public List<Client> GetAll()
    {
        return _clientRepository.GetAll();
    }

    public Client GetById(int id)
    {
        return _clientRepository.GetById(id);
    }

    public void Add(Client client)
    {
        _clientRepository.Add(client);
    }

    public void Update(int id, Client client)
    {
        _clientRepository.Update(id, client);
    }

    public void Delete(int id)
    {
        Client client = _clientRepository.GetById(id);
        _clientRepository.Delete(client);
    }
}
