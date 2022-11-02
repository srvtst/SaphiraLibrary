using Business.Abstract;
using Business.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrate;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public void Add(Author author)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult result = authorValidator.Validate(author);
            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
            _authorDal.Add(author);

        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}