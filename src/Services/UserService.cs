using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class UserService
    {
        private readonly AppDbContext dbContext;

        public UserService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<User> GetAllUsers(bool showDeleted)
        {
            var users = dbContext.Users.Where(u => showDeleted || !u.IsDeleted).Include(u => u.Role).OrderBy(u => u.Names).ThenBy(u => u.Surnames).ToList();
            return users;
        }

        public User GetUserByEmail(string email)
        {
            var user = dbContext.Users.Where(u => u.Email.Trim().ToUpper() == email.Trim().ToUpper() && !u.IsDeleted).Include(u => u.Role).FirstOrDefault();
            return user;
        }

        public User Login(string email, string password)
        {
            User user = GetUserByEmail(email);
            if (user != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return user;
                }
            }
            return null;
        }

        public User CreateUser(User user)
        {
            user.Names = user?.Names?.Trim().ToUpper();
            user.Surnames = user?.Surnames?.Trim().ToUpper();
            user.Dni = user?.Dni?.Trim().ToUpper();
            user.PhoneNumber = user?.PhoneNumber?.Trim();
            user.Address = user?.Address?.Trim().ToUpper();
            user.Email = user?.Email?.Trim().ToUpper();
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            bool emailExists = dbContext.Users.Any(u => u.Email == user.Email);
            if (emailExists)
            {
                throw new InvalidOperationException("Ya existe un usuario registrado con el correo electrónico ingresado.");
            }
            user.RoleId = user.RoleId;
            user.IsDeleted = false;
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        public User HandleUserStatus(int userId, bool isDeleted)
        {
            var user = dbContext.Users.Find(userId);
            if (user == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }
            user.IsDeleted = isDeleted;
            user.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return user;
        }

        public User ResetPassword(int userId)
        {
            var user = dbContext.Users.Find(userId);
            if (user == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }
            user.Password = BCrypt.Net.BCrypt.HashPassword($"{user.Dni?.Trim().ToUpper()}{DateTime.Now:YYYY}");
            user.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return user;
        }

        public User ChangeRole(int userId, string role)
        {
            var user = dbContext.Users.Find(userId);
            if (user == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }
            var roleEntity = dbContext.Roles.Where(r => r.Name.Trim().ToUpper() == role.Trim().ToUpper()).FirstOrDefault();
            if (roleEntity == null)
            {
                throw new InvalidOperationException("El rol especificado no existe.");
            }
            user.RoleId = roleEntity.Id;
            user.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return user;
        }

        public List<User> GetUsersByDni(string dni, bool showDeleted)
        {
            var users = dbContext.Users
            .Where(c => c.Dni.Contains(dni) && (showDeleted || !c.IsDeleted))
            .OrderBy(c => c.Names)
            .ToList();
            return users;
        }

        public List<User> GetUsersByEmail(string email)
        {
            var users = dbContext.Users.Where(u => u.Email.Trim().ToUpper() == email.Trim().ToUpper()).ToList();
            return users;
        }

        public List<Role> GetAllRoles()
        {
            return dbContext.Roles.OrderBy(r => r.Name).ToList();
        }

        public User ChangePassword(int userId, string currentPassword, string newPassword)
        {
            var user = dbContext.Users.Find(userId);
            if (user == null)
            {
                throw new NullReferenceException("El usuario no existe.");
            }
            if (!BCrypt.Net.BCrypt.Verify(currentPassword, user.Password))
            {
                throw new InvalidOperationException("La contraseña actual es incorrecta.");
            }
            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            user.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return user;
        }
    }
}
