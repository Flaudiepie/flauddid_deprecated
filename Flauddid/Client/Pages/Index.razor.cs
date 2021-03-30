﻿using Flauddid.Domain;
using Flauddid.Domain.Interfaces;
using Microsoft.AspNetCore.Components;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flauddid.Client.Pages
{
    partial class Index : ComponentBase
    {
        [Inject]
        public IPostService PostService { get; set; }
        [Inject]
        public ICommentsService CommentsService { get; set; }

        private ICollection<Domain.Entities.Post> posts;
        private ICollection<Domain.Entities.Comment> comments;

        protected override async Task OnInitializedAsync()
        {
            //posts = await PostService.GetAsync();
            //comments = await CommentsService.GetAsync("mfmeqd");
            await base.OnInitializedAsync();
        }
    }
}
