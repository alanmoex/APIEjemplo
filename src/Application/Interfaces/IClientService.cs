using System;
using Domain.Entities;

namespace Application.Interfaces;

public interface IClientService
{
    public List<Client> GetAll();  
    public Client GetById(int id);   
    public void Add(Client client);
    public void Update(int id, Client client);
    public void Delete(int id);
    
}
