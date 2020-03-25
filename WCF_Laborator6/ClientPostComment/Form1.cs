﻿using PostComment;
using PostCommentService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPostComment
{
    public partial class Form1 : Form
    {
        List<PostDTO> posts = new List<PostDTO>();

        public Form1()
        {
            InitializeComponent();
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
        private static PostDTO[] LoadPosts()
        {
            ServicePostComment pc = new ServicePostComment();
            PostDTO[] p = pc.GetAllPosts().ToArray();
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
