﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestDemo.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMusicRepository Musics { get; }
        IArtistRepository Artists { get; }
        Task<int> CommitAsync();
    }
}
