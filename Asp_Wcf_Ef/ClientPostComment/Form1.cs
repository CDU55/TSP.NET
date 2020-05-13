using PostComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClientPostComment
{
    public partial class Form1 : Form
    {
        List<PostDTO> posts = new List<PostDTO>();
        public Form1()
        {
            InitializeComponent();
            posts = LoadPosts().ToList<PostDTO>();
            dgp.DataSource = posts;
        }
        // Handler pentru evenimentul Load al ferestrei principale
        private void Form1_Load(object sender, EventArgs e)
        {
            posts = LoadPosts().ToList<PostDTO>();
            dgp.DataSource = posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = posts[0].Comments;
        }
        private static PostComment.PostDTO[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            PostComment.PostDTO[] p = pc.GetAllPosts();
            return p;
        }
        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dgc.DataSource = null;
            dgc.DataSource = posts[e.RowIndex].Comments;
        }
    }
}
