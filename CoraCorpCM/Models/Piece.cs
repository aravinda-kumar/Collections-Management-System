﻿using System;
using System.Collections.Generic;

namespace CoraCorpCM.Models
{
    public class Piece
    {
        public Piece()
        {
            ExhibitionPieces = new HashSet<ExhibitionPiece>();
            Inspections = new HashSet<Inspection>();
            LoanPieces = new HashSet<LoanPiece>();
            PieceArtists = new HashSet<PieceArtist>();
            PieceTags = new HashSet<PieceTag>();
        }

        public int Id { get; set; }
        public Museum Museum { get; set; }
        public int RecordNumber { get; set; }
        public string AccessionNumber { get; set; }
        public string Title { get; set; }
        public File Photo { get; set; }
        public DateTime CreationDate { get; set; }
        public Origin CreationOrigin { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public decimal EstimatedValue { get; set; }
        public Medium Medium { get; set; }
        public Genre Genre { get; set; }
        public Subgenre Subgenre { get; set; }
        public string Subject { get; set; }
        public SubjectMatter SubjectMatter { get; set; }
        public DateTime CopyrightYear { get; set; }
        public string CopyrightOwner { get; set; }
        public Acquisition Acquisition { get; set; }
        public InsurancePolicy InsurancePolicy { get; set; }
        public bool IsFramed { get; set; }
        public Location CurrentLocation { get; set; }
        public Location PermanentLocation { get; set; }
        public Collection Collection { get; set; }
        public DateTime Created { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public ApplicationUser LastModifiedBy { get; set; }
        public ICollection<ExhibitionPiece> ExhibitionPieces { get; set; }
        public ICollection<Inspection> Inspections { get; set; }
        public ICollection<LoanPiece> LoanPieces { get; set; }
        public ICollection<PieceArtist> PieceArtists { get; set; }
        public ICollection<PieceTag> PieceTags { get; set; }
    }
}