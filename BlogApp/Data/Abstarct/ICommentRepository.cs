using BlogApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Data.Abstarct
{
    
    public interface ICommmentRepository
    {
        IQueryable<Comment> Comments { get; }
        void CreateComment(Comment comment);

        

    }
}
