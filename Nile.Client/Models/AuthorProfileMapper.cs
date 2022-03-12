using AutoMapper;
using Nile.lib;

namespace Nile.Client.Models
{
    public class AuthorProfileMapper : Profile
    {
        public AuthorProfileMapper()
        {
            CreateMap<Author, EditAuthorModel>()
                .ForMember(dist => dist.ConfirmEmail,
                    option => option.MapFrom(src => src.Email));
            CreateMap<EditAuthorModel, Author>();
        }
    }
}