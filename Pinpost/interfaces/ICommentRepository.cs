using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pinpost.Dtos.Comment;
using Pinpost.models;

namespace Pinpost.interfaces
{
    public interface ICommentRepository
    {
        
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id , UpdateCommentRequestDto commentDto);
        Task<Comment?> DeleteAsync(int id);
    }
}