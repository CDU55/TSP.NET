using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostCommentService;

namespace Client_ASP.Comments
{
    public class CreateModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        public CreateModel()
        {
            commentToAdd = new CommentDTO();
        }
        [BindProperty]
        public CommentDTO commentToAdd { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id.HasValue)
            {
                var itemPost = await pcc.GetPostByIdAsync(id.Value);
                ViewData["id"] = id.Value.ToString() + " : " + itemPost.Description;
                commentToAdd.PostPostId = id.Value;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            commentToAdd.PostPostId = id.Value;
            var result = await pcc.SubmitCommentAsync(commentToAdd);
            if (result == null)
            {
                return RedirectToAction("Error");
            }
            return RedirectToPage("/Posts/Index");
        }
    }
}