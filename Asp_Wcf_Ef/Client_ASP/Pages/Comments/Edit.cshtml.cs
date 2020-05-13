using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostCommentService;

namespace Client_ASP.Comments
{
    public class EditModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        [BindProperty]
        public CommentDTO comment { get; set; }
        public CommentDTO initialComment;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            comment = await pcc.GetCommentByIdAsync(id.Value);
            initialComment = new CommentDTO { CommentId = comment.CommentId, Text = comment.Text, PostPostId = comment.PostPostId };
            if (comment == null)
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
            initialComment = await pcc.GetCommentByIdAsync(id.Value);
            comment.CommentId = id.Value;
            CommentDTO c = await pcc.UpdateCommentAsync(initialComment, comment);

            return RedirectToPage("../Posts/Index");
        }

    }
}