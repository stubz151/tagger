using System;
using Amazon.DynamoDBv2.DataModel;
using Tagger.Interfaces;
using Tagger.Models.RepositoryLayer;

namespace Tagger.Repository
{
	public class PersonDAO : IPersonDAO
	{
        private readonly IDynamoDBContext _context;
        public PersonDAO(IDynamoDBContext context)
		{
            _context = context;
        }

        void IPersonDAO.deletePerson()
        {
            throw new NotImplementedException();
        }

        PersonDB IPersonDAO.getPerson()
        {
            throw new NotImplementedException();
        }

        PersonDB IPersonDAO.updatePerson()
        {
            throw new NotImplementedException();
        }
    }
}

