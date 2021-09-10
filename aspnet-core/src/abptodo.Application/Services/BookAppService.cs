using abptodo.DTOs;
using abptodo.DTOs.Books;
using abptodo.Entities;
using abptodo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abptodo.Services
{
    [Authorize]
    public class BookAppService :
       CrudAppService<
           Book, //The Book entity
           BookDto, //Used to show books
           long, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateBookDto>, //Used to create/update a book
       IBookAppService //implement the IBookAppService
    {
        public BookAppService(IRepository<Book, long> repository)
            : base(repository)
        {
            CreatePolicyName = "BookStore_Create";
            UpdatePolicyName = "BookStore_Edit";
            DeletePolicyName = "BookStore_Delete";
        }
         
        
    }
}
