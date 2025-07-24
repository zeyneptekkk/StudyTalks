using BlogApp.Data.Abstarct;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents
{
    public class NewPosts : ViewComponent
    {
        private IPostRepository _postRepository;
        public NewPosts(IPostRepository postRepository)
        {

            _postRepository = postRepository;

        }
        public async Task<IViewComponentResult> InvokeAsync()


        {
            return View(
                 _postRepository
                 .Posts
                 .OrderByDescending(p => p.PublishedOn)
                 .Take(5)
                 .ToList()
                     );

        }
    }
}
