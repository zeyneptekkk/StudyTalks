using BlogApp.Data.Abstarct;
using BlogApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Data.Concrete.EfCore;
namespace BlogApp.Data.Concrete.EfCore
{

    public class EfCommentRepository : ICommmentRepository
    {
        private BlogContext _context; 

        public EfCommentRepository(BlogContext context)
        {
            _context = context;

        }
        public IQueryable<Comment> Comments => _context.Comments;

        public void CreateComment(Comment  comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
