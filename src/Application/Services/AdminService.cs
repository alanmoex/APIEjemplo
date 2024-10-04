using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class AdminService
{
    private readonly IAdminRepository _adminRepository;
    public AdminService(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public List<Admin> GetAdmins()
    {
        return _adminRepository.GetAll();
    }
}
