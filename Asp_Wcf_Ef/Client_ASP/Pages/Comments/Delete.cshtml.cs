using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostCommentService;

namespace Client_ASP.Comments
{
    public class DeleteModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();
        [BindProperty]
        public CommentDTO comment { get; set; }
        public DeleteModel()
        {
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            var comm = await pcc.GetCommentByIdAsync(id.Value);
            if (comm != null)
            {
                comment = new CommentDTO();
                comment.CommentId = comm.CommentId;
                comment.PostPostId = comm.PostPostId;
                comment.Text = comm.Text;
                return Page();
            }
            else
                return NotFound();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            bool result;
            // Nu pot fi sterse inregistrari parinte daca exista descendenti (cheie FK activa)
            // "Prind" exceptia si afisez o pagina cu eroare. Nu e finisat aici...
            try
            {
                result = await pcc.DeleteCommentAsync(id.Value);
                // result ar trebui valorificat mai departe in cod...
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }

            return RedirectToPage("../Posts/Index");
        }
    }
}