﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoraCorpCM.Domain.Entities
{
    public class FundingSource : IEntity<int>, INamedEntity, IMuseumEntity
    {
        public FundingSource()
        {
            Acquisitions = new HashSet<Acquisition>();
        }

        public int Id { get; set; }

        public virtual Museum Museum { get; set; }
        public int MuseumId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Acquisition> Acquisitions { get; set; }
    }
}
