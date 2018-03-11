﻿using CoraCorpCM.Domain.Models;
using CoraCorpCM.Web.ViewModels.CollectionViewModels;

namespace CoraCorpCM.Web.Utilities
{
    public interface IModelMapper
    {
        Piece ResolveToPieceModel(PieceViewModel pieceViewModel, ApplicationUser user);
    }
}