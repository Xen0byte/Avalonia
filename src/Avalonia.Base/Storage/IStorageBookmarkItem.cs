﻿#nullable enable
using System.Threading.Tasks;

namespace Avalonia.Storage
{
    public interface IStorageBookmarkItem : IStorageItem
    {
        Task Release();
        Task<bool> RequestPermissions();
    }

    public interface IStorageBookmarkFile : IStorageFile, IStorageBookmarkItem
    {
    }

    public interface IStorageBookmarkFolder : IStorageFolder, IStorageBookmarkItem
    {

    }
}