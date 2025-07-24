using BlogApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Data.Abstarct
{
    
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void CreateUser(User user);

        

    }
}
