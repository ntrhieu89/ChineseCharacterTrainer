﻿using ChineseCharacterTrainer.Model;
using System.Data.Entity.ModelConfiguration;

namespace ChineseCharacterTrainer.ServiceApp.Persistence
{
    public class HighscoreMapping : EntityTypeConfiguration<Highscore>
    {
        public HighscoreMapping()
        {
            HasKey(p => p.Id);
            HasRequired(p => p.QuestionResult).WithMany().HasForeignKey(p => p.QuestionResultId);
        }
    }
}