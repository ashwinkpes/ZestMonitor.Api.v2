using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZestMonitor.Api.Data.Entities;

namespace ZestMonitor.Api.Data.Maps
{
    public class BlockchainProposalMap : IEntityTypeConfiguration<BlockchainProposal>
    {
        public void Configure(EntityTypeBuilder<BlockchainProposal> builder)
        {
            builder.ToTable("blockchainproposals");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Url);
            builder.Property(x => x.Hash);
            builder.Property(x => x.FeeHash);
            builder.Property(x => x.Yeas);
            builder.Property(x => x.Nays);
            builder.Property(x => x.Abstains);
            builder.Property(x => x.IsEstablished);
            builder.Property(x => x.IsValid);
            builder.Property(x => x.IsValidReason);
            builder.Property(x => x.FValid);
            builder.Property(x => x.Ratio);
        }
    }
}