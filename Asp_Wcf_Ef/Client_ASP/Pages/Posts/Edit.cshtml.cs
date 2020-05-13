using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostCommentService;

namespace Client_ASP
{
    public class EditModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        [BindProperty]
        public PostDTO post { get; set; }
        public int currentId;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            post = await pcc.GetPostByIdAsync(id.Value);
            post.PostId = id.Value;
            currentId = id.Value;
            if (post == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            post.PostId = id.Value;
            PostDTO p = await pcc.UpdatePostAsync(post);

            return RedirectToPage("./Index");
        }

    }
}