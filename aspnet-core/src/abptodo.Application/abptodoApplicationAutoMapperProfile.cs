using abptodo.DTOs;
using abptodo.DTOs.Books;
using abptodo.Entities;
using AutoMapper;

namespace abptodo
{
    public class abptodoApplicationAutoMapperProfile : Profile
    {
        public abptodoApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            //Book
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();

        }
    }
}
