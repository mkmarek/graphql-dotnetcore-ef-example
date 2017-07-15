using GraphQLCMS.Database.Entities;
using GraphQLCMS.ViewModels;
using GraphQLCore.Type.Scalar;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GraphQLCMS.Service.Queries
{
    public class AuthorQueries
    {
        private readonly IRepository<Author> authorRepository;

        public AuthorQueries(IUnitOfWork unitOfWork)
        {
            this.authorRepository = unitOfWork.GetRepository<Author>();
        }

        private ICollection<AuthorViewModel> MapAuthorCollection(ICollection<Author> authors)
        {
            return authors.Select(MapAuthor).ToList();
        }

        private AuthorViewModel MapAuthor(Author author)
        {
            return new AuthorViewModel()
            {
                Id = new ID(author.Id.ToString()),
                Name = author.Name,
                Surname = author.Surname
            };
        }

        public PagedListViewModel<AuthorViewModel> Get(int pageIndex, int pageSize)
        {
            var pagedList = this.authorRepository.GetPagedList(
                pageIndex: pageIndex,
                pageSize: pageSize);

            return new PagedListViewModel<AuthorViewModel>()
            {
                HasNextPage = pagedList.HasNextPage,
                HasPreviousPage = pagedList.HasPreviousPage,
                IndexFrom = pagedList.IndexFrom,
                PageIndex = pagedList.PageIndex,
                PageSize = pagedList.PageSize,
                TotalCount = pagedList.TotalCount,
                TotalPages = pagedList.TotalPages,
                Items = this.MapAuthorCollection(pagedList.Items)
            };
        }

        public AuthorViewModel GetById(ID entityIdentifier)
        {
            int id = 0;

            if (int.TryParse(entityIdentifier, out id))
            {
                var author = this.authorRepository.Find(id);

                if (author == null)
                    return null;

                return this.MapAuthor(author);
            }

            return null;
        }
    }
}
