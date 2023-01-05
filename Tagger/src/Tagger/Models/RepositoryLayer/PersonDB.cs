using System;

namespace Tagger.Models.RepositoryLayer
{
	public struct PersonDB
	{
        public string userName { get; set; }
        public IEnumerable<TagDB> tags { get; set; }
    }
}

