using System;
namespace Tagger.Models
{
	public struct Person
	{
		public string userName { get; set; }
		public IEnumerable<Tag> tags { get; set; }
	}
}

